namespace Network_Testing_ToolKit
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbtncustom = new System.Windows.Forms.RadioButton();
            this.rdbtndefualt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerforpinger = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rdbtnaldet = new System.Windows.Forms.RadioButton();
            this.rdbtnsmpdet = new System.Windows.Forms.RadioButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxwifi = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxssid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.rdbtncustom);
            this.groupBox1.Controls.Add(this.rdbtndefualt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pinger";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 184);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(299, 16);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "View Result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(28, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(315, 169);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbtncustom
            // 
            this.rdbtncustom.AutoSize = true;
            this.rdbtncustom.Location = new System.Drawing.Point(76, 58);
            this.rdbtncustom.Name = "rdbtncustom";
            this.rdbtncustom.Size = new System.Drawing.Size(114, 17);
            this.rdbtncustom.TabIndex = 3;
            this.rdbtncustom.Text = "Custom IP/Domain";
            this.rdbtncustom.UseVisualStyleBackColor = true;
            // 
            // rdbtndefualt
            // 
            this.rdbtndefualt.AutoSize = true;
            this.rdbtndefualt.Checked = true;
            this.rdbtndefualt.Location = new System.Drawing.Point(76, 35);
            this.rdbtndefualt.Name = "rdbtndefualt";
            this.rdbtndefualt.Size = new System.Drawing.Size(104, 17);
            this.rdbtndefualt.TabIndex = 2;
            this.rdbtndefualt.TabStop = true;
            this.rdbtndefualt.Text = "Default Gateway";
            this.rdbtndefualt.UseVisualStyleBackColor = true;
            this.rdbtndefualt.CheckedChanged += new System.EventHandler(this.rdbtndefualt_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ping to-";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // backgroundWorkerforpinger
            // 
            this.backgroundWorkerforpinger.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerforpinger_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.rdbtnaldet);
            this.groupBox2.Controls.Add(this.rdbtnsmpdet);
            this.groupBox2.Location = new System.Drawing.Point(370, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Network and Adapter Details";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "View Result";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(6, 95);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(307, 280);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Run a Scan";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rdbtnaldet
            // 
            this.rdbtnaldet.AutoSize = true;
            this.rdbtnaldet.Location = new System.Drawing.Point(20, 58);
            this.rdbtnaldet.Name = "rdbtnaldet";
            this.rdbtnaldet.Size = new System.Drawing.Size(71, 17);
            this.rdbtnaldet.TabIndex = 1;
            this.rdbtnaldet.TabStop = true;
            this.rdbtnaldet.Text = "All Deatils";
            this.rdbtnaldet.UseVisualStyleBackColor = true;
            // 
            // rdbtnsmpdet
            // 
            this.rdbtnsmpdet.AutoSize = true;
            this.rdbtnsmpdet.Location = new System.Drawing.Point(20, 35);
            this.rdbtnsmpdet.Name = "rdbtnsmpdet";
            this.rdbtnsmpdet.Size = new System.Drawing.Size(91, 17);
            this.rdbtnsmpdet.TabIndex = 0;
            this.rdbtnsmpdet.TabStop = true;
            this.rdbtnsmpdet.Text = "Simple Details";
            this.rdbtnsmpdet.UseVisualStyleBackColor = true;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxssid);
            this.groupBox3.Location = new System.Drawing.Point(695, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 260);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saved Wi-Fi Passwords";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBoxwifi);
            this.groupBox4.Location = new System.Drawing.Point(11, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 125);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // richTextBoxwifi
            // 
            this.richTextBoxwifi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxwifi.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxwifi.Name = "richTextBoxwifi";
            this.richTextBoxwifi.ReadOnly = true;
            this.richTextBoxwifi.Size = new System.Drawing.Size(211, 100);
            this.richTextBoxwifi.TabIndex = 3;
            this.richTextBoxwifi.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 28);
            this.button5.TabIndex = 2;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "SSID -";
            // 
            // textBoxssid
            // 
            this.textBoxssid.Location = new System.Drawing.Point(50, 46);
            this.textBoxssid.Name = "textBoxssid";
            this.textBoxssid.Size = new System.Drawing.Size(161, 20);
            this.textBoxssid.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Developed By Venusha Dilshan \r\nwww.venuhsa.com\r\nvenusha125@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Testing ToolKit by Venuhsa Dilshan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbtncustom;
        private System.Windows.Forms.RadioButton rdbtndefualt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerforpinger;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rdbtnaldet;
        private System.Windows.Forms.RadioButton rdbtnsmpdet;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBoxwifi;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxssid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
    }
}

