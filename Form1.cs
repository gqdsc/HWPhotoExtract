using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWPhotoExtract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrw_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
           
            //folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog.SelectedPath;
                txtPath.Text = folderPath;
            }


            
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            string foldername = txtPath .Text ;
            txtLog.Text = "";
            txtLog.AppendText("准备从以下目录提取转换图片到MP4：" + foldername+"\r\n");
            foreach (string file in Directory.GetFiles(foldername, "*.jpg", SearchOption.AllDirectories))
            {
                txtLog.AppendText("正在提取以下图片到MP4：" + file + "\r\n");
                Extract(file, true);
            }
            txtLog.AppendText("所有图片已经转换提取完毕！" );
        }
        //从动态图片提取图片和mp4视频
        private void Extract(string filename, bool extractImage)
        {
            using (FileStream binaryFile = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                string name = Path.GetFileNameWithoutExtension(filename);
                string ext = Path.GetExtension(filename);

                long numBytes = binaryFile.Length;

                bool jpgFound = false;
                for (long i = 0; i < numBytes; i++)
                {
                    binaryFile.Seek(i, SeekOrigin.Begin);

                    if (extractImage && !jpgFound)
                    {
                        byte[] jpgEndBytes = new byte[4];
                        binaryFile.Read(jpgEndBytes, 0, 4);
                        if (jpgEndBytes[0] == 0xFF && jpgEndBytes[1] == 0xD9 && jpgEndBytes[2] == 0x00 && jpgEndBytes[3] == 0x00) // JPG end
                        {
                            binaryFile.Seek(0, SeekOrigin.Begin);
                            byte[] jpgData = new byte[i + 4];
                            binaryFile.Read(jpgData, 0, (int)(i + 4));
                            using (FileStream outfile = new FileStream(string.Format("{0}_i.jpg", name), FileMode.Create, FileAccess.Write))
                            {
                                outfile.Write(jpgData, 0, jpgData.Length);
                                txtLog.AppendText("以下图片提取成功：" + name + "_i.jpg\r\n");
                            }
                            jpgFound = true;
                        }
                    }
                    else
                    {
                        byte[] mp4StartBytes = new byte[16];
                        binaryFile.Read(mp4StartBytes, 0, 16);
                        if (mp4StartBytes[0] == 0x00 && mp4StartBytes[1] == 0x00 && mp4StartBytes[2] == 0x00 && mp4StartBytes[3] == 0x18 &&
                            mp4StartBytes[4] == 0x66 && mp4StartBytes[5] == 0x74 && mp4StartBytes[6] == 0x79 && mp4StartBytes[7] == 0x70 &&
                            mp4StartBytes[8] == 0x6D && mp4StartBytes[9] == 0x70 && mp4StartBytes[10] == 0x34 && mp4StartBytes[11] == 0x32 &&
                            mp4StartBytes[12] == 0x00 && mp4StartBytes[13] == 0x00 && mp4StartBytes[14] == 0x00 && mp4StartBytes[15] == 0x00) // MP4 Start
                        {
                            binaryFile.Seek(i, SeekOrigin.Begin);
                            byte[] mp4Data = new byte[numBytes - i];
                            binaryFile.Read(mp4Data, 0, (int)(numBytes - i));
                            using (FileStream outfile = new FileStream(string.Format("{0}.mp4", name), FileMode.Create, FileAccess.Write))
                            {
                                outfile.Write(mp4Data, 0, mp4Data.Length);
                            }
                            txtLog.AppendText("以下视频提取成功：" + name + ".mp4\r\n");
                            break;
                        }
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtPath.Text);
        }
    }
}
