using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoDevs_Tool
{
    public partial class adbsideload : Form
    {
        public adbsideload()
        {
            InitializeComponent();
        }

        private void adbsideload_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Deneme 1");
            comboBox1.Items.Add("Deneme 2");
            comboBox1.Items.Add("Deneme 3");
            comboBox1.Items.Add("Deneme 4");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " devices";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "APK Dosyası|*.APK";
            openfile.Title = ".APK Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                adbyukleTextBox.Text = openfile.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " install " + adbyukleTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void console_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("TWRP'de Gelişmiş > ADB SideLoad Etkinleştirin.");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "desenkilidikir.bat";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "ZIP Dosyası|*.ZIP";
                openfile.Title = ".ZIP Seçiniz..";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    zipyukleTextBox.Text = openfile.FileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " sideload " + zipyukleTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell su -c"+" dd if=" + partyukleTextBox.Text + " " + "of=/sdcard/yedekalindi.img bs=4096";
            process.StartInfo = startInfo;
            process.Start();
            MessageBox.Show("Partition bilgilerini doğru girdiyseniz 'yedekalindi.img' dosyası cihaz hafızasında olacaktır");
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            console.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " devices";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls /dev/block";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }

            if (comboBox1.SelectedIndex == 1) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell cat /proc/partitions";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 2) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell ls /dev/block/platforms";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 3) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls -l /dev/block/bootdevice";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " reboot recovery";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " reboot";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls /dev/block";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }

            if (comboBox1.SelectedIndex == 1) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell cat /proc/partitions";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 2) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell ls /dev/block/platforms";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 3) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls -l /dev/block/bootdevice";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }
    }
}