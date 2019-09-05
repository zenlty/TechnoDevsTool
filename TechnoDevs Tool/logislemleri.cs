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
    public partial class logislemleri : Form
    {
        public logislemleri()
        {
            InitializeComponent();
        }

        private void logislemleri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AÇILAN PENCEREDE LOG ALMA ISLEMI BASLAYACAKTIR. BELLI BIR SURE SONRA KAPATINIZ. LOG KONSOL ICINDE OLACAKTIR", "UYARI");

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " logcat > LogCat.txt";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AÇILAN PENCEREDE LOG ALMA ISLEMI BASLAYACAKTIR. BELLI BIR SURE SONRA KAPATINIZ. LOG KONSOL ICINDE OLACAKTIR", "UYARI");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell dmesg > dmesg.txt";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Console_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
