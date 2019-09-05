using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace TechnoDevs_Tool
{
    public partial class fastbootdosyayukle : Form
    {
        public fastbootdosyayukle()
        {
            InitializeComponent();
        }

        private void fastbootdosyayukle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cihaz Kontrol");
            comboBox1.Items.Add("System.img Flash'la");
            comboBox1.Items.Add("Boot.img Flash'la");
            comboBox1.Items.Add("Recovery.img Flash'la");
            comboBox1.Items.Add("OEM.img Flash'la");
            comboBox1.Items.Add("Persist.img Flash'la");
            comboBox1.Items.Add("UserData.img Flash'la");

        }

        private void button8_Click(object sender, EventArgs e)
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
                startInfo.Arguments = " devices";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }

            if (comboBox1.SelectedIndex == 1) //fastboot flash
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "Imaj Dosyası|*.img";
                openfile.Title = "System.img Seçiniz..";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    flashsystemTextbox.Text = openfile.FileName;
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " flash system \"" + openfile.FileName + "\"";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
            }
            {
                if (comboBox1.SelectedIndex == 2) //fastboot boot
                {
                    OpenFileDialog openfile = new OpenFileDialog();
                    openfile.Filter = "Imaj Dosyası|*.img";
                    openfile.Title = "Boot.img Seçiniz..";
                    if (openfile.ShowDialog() == DialogResult.OK)
                    {
                        flashbootTextbox.Text = openfile.FileName;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.FileName = "fastboot.exe";
                        startInfo.Arguments = " flash Boot \"" + openfile.FileName + "\"";
                        process.StartInfo = startInfo;
                        process.Start();
                        console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    }
                  }
              }
              {
                if (comboBox1.SelectedIndex == 3) //fastboot recovery
                {
                    OpenFileDialog openfile = new OpenFileDialog();
                    openfile.Filter = "Imaj Dosyası|*.img";
                    openfile.Title = "Recovery.img Seçiniz..";
                    if (openfile.ShowDialog() == DialogResult.OK)
                    {
                        recoveryflashTextBox.Text = openfile.FileName;
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.FileName = "fastboot.exe";
                        startInfo.Arguments = " flash recovery \"" + openfile.FileName + "\"";
                        process.StartInfo = startInfo;
                        process.Start();
                        console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    }
                }
            }
              {
                  if (comboBox1.SelectedIndex == 4) //fastboot OEM
                  {
                      OpenFileDialog openfile = new OpenFileDialog();
                      openfile.Filter = "Imaj Dosyası|*.img";
                      openfile.Title = "OEM.img Seçiniz..";
                      if (openfile.ShowDialog() == DialogResult.OK)
                      {
                          oemflashTextBox.Text = openfile.FileName;
                          Process process = new Process();
                          ProcessStartInfo startInfo = new ProcessStartInfo();
                          startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                          startInfo.CreateNoWindow = true;
                          startInfo.UseShellExecute = false;
                          startInfo.RedirectStandardOutput = true;
                          startInfo.FileName = "fastboot.exe";
                          startInfo.Arguments = " flash oem \"" + openfile.FileName + "\"";
                          process.StartInfo = startInfo;
                          process.Start();
                          console.Text = console.Text + process.StandardOutput.ReadToEnd();
                      }
                  }
              }
              {
                  if (comboBox1.SelectedIndex == 5) //fastboot Persist
                  {
                      OpenFileDialog openfile = new OpenFileDialog();
                      openfile.Filter = "Imaj Dosyası|*.img";
                      openfile.Title = "Persist.img Seçiniz..";
                      if (openfile.ShowDialog() == DialogResult.OK)
                      {
                          persistflashTextBox.Text = openfile.FileName;
                          Process process = new Process();
                          ProcessStartInfo startInfo = new ProcessStartInfo();
                          startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                          startInfo.CreateNoWindow = true;
                          startInfo.UseShellExecute = false;
                          startInfo.RedirectStandardOutput = true;
                          startInfo.FileName = "fastboot.exe";
                          startInfo.Arguments = " flash persist \"" + openfile.FileName + "\"";
                          process.StartInfo = startInfo;
                          process.Start();
                          console.Text = console.Text + process.StandardOutput.ReadToEnd();
                      }
                  }
              }
              {
                  if (comboBox1.SelectedIndex == 6) //fastboot UserData
                  {
                      OpenFileDialog openfile = new OpenFileDialog();
                      openfile.Filter = "Imaj Dosyası|*.img";
                      openfile.Title = "UserData.img Seçiniz..";
                      if (openfile.ShowDialog() == DialogResult.OK)
                      {
                          userdataflashTextBox.Text = openfile.FileName;
                          Process process = new Process();
                          ProcessStartInfo startInfo = new ProcessStartInfo();
                          startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                          startInfo.CreateNoWindow = true;
                          startInfo.UseShellExecute = false;
                          startInfo.RedirectStandardOutput = true;
                          startInfo.FileName = "fastboot.exe";
                          startInfo.Arguments = " flash userdata \"" + openfile.FileName + "\"";
                          process.StartInfo = startInfo;
                          process.Start();
                          console.Text = console.Text + process.StandardOutput.ReadToEnd();
                      }
                  }
              }
            }
        
    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
