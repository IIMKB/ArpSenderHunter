namespace ARP
{
    partial class ARPHunter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARPHunter));
            this.label1 = new System.Windows.Forms.Label();
            this.cbmNetCard = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lisvARP = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourceIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourceMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.desMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择网卡";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbmNetCard
            // 
            this.cbmNetCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmNetCard.FormattingEnabled = true;
            this.cbmNetCard.Location = new System.Drawing.Point(141, 34);
            this.cbmNetCard.Name = "cbmNetCard";
            this.cbmNetCard.Size = new System.Drawing.Size(911, 23);
            this.cbmNetCard.TabIndex = 1;
            this.cbmNetCard.SelectedIndexChanged += new System.EventHandler(this.cbmNetCard_SelectedIndexChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(40, 297);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetails.Size = new System.Drawing.Size(543, 184);
            this.txtDetails.TabIndex = 2;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(589, 297);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(464, 184);
            this.txtInfo.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1075, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 36);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1075, 191);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(132, 36);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1075, 298);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清除所有";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1075, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lisvARP
            // 
            this.lisvARP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.type,
            this.time,
            this.length,
            this.sourceIP,
            this.desIP,
            this.sourceMAC,
            this.desMAC});
            this.lisvARP.FullRowSelect = true;
            this.lisvARP.GridLines = true;
            this.lisvARP.Location = new System.Drawing.Point(40, 85);
            this.lisvARP.Name = "lisvARP";
            this.lisvARP.Size = new System.Drawing.Size(1012, 206);
            this.lisvARP.TabIndex = 9;
            this.lisvARP.UseCompatibleStateImageBehavior = false;
            this.lisvARP.View = System.Windows.Forms.View.Details;
            this.lisvARP.Click += new System.EventHandler(this.lisvARP_Click);
            this.lisvARP.DoubleClick += new System.EventHandler(this.lisvARP_DoubleClick);
            // 
            // number
            // 
            this.number.Text = "编号";
            this.number.Width = 46;
            // 
            // type
            // 
            this.type.Text = "协议类型";
            this.type.Width = 73;
            // 
            // time
            // 
            this.time.Text = "时间";
            this.time.Width = 133;
            // 
            // length
            // 
            this.length.Text = "长度（B）";
            this.length.Width = 81;
            // 
            // sourceIP
            // 
            this.sourceIP.Text = "源IP地址";
            this.sourceIP.Width = 100;
            // 
            // desIP
            // 
            this.desIP.Text = "目的IP地址";
            this.desIP.Width = 103;
            // 
            // sourceMAC
            // 
            this.sourceMAC.Text = "源MAC地址";
            this.sourceMAC.Width = 100;
            // 
            // desMAC
            // 
            this.desMAC.Text = "目的MAC地址";
            this.desMAC.Width = 114;
            // 
            // ARPHunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 514);
            this.Controls.Add(this.lisvARP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.cbmNetCard);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ARPHunter";
            this.Text = "ARPHunter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ARPHunter_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ARPHunter_FormClosed);
            this.Load += new System.EventHandler(this.ARPHunter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmNetCard;
        public System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lisvARP;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader length;
        private System.Windows.Forms.ColumnHeader sourceIP;
        private System.Windows.Forms.ColumnHeader desIP;
        private System.Windows.Forms.ColumnHeader sourceMAC;
        private System.Windows.Forms.ColumnHeader desMAC;
    }
}