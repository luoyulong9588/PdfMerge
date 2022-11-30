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
using Spire.Pdf;
using Spire.Pdf.Graphics;


namespace PdfMerge
{
    public partial class Form1 : Form
    {
        string filePath1;
        string filePath2;
        string savePath;
        string appPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        Random random = new Random();   

        public Form1()
        {
            InitializeComponent();
            updateSavePath();
            createFolder();

        }
        private void updateSavePath()
        {
            savePath = $"data\\mergePDF_{random.Next(1, 10000)}.pdf";
        }
        private void textBoxFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxFile_DragDrop(object sender, DragEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            txtBox.Text = path;
        }

        [Obsolete]
        private void btnMerge_Click(object sender, EventArgs e)
        {
            updateSavePath();
            if (tabControlDesktop.SelectedIndex == 0) // 1/2 page
            {
                string filePath1 = textBoxFile1.Text;
                string filePath2 = textBoxFile2.Text;

                if (checkFileType(filePath1) && checkFileType(filePath2))
                {
                    var doc = PdfDocument.MergeFiles(filePath1, filePath2);
                    doc.Save(savePath, FileFormat.PDF);
                    MessageBox.Show("success!");
                }
                else
                {

                }
            }
            else // normal

            {
                MessageBox.Show("Multi files merge");
                var files = Directory.GetFiles(textBoxPath.Text, "*.pdf");
                List<string> filesList = new List<string>();
                foreach (var item in files)
                {
                    filesList.Append(item);
                }
                var doc = PdfDocument.MergeFiles(filesList.ToArray());
                doc.Save(savePath, FileFormat.PDF);
                MessageBox.Show("success!");
            }
            this.labelMergeFile.Text = savePath;
        }

        private bool checkFileType(string path)
        {
            try
            {
                string[] list = path.Split('.');
                string fileType = list.Last().ToUpper();
                if (fileType == "PDF")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show($"you've choosed '.{fileType}' as  '.PDF' file,please check again!", "file type error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("application can't get file type,make sure the file is right.", "read file error!");
            }
            return false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PdfDocument pdf = new PdfDocument();
            try
            {
                pdf.LoadFromFile(savePath);
                pdf.PrintSettings.SelectMultiPageLayout(2, 1);
                pdf.Print();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("please merge file first!","error");
            }
            
        }

        private void btnFile1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Adobe PDF Files|*.PDF" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxFile1.Text = openFileDialog.FileName;
                    
                }
            }
        }

        private void btnFile2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Adobe PDF Files|*.PDF" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.textBoxFile2.Text = openFileDialog.FileName;
                    
                }
            }
        }

        private string getFileName(string path)
        {
            string[] strings = path.Split('\\');
            return strings.Last();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", appPath);
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.Description = "选择文件所在文件夹目录";  //提示的文字
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folder.SelectedPath.ToString();
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            int length = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).Length;
            if (length == 2 && this.tabControlDesktop.SelectedIndex==0) // limit 2 pdf
            {
                this.textBoxFile1.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                this.textBoxFile2.Text = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(1).ToString();
            }
        }

        private void createFolder()
        {
            if (!System.IO.Directory.Exists($"{appPath}\\data"))
            {
                System.IO.Directory.CreateDirectory($"{appPath}\\data");//不存在就创建文件夹
            }
        }

        private void textBoxFile1_TextChanged(object sender, EventArgs e)
        {
            labelFilename1.Text = getFileName(this.textBoxFile1.Text);
            
        }

        private void textBoxFile2_TextChanged(object sender, EventArgs e)
        {
            labelFilename2.Text = getFileName(this.textBoxFile2.Text);
        }

        private void labelMergeFile_Click(object sender, EventArgs e)
        {
            if (labelMergeFile.Text.Length>1)
            {
                System.Diagnostics.Process.Start($"{appPath}\\{labelMergeFile.Text}");
            }
        }
    }
}
