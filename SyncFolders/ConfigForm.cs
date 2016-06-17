using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using MaterialSkin;
using MaterialSkin.Controls;
using BusinessObjects;

namespace SyncFolders
{
    public partial class ConfigForm : MaterialForm
    {
        public ConfigForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo600, Primary.Indigo500, Primary.Indigo600, Accent.LightBlue200, TextShade.WHITE);
        }

        private string _targetPath;
        private string _sourcePath;
        private string _configPath = System.Environment.CurrentDirectory + "\\syncConfig.xml";
        XmlDocument configXmlDoc;
        XmlElement root;
        private Dictionary<string, string> pathPair = new Dictionary<string, string>();
        private LogHandler _logHander;
        private string _logName = "AutoBackup";
        

        private void Main_Load(object sender, EventArgs e)
        {
            _logHander = new LogHandler("", _logName);
            pathPair.Clear();
            readConfiguration();
            disableStartButton();
            updateList();
            Utils.readFilters();
        }

        
        private void updateList()
        {
            this.PathPairlistView.Items.Clear();
            this.PathPairlistView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度  
            int i = 0;
            foreach (var item in pathPair)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.ImageIndex = i;     //通过与imageList绑定，显示imageList中第i项图标  

                lvi.Text = item.Key;

                lvi.SubItems.Add(item.Value);
                
                this.PathPairlistView.Items.Add(lvi);
                i++;
            }
            this.PathPairlistView.EndUpdate();  //结束数据处理，UI界面一次性绘制。  
        }
        private void disableStartButton()
        {
            if (pathPair.Count > 0)
            {
                StartButton.Enabled = true;
            }
            else
            {
                StartButton.Enabled = false;
            }
        }
        private void SelectTargetFolderbutton_Click(object sender, EventArgs e)
        {
            if (TargetfolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _targetPath = TargetfolderBrowserDialog.SelectedPath;
                TargetPathLabel.Text = _targetPath;
            }
        }

        private void SelectSourceFolderButton_Click(object sender, EventArgs e)
        {
            if (SourcefolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _sourcePath = SourcefolderBrowserDialog.SelectedPath;
                SourcePathLabel.Text = _sourcePath;
            }
        }

        private void AddPairButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_sourcePath) && !string.IsNullOrEmpty(_targetPath))
            {
                if (!pathPair.ContainsKey(_sourcePath))
                {
                    pathPair.Add(_sourcePath, _targetPath);

                    XmlNode subPar = CreateNode(configXmlDoc, root, "PathPair", null);
                    CreateNode(configXmlDoc, subPar, "sourcePath", _sourcePath);
                    CreateNode(configXmlDoc, subPar, "targetPath", _targetPath);
                    disableStartButton();
                    updateList();
                    _targetPath = "";
                    _sourcePath = "";
                }

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Text = this.timer1.Enabled ? "Start" : "Stop";
            this.timer1.Enabled = !this.timer1.Enabled;
            disableAllButtons();

            if (timer1.Enabled)
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
                this.notifyIcon1.ShowBalloonTip(2000, "AutoBackup started", "Thank you for using SyncFolders",ToolTipIcon.Info);
                startToolStripMenuItem.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
            }
        }

        private void disableAllButtons()
        {
            if (timer1.Enabled)
            {
                SelectSourceFolderButton.Enabled = false;
                SelectTargetFolderbutton.Enabled = false;
                AddPairButton.Enabled = false;
                DeleteButton.Enabled = false;
            }
            else
            {
                SelectSourceFolderButton.Enabled = true;
                SelectTargetFolderbutton.Enabled = true;
                AddPairButton.Enabled = true;
                DeleteButton.Enabled = true;
            }
        }

        private void updateDir(string sourcePath, string targetPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (targetPath[targetPath.Length - 1] != Path.DirectorySeparatorChar)
                    targetPath += Path.DirectorySeparatorChar;
                // 判断目标目录是否存在如果不存在则新建之
                if (!Directory.Exists(targetPath))
                    Directory.CreateDirectory(targetPath);
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles(srcPath);
                string[] fileList = Directory.GetFileSystemEntries(sourcePath);
                // 遍历所有的文件和目录
                foreach (string item in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(item))
                        updateDir(item, targetPath + Path.GetFileName(item));
                    else
                    {
                        string targetFileName = targetPath + Path.GetFileName(item);
                        FileInfo sourceFile = new FileInfo(item);
                        FileInfo targetFile = new FileInfo(targetFileName);
                        bool isExisted = targetFile.Exists;
                        bool isNeedToOverride = false;
                        if (isExisted)
                        {
                            if (targetFile.Name == sourceFile.Name)
                            {
                                if (sourceFile.LastWriteTime > targetFile.LastWriteTime)
                                {
                                    isNeedToOverride = true;
                                }

                            }
                        }

                        if (!isExisted || isNeedToOverride)
                        {
                            File.Copy(item, targetFileName, true);
                        }

                    }

                }
            }
            catch(Exception e)
            {
                _logHander.logging("无法复制! " + e.Message);
                this.notifyIcon1.ShowBalloonTip(2000, "无法复制", "Please check the log file", ToolTipIcon.Error);
                //Console.WriteLine("无法复制!");
            }
        }

        /// <summary>
        /// Inspect the file is existed in the sourcePath, 
        /// if not, delete it in the targetPath
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <param name="targetPath"></param>
        private void deleteTrash(string sourcePath, string targetPath, bool isParentFolder = false)
        {
            try
            {
                if (!Directory.Exists(sourcePath))
                {
                    if (!isParentFolder)
                    {
                        Directory.Delete(targetPath, true);
                    }
                    return;
                }
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (targetPath[targetPath.Length - 1] != Path.DirectorySeparatorChar)
                    targetPath += Path.DirectorySeparatorChar;
                if (sourcePath[sourcePath.Length - 1] != Path.DirectorySeparatorChar)
                    sourcePath += Path.DirectorySeparatorChar;
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向Delete目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles(aimPath);
                string[] fileList = Directory.GetFileSystemEntries(targetPath);
                // 遍历所有的文件和目录
                foreach (string item in fileList)
                {

                    // 先当作目录处理如果存在这个目录就递归Delete该目录下面的文件
                    if (Directory.Exists(item))
                    {

                        deleteTrash(sourcePath + Path.GetFileName(item), targetPath + Path.GetFileName(item));
                    }
                    // 否则直接Delete文件
                    else
                    {
                        string sourceItem = sourcePath + Path.GetFileName(item);
                        if (!File.Exists(sourceItem))
                        {
                            File.Delete(targetPath + Path.GetFileName(item));
                        }
                    }
                }
                //删除文件夹
                //System.IO .Directory .Delete (aimPath,true);
            }
            catch(Exception e)
            {
                _logHander.logging("无法删除! " + e.Message);
                this.notifyIcon1.ShowBalloonTip(2000, "无法删除", "Please check the log file", ToolTipIcon.Error);
            }
        }

        
        private void readConfiguration()
        {
            try
            {
                if (File.Exists(_configPath))
                {
                    configXmlDoc = new XmlDocument();
                    configXmlDoc.Load(_configPath);
                    XmlNodeList targetTextNodes = configXmlDoc.GetElementsByTagName("PathPair");
                    foreach (XmlNode pair in targetTextNodes)
                    {
                        string sourcePath = "";
                        string targetPath = "";
                        foreach (XmlNode pathNode in pair.ChildNodes)
                        {

                            if (pathNode.Name == "sourcePath")
                            {
                                sourcePath = pathNode.InnerText;
                            }
                            if (pathNode.Name == "targetPath")
                            {
                                targetPath = pathNode.InnerText;
                            }
                        }
                        if (!string.IsNullOrEmpty(sourcePath) && !pathPair.ContainsKey(targetPath))
                        {
                            pathPair.Add(sourcePath, targetPath);
                        }
                    }
                }
                else
                {
                    createXmlFile();
                }
                root = configXmlDoc.DocumentElement;
            }
            catch(Exception e)
            {
                _logHander.logging("XML读取失败! " + e.Message);
                this.notifyIcon1.ShowBalloonTip(2000, "XML读取失败", "Please check the log file", ToolTipIcon.Error);
            }

        }


        private void createXmlFile()
        {
            configXmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = configXmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            configXmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = configXmlDoc.CreateElement("PathPairs");
            configXmlDoc.AppendChild(root);
            try
            {
                configXmlDoc.Save(_configPath);
            }
            catch (Exception e)
            {
                //  
                _logHander.logging(e.Message);
                this.notifyIcon1.ShowBalloonTip(2000, "XML保存失败", "Please check the log file", ToolTipIcon.Error);
            }
            //Console.ReadLine();  

        }
        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param name="xmldoc"></param>  xml文档  
        /// <param name="parentnode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  节点值  
        public XmlNode CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
            configXmlDoc.Save(_configPath);
            return node;
        }
        private void removaeNode(string sourcePath)
        {
            string xPath = "//sourcePath[contains(text(),'" + sourcePath + "')]";
            XmlNodeList selectedNode = root.SelectNodes(xPath);
            foreach (XmlNode node in selectedNode)
            {
                root.RemoveChild(node.ParentNode);
            }
            configXmlDoc.Save(_configPath);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string targetPath = "";
            string sourcePath = "";
            foreach (var item in pathPair)
            {
                sourcePath = item.Key;
                targetPath = item.Value;
                updateDir(sourcePath, targetPath);
                deleteTrash(sourcePath, targetPath, true);
            }
        }

       

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            if (PathPairlistView.SelectedItems.Count > 0)
            {

                string sourcePath = PathPairlistView.SelectedItems[0].SubItems[0].Text;
                if (pathPair.ContainsKey(sourcePath))
                {
                    pathPair.Remove(sourcePath);
                    removaeNode(sourcePath);

                }
                PathPairlistView.SelectedItems[0].Remove();
                disableStartButton();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartButton_Click(null, null);
            startToolStripMenuItem.Enabled = true;
            stopToolStripMenuItem.Enabled = false;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartButton_Click(null, null);
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
        }

        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to exit autoBackup？", "Confirm to exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                this.notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About newAbout = new About();
            newAbout.Show();
        }

      




    }
}
