using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecodeHelperApplication1
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowser;
        private FolderBrowserDialog targetFolderBrowser;
        string newExtension = ".ini";
        /// <summary>
        /// 构造方法
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            folderBrowser = new FolderBrowserDialog();
            targetFolderBrowser = new FolderBrowserDialog();
            
        }
        /// <summary>
        /// 原文件路径选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                selectedPathTextBox.Text = folderBrowser.SelectedPath;
            }
        }
        /// <summary>
        /// 保存路径选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TargetButton_Click(object sender, EventArgs e)
        {
            if (targetFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                targetPathTextBox.Text = targetFolderBrowser.SelectedPath;
            }
        }
        /// <summary>
        /// 开始解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            //判断是否已经选择原文件路径
            if (string.IsNullOrEmpty(selectedPathTextBox.Text))
            {
                MessageBox.Show("请先选择原文件路径,再进行解密操作！");
                return;
            }
            //判断是否已经选择文件保存路径
            if (string.IsNullOrEmpty(targetPathTextBox.Text))
            {
                MessageBox.Show("请先选择保存路径,再进行解密操作！");
                return;
            }

            string sourceDirectoryPath = folderBrowser.SelectedPath;
            string targetDirectoryPath = targetFolderBrowser.SelectedPath;
            string[] files = Directory.GetFiles(sourceDirectoryPath, "*");
            progressBar1.Maximum = files.Length;
            int i = 0;
            foreach (string file in files)
            {
                i++;
                //目标文件路径+文件名+.ini
                string newFilePath = Path.ChangeExtension(Path.Combine(targetDirectoryPath, Path.GetFileName(file)), newExtension);
                //目标文件路径+文件名+原文件后缀
                string newFilePath2 = Path.Combine(targetDirectoryPath, Path.GetFileName(file));

                //判断保存路径下是否已经存在要解密的文件
                if (File.Exists(newFilePath) || File.Exists(newFilePath2))
                {
                    DialogResult result = MessageBox.Show("文件"+ Path.GetFileName(file) + "已存在，是否覆盖?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        //解密操作
                        Decode(file, targetDirectoryPath);

                    }
                    else
                    {
                        statusLabel.Text = "文件 " + Path.GetFileName(file) + " 未解密.";
                    }
                }
                else
                {
                    //解密操作
                    Decode(file, targetDirectoryPath);
                }
                progressBar1.Value = i;
            }
            MessageBox.Show("文件全部解密完成！");
        }
        /// <summary>
        /// 解密方法
        /// </summary>
        /// <param name="file">需要解密的原文件</param>
        /// <param name="targetDirectoryPath">解密后文件的保存位置</param>
        public void Decode(string file, string targetDirectoryPath)
        {
            //保存原文件的信息，用于还原原文件的后缀
            string originalFilePath = file;
            //目标文件路径+文件名+.ini
            string newFilePath = Path.ChangeExtension(Path.Combine(targetDirectoryPath, Path.GetFileName(file)), newExtension);
            //将原文件复制一份到保存路径下
            File.Copy(file, Path.Combine(targetDirectoryPath, Path.GetFileName(file)), true);

            //将保存路径下文件的后缀改为.ini
            try
            {
                File.Move(Path.Combine(targetDirectoryPath, Path.GetFileName(file)), newFilePath);
                statusLabel.Text = "文件 " + Path.GetFileName(file) + " 成功复制到" + targetDirectoryPath;
            }
            catch (Exception)
            {
                statusLabel.Text = Path.GetFileName(file) + " 被异常占用！";
                throw;
            }

            //延时1000ms
            Thread.Sleep(1000);

            //将文件后缀改回原来的
            try
            {
                File.Move(newFilePath, Path.Combine(targetDirectoryPath, Path.GetFileName(originalFilePath)));
                statusLabel.Text = "文件 " + Path.GetFileName(file) + " 成功解密!";
            }
            catch (Exception)
            {
                statusLabel.Text = Path.GetFileName(file) + " 解密失败！";
                throw;
            }
        }
    }
}
