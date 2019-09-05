using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace TechnoDevs_Tool
{
    public partial class dosyacek : Form
    {
        public dosyacek()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dosyacek_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "pull " + dosyacekTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                console.Clear();
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls";
                checkBox1.BackColor = Color.Red;
                console.Clear();
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
                if (checkBox1.Checked == true)
                    label3.Text = "Root Erişimi Alındı";
                label3.BackColor = Color.Cyan;

                if (console.Text == "")
                {
                    checkBox1.BackColor = Color.Navy;
                    console.Text = "Root Erişimi Alınamadı";
                    label3.Text = "Root Erişimi Yok";
                }
            }
            {
                if (console.Text == "")
                {
                    console.Text = "Root Erişimi Alınamadı";
                    label3.Text = "Root Erişimi Yok";
                }
                if (console.Text == "Root Erişimi Alınamadı")
                {
                    console.Clear();
                    console.Text = "Root Erişimi Alınamadı";
                    label3.Text = "Root Erişimi Yok";
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " push " + dosyayukleTextBox.Text + dosyakonumuTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Dosya'yı Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                dosyayukleTextBox.Text = openfile.FileName;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*KONSOL TEMİZLEME KOMUTU*/
            console.Clear();
            /*KONSOL TEMİZLEME KOMUTU*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            process.EnableRaisingEvents = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "devices";
            process.StartInfo = startInfo;
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
        
        }
    }
}
/* List of devices attached


*/