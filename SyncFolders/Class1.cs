using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SyncFolders
{
    public class Class1
    {

        /// <summary>
        /// 将整个文件夹复制到目标文件夹中。
        /// </summary>
        /// <param name="srcPath">源文件夹</param>
        /// <param name="aimPath">目标文件夹</param>
        public static void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // 判断目标目录是否存在如果不存在则新建之
                if (!Directory.Exists(aimPath))
                    Directory.CreateDirectory(aimPath);
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles(srcPath);
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    // 否则直接Copy文件
                    else
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                }
            }
            catch
            {
                Console.WriteLine("无法复制!");
            }
        }
        /// <summary>
        /// 将整个文件夹删除。
        /// </summary>
        /// <param name="aimPath">目标文件夹</param>
        public static void DeleteDir(string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                    aimPath += Path.DirectorySeparatorChar;
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向Delete目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles(aimPath);
                string[] fileList = Directory.GetFileSystemEntries(aimPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Delete该目录下面的文件
                    if (Directory.Exists(file))
                    {
                        DeleteDir(aimPath + Path.GetFileName(file));
                    }
                    // 否则直接Delete文件
                    else
                    {
                        File.Delete(aimPath + Path.GetFileName(file));
                    }
                }
                //删除文件夹
                //System.IO .Directory .Delete (aimPath,true);
            }
            catch
            {
                Console.WriteLine("无法删除!");
            }
        }


    }
}
