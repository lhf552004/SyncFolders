namespace SyncFolders
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.TargetfolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourcefolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectSourceFolderButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SelectTargetFolderbutton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddPairButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.StartButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SourcePathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TargetPathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PathPairlistView = new System.Windows.Forms.ListView();
            this.SourcePathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TargetPathColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Auto Backup";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SelectSourceFolderButton
            // 
            this.SelectSourceFolderButton.Depth = 0;
            this.SelectSourceFolderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SelectSourceFolderButton.Location = new System.Drawing.Point(35, 73);
            this.SelectSourceFolderButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectSourceFolderButton.Name = "SelectSourceFolderButton";
            this.SelectSourceFolderButton.Primary = true;
            this.SelectSourceFolderButton.Size = new System.Drawing.Size(189, 57);
            this.SelectSourceFolderButton.TabIndex = 6;
            this.SelectSourceFolderButton.Text = "Select Source Folder";
            this.SelectSourceFolderButton.UseVisualStyleBackColor = true;
            this.SelectSourceFolderButton.Click += new System.EventHandler(this.SelectSourceFolderButton_Click);
            // 
            // SelectTargetFolderbutton
            // 
            this.SelectTargetFolderbutton.Depth = 0;
            this.SelectTargetFolderbutton.Location = new System.Drawing.Point(35, 176);
            this.SelectTargetFolderbutton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectTargetFolderbutton.Name = "SelectTargetFolderbutton";
            this.SelectTargetFolderbutton.Primary = true;
            this.SelectTargetFolderbutton.Size = new System.Drawing.Size(189, 57);
            this.SelectTargetFolderbutton.TabIndex = 6;
            this.SelectTargetFolderbutton.Text = "Select Target Folder";
            this.SelectTargetFolderbutton.UseVisualStyleBackColor = true;
            this.SelectTargetFolderbutton.Click += new System.EventHandler(this.SelectTargetFolderbutton_Click);
            // 
            // AddPairButton
            // 
            this.AddPairButton.Depth = 0;
            this.AddPairButton.Location = new System.Drawing.Point(40, 284);
            this.AddPairButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddPairButton.Name = "AddPairButton";
            this.AddPairButton.Primary = true;
            this.AddPairButton.Size = new System.Drawing.Size(189, 57);
            this.AddPairButton.TabIndex = 6;
            this.AddPairButton.Text = "Add Pair";
            this.AddPairButton.UseVisualStyleBackColor = true;
            this.AddPairButton.Click += new System.EventHandler(this.AddPairButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Depth = 0;
            this.StartButton.Location = new System.Drawing.Point(398, 350);
            this.StartButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartButton.Name = "StartButton";
            this.StartButton.Primary = true;
            this.StartButton.Size = new System.Drawing.Size(189, 57);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Location = new System.Drawing.Point(886, 73);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(189, 57);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SourcePathLabel
            // 
            this.SourcePathLabel.AutoSize = true;
            this.SourcePathLabel.Depth = 0;
            this.SourcePathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.SourcePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SourcePathLabel.Location = new System.Drawing.Point(31, 144);
            this.SourcePathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.SourcePathLabel.Name = "SourcePathLabel";
            this.SourcePathLabel.Size = new System.Drawing.Size(90, 19);
            this.SourcePathLabel.TabIndex = 8;
            this.SourcePathLabel.Text = "Source Path";
            // 
            // TargetPathLabel
            // 
            this.TargetPathLabel.AutoSize = true;
            this.TargetPathLabel.Depth = 0;
            this.TargetPathLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TargetPathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TargetPathLabel.Location = new System.Drawing.Point(37, 246);
            this.TargetPathLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TargetPathLabel.Name = "TargetPathLabel";
            this.TargetPathLabel.Size = new System.Drawing.Size(86, 19);
            this.TargetPathLabel.TabIndex = 8;
            this.TargetPathLabel.Text = "Target Path";
            // 
            // PathPairlistView
            // 
            this.PathPairlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SourcePathColumnHeader,
            this.TargetPathColumnHeader});
            this.PathPairlistView.FullRowSelect = true;
            this.PathPairlistView.Location = new System.Drawing.Point(250, 73);
            this.PathPairlistView.Name = "PathPairlistView";
            this.PathPairlistView.Size = new System.Drawing.Size(591, 268);
            this.PathPairlistView.TabIndex = 9;
            this.PathPairlistView.UseCompatibleStateImageBehavior = false;
            this.PathPairlistView.View = System.Windows.Forms.View.Details;
            // 
            // SourcePathColumnHeader
            // 
            this.SourcePathColumnHeader.Text = "SourcePath";
            this.SourcePathColumnHeader.Width = 290;
            // 
            // TargetPathColumnHeader
            // 
            this.TargetPathColumnHeader.Text = "TargetPath";
            this.TargetPathColumnHeader.Width = 278;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 419);
            this.Controls.Add(this.PathPairlistView);
            this.Controls.Add(this.TargetPathLabel);
            this.Controls.Add(this.SourcePathLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.AddPairButton);
            this.Controls.Add(this.SelectTargetFolderbutton);
            this.Controls.Add(this.SelectSourceFolderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.ShowInTaskbar = false;
            this.Text = "Auto Backup Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog TargetfolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog SourcefolderBrowserDialog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton SelectSourceFolderButton;
        private MaterialSkin.Controls.MaterialRaisedButton SelectTargetFolderbutton;
        private MaterialSkin.Controls.MaterialRaisedButton AddPairButton;
        private MaterialSkin.Controls.MaterialRaisedButton StartButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialLabel SourcePathLabel;
        private MaterialSkin.Controls.MaterialLabel TargetPathLabel;
        private System.Windows.Forms.ListView PathPairlistView;
        private System.Windows.Forms.ColumnHeader SourcePathColumnHeader;
        private System.Windows.Forms.ColumnHeader TargetPathColumnHeader;
       
    }
}

