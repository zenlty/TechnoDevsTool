using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Aşağıdaki referansı ekliyoruz.
using System.Net;

namespace TechnoDevs_Tool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button22_Click_1(object sender, EventArgs e)
        {

        }

        private void button25_Click_1(object sender, EventArgs e)
        {

        }
        void driver_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }
        void driver_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Directory.CreateDirectory("C:/DosyaCek");
            string myPath = Application.ExecutablePath;
            MessageBox.Show("İndirme Başarılı,Açılan pencerede " + comboBox8.Text + ".zip olarak belirlendi. Lütfen yeni sürümü hemen kurunuz.");
            string myPath2 = Application.StartupPath;
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath2;
            prc.Start();
            progressBar1.Value = 0;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click_2(object sender, EventArgs e)
        {

            {
                if (comboBox8.SelectedIndex == 0)
                {
                    textBox333.Text = "http://forum.technodevs.org/technodevstool/technodevstoolbuild/HackzzersTool.zip";
                }
                if (label21.Text != "İndirme Tamamlandı.")
                {
                    label21.Text = "İndirme Bekleniyor.";
                }
            }
        }

        private void button25_Click_2(object sender, EventArgs e)
        {
            if (label21.Text != "Seçim Bekleniyor...")
            {
                WebClient driver = new WebClient();
                driver.DownloadFileAsync(new Uri(textBox333.Text), Application.StartupPath + @"\" + comboBox8.Text + ".zip");
                driver.DownloadFileCompleted += driver_DownloadFileCompleted;
                driver.DownloadProgressChanged += driver_DownloadProgressChanged;
            }
            else
            {
                MessageBox.Show("Lütfen Seçiminizi Yapınız.",">_Uyarı");
            }
        }
    }
}
