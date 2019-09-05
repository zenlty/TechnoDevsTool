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
    public partial class oemislemleri : Form
    {
        int mouseX = 0, mouseY = 0;
        public oemislemleri()
        {
            InitializeComponent();
        }

        private void oemislemleri_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("OEM Kilidini Aç");
            comboBox1.Items.Add("OEM Kilidini Aç / Alternatif");
            comboBox1.Items.Add("OEM Kilidini Aç / Alternatif");
            comboBox1.Items.Add("OEM Kilidini Kapat");
        }

        private void oemislemleri_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void oemislemleri_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void oemislemleri_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /* ÇIKIS*/
            this.Close();
            /* ÇIKIS*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /* OEM KONTROL*/
            if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                this.Close();
                Application.Exit();
            }
            /* OEM KONTROL*/
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem unlock";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* OEM KONTROL*/
            if (MessageBox.Show("OEM KILIDINI KAPATILACAK DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                this.Close();
                Application.Exit();
            }
            /* OEM KONTROL*/
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem lock";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            /*KONSOL TEMİZLEME KOMUTU*/
            Console.Clear();
            /*KONSOL TEMİZLEME KOMUTU*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            /* OEM KONTROL*/
            if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                this.Close();
                Application.Exit();
            }
            /* OEM KONTROL*/
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " -i 0x1bbb oem unlock";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            /* OEM KONTROL*/
            if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            }
            else
            {
                this.Close();
                Application.Exit();
            }
            /* OEM KONTROL*/
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem unlock-go";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // İlk Menü Seçiliyse
            {
                /* OEM KONTROL*/
                if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
                /* OEM KONTROL*/
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " oem unlock";
                process.StartInfo = startInfo;
                process.Start();
                Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 1) // İlk Menü Seçiliyse
            {
                /* OEM KONTROL*/
                if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
                /* OEM KONTROL*/
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " oem unlock-go";
                process.StartInfo = startInfo;
                process.Start();
                Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 2) // İlk Menü Seçiliyse
            {
                /* OEM KONTROL*/
                if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
                /* OEM KONTROL*/
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " -i 0x1bbb oem unlock";
                process.StartInfo = startInfo;
                process.Start();
                Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox1.SelectedIndex == 3) // İlk Menü Seçiliyse
            {
                /* OEM KONTROL*/
                if (MessageBox.Show("GELİŞTİRİCİ SEÇENENEKLERİNDEN OEM KİLİDİNİ VE USB HATA AYIKLAMA MODUNU AÇTIM. VERİLERİN SİLİNMESİNİ VE DOĞABİLECEK SORUNLARI KABUL EDİYORUM ?", "ONAY",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
                else
                {
                    this.Close();
                    Application.Exit();
                }
                /* OEM KONTROL*/
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " oem lock";
                process.StartInfo = startInfo;
                process.Start();
                Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
            }
        }

    }
}
