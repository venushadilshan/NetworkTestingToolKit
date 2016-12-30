using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Network_Testing_ToolKit
{
    public partial class Form1 : Form
    {
        string ipping = "";
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorkerforpinger.RunWorkerAsync();
            progressBar1.Visible = true;
        }

        private void rdbtndefualt_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            ipping = "192.168.1.1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (rdbtndefualt.Checked==true && rdbtncustom.Checked==false)
           {
               textBox1.Enabled =false;
               ipping = "192.168.1.1";
           }
           if (rdbtndefualt.Checked == false && rdbtncustom.Checked == true)
           {
               textBox1.Enabled = true;
               ipping = textBox1.Text;
           }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
        string q = "";
        private void backgroundWorkerforpinger_DoWork(object sender, DoWorkEventArgs e)
        {
            
            MessageBox.Show("Sending data to " + ipping + ". Please wait!");
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C ping " + ipping;
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
           process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();

            while (!process.HasExited)
            {
                // progressBar1.Value = 20;
                q += process.StandardOutput.ReadToEnd();
            }
            //richTextBox1.Text = q;
            MessageBox.Show("Completed. Click the Result, to view");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            richTextBox1.Text = q;

        }
        string cm = "";
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (rdbtnsmpdet.Checked == true && rdbtnaldet.Checked == false)
            {
                cm = "ipconfig";
            }
            if (rdbtnsmpdet.Checked==false && rdbtnaldet.Checked == true)
            {
                cm = "ipconfig/all";
            }
        }
        string g="";
        private void button3_Click(object sender, EventArgs e)
        {

           // MessageBox.Show("Sending data to " + ipping + ". Please wait!");
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Verb = "runas";
            process.StartInfo.Arguments = "/C "+cm;

            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();

            while (!process.HasExited)
            {
                // progressBar1.Value = 20;
                g += process.StandardOutput.ReadToEnd();
            }
           
            MessageBox.Show("Completed. Click the Result, to view");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = g;
        }
        string wi = "";
        private void button5_Click(object sender, EventArgs e)
        {
            string key = textBoxssid.Text;
            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "cmd.exe";
          //  process.StartInfo.FileName = "runas.exe";
            process.StartInfo.Verb = "runas";
            process.StartInfo.Arguments = "/C netsh wlan show profile name="+key+" key=clear | findstr Key";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();

            while (!process.HasExited)
            {
                // progressBar1.Value = 20;
                wi += process.StandardOutput.ReadToEnd();
                richTextBoxwifi.Text = wi;
            }
            groupBox4.Text = "Wi-fi Key for " + key;
            //MessageBox.Show("Completed. Click the Result, to view");
           
        }
        }
    }

