namespace HWPhotoExtract
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
            this.labPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnBrw = new System.Windows.Forms.Button();
            this.btnExt = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labPath
            // 
            this.labPath.AutoSize = true;
            this.labPath.Location = new System.Drawing.Point(24, 24);
            this.labPath.Name = "labPath";
            this.labPath.Size = new System.Drawing.Size(137, 12);
            this.labPath.TabIndex = 0;
            this.labPath.Text = "请选择要提取的图片路径";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(26, 39);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(555, 21);
            this.txtPath.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(26, 75);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(555, 255);
            this.txtLog.TabIndex = 2;
            // 
            // btnBrw
            // 
            this.btnBrw.Location = new System.Drawing.Point(596, 37);
            this.btnBrw.Name = "btnBrw";
            this.btnBrw.Size = new System.Drawing.Size(75, 23);
            this.btnBrw.TabIndex = 3;
            this.btnBrw.Text = "浏览(&B)";
            this.btnBrw.UseVisualStyleBackColor = true;
            this.btnBrw.Click += new System.EventHandler(this.btnBrw_Click);
            // 
            // btnExt
            // 
            this.btnExt.Location = new System.Drawing.Point(596, 266);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(75, 23);
            this.btnExt.TabIndex = 4;
            this.btnExt.Text = "提取(&E)";
            this.btnExt.UseVisualStyleBackColor = true;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(596, 295);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 35);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "打开转换\r\n文件夹(&P)";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 360);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnExt);
            this.Controls.Add(this.btnBrw);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.labPath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "华为手机动态图片提取";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnBrw;
        private System.Windows.Forms.Button btnExt;
        private System.Windows.Forms.Button btnOpen;
    }
}

