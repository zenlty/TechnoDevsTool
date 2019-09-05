using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace TechnoDevs_Tool
{
    public partial class adbfastboot : Form
    {
        public adbfastboot()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            startInfo.Arguments = adbconsoleTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            AdbConsole.Text = AdbConsole.Text + process.StandardOutput.ReadToEnd();
        }

        private void adbconsoleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cihazın Fastboot Mod'a Alındığından Emin Olun.", "Uyarı !");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = fastbootconsoleTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            FastbootConsole.Text = FastbootConsole.Text + process.StandardOutput.ReadToEnd();
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
            startInfo.Arguments = " reboot bootloader";
            process.StartInfo = startInfo;
            process.Start();
            AdbConsole.Text = AdbConsole.Text + process.StandardOutput.ReadToEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Cihazın Fastboot Mod'a Alındığından Emin Olun.", "Uyarı !");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " reboot";
            process.StartInfo = startInfo;
            process.Start();
            FastbootConsole.Text = FastbootConsole.Text + process.StandardOutput.ReadToEnd();
        }

        private void adbfastboot_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FastbootConsole.Clear();
            AdbConsole.Clear();
        }
    }
}
