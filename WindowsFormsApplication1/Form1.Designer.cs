namespace DecodeHelperApplication1
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
            this.selectButton = new System.Windows.Forms.Button();
            this.targetButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.selectedPathTextBox = new System.Windows.Forms.TextBox();
            this.targetPathTextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(17, 44);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(95, 23);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "原文件路径";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(17, 99);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(95, 23);
            this.targetButton.TabIndex = 1;
            this.targetButton.Text = "保存路径";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.TargetButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(161, 150);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(111, 33);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "开始解密";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(15, 195);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(428, 23);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selectedPathTextBox
            // 
            this.selectedPathTextBox.Location = new System.Drawing.Point(118, 45);
            this.selectedPathTextBox.Name = "selectedPathTextBox";
            this.selectedPathTextBox.Size = new System.Drawing.Size(329, 21);
            this.selectedPathTextBox.TabIndex = 4;
            // 
            // targetPathTextBox
            // 
            this.targetPathTextBox.Location = new System.Drawing.Point(118, 100);
            this.targetPathTextBox.Name = "targetPathTextBox";
            this.targetPathTextBox.Size = new System.Drawing.Size(329, 21);
            this.targetPathTextBox.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 221);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(428, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 254);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.targetPathTextBox);
            this.Controls.Add(this.selectedPathTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.selectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "解密助手";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button targetButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox selectedPathTextBox;
        private System.Windows.Forms.TextBox targetPathTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

