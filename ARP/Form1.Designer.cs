namespace ARP
{
    partial class ARP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARP));
            this.chosenetcard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNetCard = new System.Windows.Forms.ComboBox();
            this.txtMACto = new System.Windows.Forms.TextBox();
            this.txtIPto = new System.Windows.Forms.TextBox();
            this.txtMACfrom = new System.Windows.Forms.TextBox();
            this.txtIPfrom = new System.Windows.Forms.TextBox();
            this.grpbMssKind = new System.Windows.Forms.GroupBox();
            this.rdobRP = new System.Windows.Forms.RadioButton();
            this.rdobRQ = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHunter = new System.Windows.Forms.Button();
            this.grpbMssKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // chosenetcard
            // 
            this.chosenetcard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chosenetcard.AutoSize = true;
            this.chosenetcard.Location = new System.Drawing.Point(58, 42);
            this.chosenetcard.Name = "chosenetcard";
            this.chosenetcard.Size = new System.Drawing.Size(67, 15);
            this.chosenetcard.TabIndex = 0;
            this.chosenetcard.Text = "选择网卡";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "源MAC地址";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "目的IP地址";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "目的MAC地址";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "源IP地址";
            // 
            // cmbNetCard
            // 
            this.cmbNetCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNetCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetCard.FormattingEnabled = true;
            this.cmbNetCard.Location = new System.Drawing.Point(189, 39);
            this.cmbNetCard.Name = "cmbNetCard";
            this.cmbNetCard.Size = new System.Drawing.Size(959, 23);
            this.cmbNetCard.TabIndex = 5;
            this.cmbNetCard.SelectedIndexChanged += new System.EventHandler(this.cmbNetCard_SelectedIndexChanged);
            // 
            // txtMACto
            // 
            this.txtMACto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMACto.Location = new System.Drawing.Point(189, 111);
            this.txtMACto.Name = "txtMACto";
            this.txtMACto.Size = new System.Drawing.Size(316, 25);
            this.txtMACto.TabIndex = 6;
            this.txtMACto.Text = "20-30-40-10-FF-12";
            this.txtMACto.TextChanged += new System.EventHandler(this.txtMACto_TextChanged);
            // 
            // txtIPto
            // 
            this.txtIPto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPto.Location = new System.Drawing.Point(189, 182);
            this.txtIPto.Name = "txtIPto";
            this.txtIPto.Size = new System.Drawing.Size(316, 25);
            this.txtIPto.TabIndex = 7;
            this.txtIPto.Text = "192.168.2.1";
            // 
            // txtMACfrom
            // 
            this.txtMACfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMACfrom.Location = new System.Drawing.Point(189, 259);
            this.txtMACfrom.Name = "txtMACfrom";
            this.txtMACfrom.Size = new System.Drawing.Size(316, 25);
            this.txtMACfrom.TabIndex = 8;
            this.txtMACfrom.Text = "20-30-40-10-FF-15";
            // 
            // txtIPfrom
            // 
            this.txtIPfrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPfrom.Location = new System.Drawing.Point(189, 338);
            this.txtIPfrom.Name = "txtIPfrom";
            this.txtIPfrom.Size = new System.Drawing.Size(316, 25);
            this.txtIPfrom.TabIndex = 9;
            this.txtIPfrom.Text = "192.168.4.3";
            // 
            // grpbMssKind
            // 
            this.grpbMssKind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbMssKind.Controls.Add(this.rdobRP);
            this.grpbMssKind.Controls.Add(this.rdobRQ);
            this.grpbMssKind.Location = new System.Drawing.Point(61, 412);
            this.grpbMssKind.Name = "grpbMssKind";
            this.grpbMssKind.Size = new System.Drawing.Size(444, 63);
            this.grpbMssKind.TabIndex = 10;
            this.grpbMssKind.TabStop = false;
            this.grpbMssKind.Text = "报文类型";
            // 
            // rdobRP
            // 
            this.rdobRP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdobRP.AutoSize = true;
            this.rdobRP.Location = new System.Drawing.Point(281, 24);
            this.rdobRP.Name = "rdobRP";
            this.rdobRP.Size = new System.Drawing.Size(88, 19);
            this.rdobRP.TabIndex = 1;
            this.rdobRP.Text = "响应报文";
            this.rdobRP.UseVisualStyleBackColor = true;
            this.rdobRP.CheckedChanged += new System.EventHandler(this.rdobRP_CheckedChanged);
            // 
            // rdobRQ
            // 
            this.rdobRQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdobRQ.AutoSize = true;
            this.rdobRQ.Checked = true;
            this.rdobRQ.Location = new System.Drawing.Point(82, 24);
            this.rdobRQ.Name = "rdobRQ";
            this.rdobRQ.Size = new System.Drawing.Size(88, 19);
            this.rdobRQ.TabIndex = 0;
            this.rdobRQ.TabStop = true;
            this.rdobRQ.Text = "请求报文";
            this.rdobRQ.UseVisualStyleBackColor = true;
            this.rdobRQ.CheckedChanged += new System.EventHandler(this.rdobRQ_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(636, 430);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 25);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1008, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(556, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(591, 288);
            this.textBox1.TabIndex = 13;
            // 
            // btnHunter
            // 
            this.btnHunter.Location = new System.Drawing.Point(-1, -2);
            this.btnHunter.Name = "btnHunter";
            this.btnHunter.Size = new System.Drawing.Size(90, 26);
            this.btnHunter.TabIndex = 14;
            this.btnHunter.Text = "ARPHunter";
            this.btnHunter.UseVisualStyleBackColor = true;
            this.btnHunter.Click += new System.EventHandler(this.btnHunter_Click);
            // 
            // ARP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 514);
            this.Controls.Add(this.btnHunter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpbMssKind);
            this.Controls.Add(this.txtIPfrom);
            this.Controls.Add(this.txtMACfrom);
            this.Controls.Add(this.txtIPto);
            this.Controls.Add(this.txtMACto);
            this.Controls.Add(this.cmbNetCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chosenetcard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ARP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ARPSender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ARP_FormClosed);
            this.Load += new System.EventHandler(this.ARP_Load);
            this.grpbMssKind.ResumeLayout(false);
            this.grpbMssKind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chosenetcard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNetCard;
        private System.Windows.Forms.TextBox txtMACto;
        private System.Windows.Forms.TextBox txtIPto;
        private System.Windows.Forms.TextBox txtMACfrom;
        private System.Windows.Forms.TextBox txtIPfrom;
        private System.Windows.Forms.GroupBox grpbMssKind;
        private System.Windows.Forms.RadioButton rdobRP;
        private System.Windows.Forms.RadioButton rdobRQ;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHunter;
    }
}

