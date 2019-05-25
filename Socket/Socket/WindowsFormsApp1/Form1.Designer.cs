namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.classText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btn_Closeconnect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "班级";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "年龄";
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(222, 56);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(100, 21);
            this.textIP.TabIndex = 5;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(222, 104);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(100, 21);
            this.textPort.TabIndex = 6;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(222, 211);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(100, 21);
            this.userText.TabIndex = 7;
            // 
            // classText
            // 
            this.classText.Location = new System.Drawing.Point(222, 258);
            this.classText.Name = "classText";
            this.classText.Size = new System.Drawing.Size(100, 21);
            this.classText.TabIndex = 8;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(222, 310);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(100, 21);
            this.ageText.TabIndex = 9;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(107, 148);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(100, 23);
            this.connect.TabIndex = 10;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(107, 406);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(100, 23);
            this.send.TabIndex = 11;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(222, 406);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 23);
            this.submit.TabIndex = 12;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(468, 248);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(304, 181);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(468, 53);
            this.textInfo.Multiline = true;
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(304, 179);
            this.textInfo.TabIndex = 14;
            this.textInfo.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(157, 353);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(165, 21);
            this.txtMsg.TabIndex = 15;
            // 
            // btn_Closeconnect
            // 
            this.btn_Closeconnect.Location = new System.Drawing.Point(222, 148);
            this.btn_Closeconnect.Name = "btn_Closeconnect";
            this.btn_Closeconnect.Size = new System.Drawing.Size(100, 23);
            this.btn_Closeconnect.TabIndex = 16;
            this.btn_Closeconnect.Text = "closeconnect";
            this.btn_Closeconnect.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "消息";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Closeconnect);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.send);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.classText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox classText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btn_Closeconnect;
        private System.Windows.Forms.Label label6;
    }
}

