namespace SecretKey
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_mac = new System.Windows.Forms.TextBox();
            this.tb_hash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_xlh = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_mac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_mac
            // 
            this.tb_mac.Location = new System.Drawing.Point(109, 58);
            this.tb_mac.Multiline = true;
            this.tb_mac.Name = "tb_mac";
            this.tb_mac.Size = new System.Drawing.Size(315, 118);
            this.tb_mac.TabIndex = 1;
            // 
            // tb_hash
            // 
            this.tb_hash.Location = new System.Drawing.Point(109, 20);
            this.tb_hash.Name = "tb_hash";
            this.tb_hash.Size = new System.Drawing.Size(315, 21);
            this.tb_hash.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "MAC地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "HASH：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "序列号：";
            // 
            // tb_xlh
            // 
            this.tb_xlh.Location = new System.Drawing.Point(109, 192);
            this.tb_xlh.Multiline = true;
            this.tb_xlh.Name = "tb_xlh";
            this.tb_xlh.Size = new System.Drawing.Size(315, 117);
            this.tb_xlh.TabIndex = 3;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(118, 327);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(107, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "生成";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_mac
            // 
            this.btn_mac.Location = new System.Drawing.Point(290, 327);
            this.btn_mac.Name = "btn_mac";
            this.btn_mac.Size = new System.Drawing.Size(107, 23);
            this.btn_mac.TabIndex = 8;
            this.btn_mac.Text = "重新获取MAC地址";
            this.btn_mac.UseVisualStyleBackColor = true;
            this.btn_mac.Click += new System.EventHandler(this.btn_mac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 434);
            this.Controls.Add(this.btn_mac);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_xlh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_hash);
            this.Controls.Add(this.tb_mac);
            this.Name = "Form1";
            this.Text = "密钥生成器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_mac;
        private System.Windows.Forms.TextBox tb_hash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_xlh;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_mac;
    }
}

