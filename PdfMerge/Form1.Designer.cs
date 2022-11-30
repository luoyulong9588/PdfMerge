namespace PdfMerge
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanelDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.labelFile1 = new System.Windows.Forms.Label();
            this.textBoxFile1 = new System.Windows.Forms.TextBox();
            this.btnFile1 = new System.Windows.Forms.Button();
            this.labelFile2 = new System.Windows.Forms.Label();
            this.textBoxFile2 = new System.Windows.Forms.TextBox();
            this.btnFile2 = new System.Windows.Forms.Button();
            this.labelFilename1 = new System.Windows.Forms.Label();
            this.labelFilename2 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.tabControlDesktop = new System.Windows.Forms.TabControl();
            this.tabPageHalf = new System.Windows.Forms.TabPage();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMergeFileName = new System.Windows.Forms.Label();
            this.labelMergeFile = new System.Windows.Forms.Label();
            this.tableLayoutPanelDesktop.SuspendLayout();
            this.tabControlDesktop.SuspendLayout();
            this.tabPageHalf.SuspendLayout();
            this.tabPageNormal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDesktop
            // 
            this.tableLayoutPanelDesktop.ColumnCount = 3;
            this.tableLayoutPanelDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.67348F));
            this.tableLayoutPanelDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.30247F));
            this.tableLayoutPanelDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.02405F));
            this.tableLayoutPanelDesktop.Controls.Add(this.labelFile1, 0, 0);
            this.tableLayoutPanelDesktop.Controls.Add(this.textBoxFile1, 1, 0);
            this.tableLayoutPanelDesktop.Controls.Add(this.btnFile1, 2, 0);
            this.tableLayoutPanelDesktop.Controls.Add(this.labelFile2, 0, 2);
            this.tableLayoutPanelDesktop.Controls.Add(this.textBoxFile2, 1, 2);
            this.tableLayoutPanelDesktop.Controls.Add(this.btnFile2, 2, 2);
            this.tableLayoutPanelDesktop.Controls.Add(this.labelFilename1, 1, 1);
            this.tableLayoutPanelDesktop.Controls.Add(this.labelFilename2, 1, 3);
            this.tableLayoutPanelDesktop.Location = new System.Drawing.Point(68, 42);
            this.tableLayoutPanelDesktop.Name = "tableLayoutPanelDesktop";
            this.tableLayoutPanelDesktop.RowCount = 4;
            this.tableLayoutPanelDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDesktop.Size = new System.Drawing.Size(666, 201);
            this.tableLayoutPanelDesktop.TabIndex = 0;
            // 
            // labelFile1
            // 
            this.labelFile1.AutoSize = true;
            this.labelFile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFile1.Font = new System.Drawing.Font("宋体", 10F);
            this.labelFile1.Location = new System.Drawing.Point(3, 0);
            this.labelFile1.Name = "labelFile1";
            this.labelFile1.Size = new System.Drawing.Size(65, 60);
            this.labelFile1.TabIndex = 0;
            this.labelFile1.Text = "file1:";
            this.labelFile1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFile1
            // 
            this.textBoxFile1.AllowDrop = true;
            this.textBoxFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFile1.Font = new System.Drawing.Font("宋体", 10F);
            this.textBoxFile1.Location = new System.Drawing.Point(74, 16);
            this.textBoxFile1.Name = "textBoxFile1";
            this.textBoxFile1.ReadOnly = true;
            this.textBoxFile1.Size = new System.Drawing.Size(455, 27);
            this.textBoxFile1.TabIndex = 2;
            this.textBoxFile1.TextChanged += new System.EventHandler(this.textBoxFile1_TextChanged);
            this.textBoxFile1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFile_DragDrop);
            this.textBoxFile1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFile_DragEnter);
            // 
            // btnFile1
            // 
            this.btnFile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile1.Font = new System.Drawing.Font("宋体", 10F);
            this.btnFile1.Location = new System.Drawing.Point(535, 14);
            this.btnFile1.Name = "btnFile1";
            this.btnFile1.Size = new System.Drawing.Size(128, 32);
            this.btnFile1.TabIndex = 4;
            this.btnFile1.Text = "Browse..";
            this.btnFile1.UseVisualStyleBackColor = true;
            this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
            // 
            // labelFile2
            // 
            this.labelFile2.AutoSize = true;
            this.labelFile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFile2.Font = new System.Drawing.Font("宋体", 10F);
            this.labelFile2.Location = new System.Drawing.Point(3, 100);
            this.labelFile2.Name = "labelFile2";
            this.labelFile2.Size = new System.Drawing.Size(65, 60);
            this.labelFile2.TabIndex = 1;
            this.labelFile2.Text = "file2:";
            this.labelFile2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxFile2
            // 
            this.textBoxFile2.AllowDrop = true;
            this.textBoxFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFile2.Font = new System.Drawing.Font("宋体", 10F);
            this.textBoxFile2.Location = new System.Drawing.Point(74, 116);
            this.textBoxFile2.Name = "textBoxFile2";
            this.textBoxFile2.ReadOnly = true;
            this.textBoxFile2.Size = new System.Drawing.Size(455, 27);
            this.textBoxFile2.TabIndex = 3;
            this.textBoxFile2.TextChanged += new System.EventHandler(this.textBoxFile2_TextChanged);
            this.textBoxFile2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFile_DragDrop);
            this.textBoxFile2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFile_DragEnter);
            // 
            // btnFile2
            // 
            this.btnFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile2.Font = new System.Drawing.Font("宋体", 10F);
            this.btnFile2.Location = new System.Drawing.Point(535, 114);
            this.btnFile2.Name = "btnFile2";
            this.btnFile2.Size = new System.Drawing.Size(128, 32);
            this.btnFile2.TabIndex = 5;
            this.btnFile2.Text = "Browse..";
            this.btnFile2.UseVisualStyleBackColor = true;
            this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
            // 
            // labelFilename1
            // 
            this.labelFilename1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilename1.AutoSize = true;
            this.labelFilename1.Font = new System.Drawing.Font("宋体", 10F);
            this.labelFilename1.Location = new System.Drawing.Point(74, 71);
            this.labelFilename1.Name = "labelFilename1";
            this.labelFilename1.Size = new System.Drawing.Size(455, 17);
            this.labelFilename1.TabIndex = 6;
            this.labelFilename1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFilename2
            // 
            this.labelFilename2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilename2.AutoSize = true;
            this.labelFilename2.Font = new System.Drawing.Font("宋体", 10F);
            this.labelFilename2.Location = new System.Drawing.Point(74, 172);
            this.labelFilename2.Name = "labelFilename2";
            this.labelFilename2.Size = new System.Drawing.Size(455, 17);
            this.labelFilename2.TabIndex = 7;
            this.labelFilename2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMerge.Location = new System.Drawing.Point(167, 394);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(97, 34);
            this.btnMerge.TabIndex = 1;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrint.Location = new System.Drawing.Point(378, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 34);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpenFolder.Location = new System.Drawing.Point(587, 394);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(97, 34);
            this.btnOpenFolder.TabIndex = 3;
            this.btnOpenFolder.Text = "Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // tabControlDesktop
            // 
            this.tabControlDesktop.Controls.Add(this.tabPageHalf);
            this.tabControlDesktop.Controls.Add(this.tabPageNormal);
            this.tabControlDesktop.Location = new System.Drawing.Point(21, 23);
            this.tabControlDesktop.Name = "tabControlDesktop";
            this.tabControlDesktop.SelectedIndex = 0;
            this.tabControlDesktop.Size = new System.Drawing.Size(807, 298);
            this.tabControlDesktop.TabIndex = 5;
            // 
            // tabPageHalf
            // 
            this.tabPageHalf.Controls.Add(this.tableLayoutPanelDesktop);
            this.tabPageHalf.Location = new System.Drawing.Point(4, 25);
            this.tabPageHalf.Name = "tabPageHalf";
            this.tabPageHalf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHalf.Size = new System.Drawing.Size(799, 269);
            this.tabPageHalf.TabIndex = 0;
            this.tabPageHalf.Text = "1/2 Page";
            this.tabPageHalf.UseVisualStyleBackColor = true;
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Controls.Add(this.tableLayoutPanel1);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 25);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(799, 269);
            this.tabPageNormal.TabIndex = 1;
            this.tabPageNormal.Text = "Normal";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.06358F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.93642F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.Controls.Add(this.labelPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPath, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPath, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(713, 62);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPath
            // 
            this.labelPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("宋体", 10F);
            this.labelPath.Location = new System.Drawing.Point(3, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(98, 17);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "path:";
            this.labelPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPath
            // 
            this.btnPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPath.Font = new System.Drawing.Font("宋体", 10F);
            this.btnPath.Location = new System.Drawing.Point(581, 15);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(129, 32);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Browse..";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPath.Font = new System.Drawing.Font("宋体", 10F);
            this.textBoxPath.Location = new System.Drawing.Point(107, 17);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(468, 27);
            this.textBoxPath.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.27027F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.72973F));
            this.tableLayoutPanel2.Controls.Add(this.labelMergeFileName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelMergeFile, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(93, 327);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(666, 40);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // labelMergeFileName
            // 
            this.labelMergeFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMergeFileName.AutoSize = true;
            this.labelMergeFileName.Location = new System.Drawing.Point(3, 12);
            this.labelMergeFileName.Name = "labelMergeFileName";
            this.labelMergeFileName.Size = new System.Drawing.Size(128, 15);
            this.labelMergeFileName.TabIndex = 0;
            this.labelMergeFileName.Text = "MergeFileName:";
            this.labelMergeFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMergeFile
            // 
            this.labelMergeFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMergeFile.AutoSize = true;
            this.labelMergeFile.Font = new System.Drawing.Font("宋体", 10F);
            this.labelMergeFile.Location = new System.Drawing.Point(137, 11);
            this.labelMergeFile.Name = "labelMergeFile";
            this.labelMergeFile.Size = new System.Drawing.Size(526, 17);
            this.labelMergeFile.TabIndex = 1;
            this.labelMergeFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMergeFile.Click += new System.EventHandler(this.labelMergeFile_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(853, 455);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tabControlDesktop);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFMerge - Design by luoyulong";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFile_DragEnter);
            this.tableLayoutPanelDesktop.ResumeLayout(false);
            this.tableLayoutPanelDesktop.PerformLayout();
            this.tabControlDesktop.ResumeLayout(false);
            this.tabPageHalf.ResumeLayout(false);
            this.tabPageNormal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDesktop;
        private System.Windows.Forms.Label labelFile1;
        private System.Windows.Forms.Label labelFile2;
        private System.Windows.Forms.TextBox textBoxFile1;
        private System.Windows.Forms.TextBox textBoxFile2;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.TabControl tabControlDesktop;
        private System.Windows.Forms.TabPage tabPageHalf;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button btnFile2;
        private System.Windows.Forms.Button btnFile1;
        private System.Windows.Forms.Label labelFilename1;
        private System.Windows.Forms.Label labelFilename2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelMergeFileName;
        private System.Windows.Forms.Label labelMergeFile;
    }
}

