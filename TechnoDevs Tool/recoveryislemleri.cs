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
    public partial class recoveryislemleri : Form
    {
        public recoveryislemleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Imaj Dosyası|*.img";
            openfile.Title = "Recovery.img Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                recoveryislemleriTextBox.Text = openfile.FileName;
            }
        }

        private void recoveryislemleri_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tek Seferlik Yükleme");
            comboBox1.Items.Add("Kalıcı Yükleme");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " boot " + recoveryislemleriTextBox.Text;
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }

            if (comboBox1.SelectedIndex == 1) //fastboot flash
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " flash recovery " + recoveryislemleriTextBox.Text;
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
        
            
        }
    }
}
