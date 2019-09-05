using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace TechnoDevs_Tool
{
    public partial class Driver : Form
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient driver = new WebClient();
            driver.DownloadFileAsync(new Uri(textBox1.Text), Application.StartupPath + @"\driver.rar");
            driver.DownloadFileCompleted += driver_DownloadFileCompleted;
            driver.DownloadProgressChanged += driver_DownloadProgressChanged;
        }

        void driver_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        void driver_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            label2.Visible = true;
            label2.Text = "İndirme Tamamlandı.";
        }

        private void Driver_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("MTK WINDOWS 10 Driver");
            comboBox1.Items.Add("V2.2'de Güncellenecektir.");
            MessageBox.Show("İndirme işlemleri gerçekleştirdikten sonra programın kurulu olduğu dizine Driver.rar olarak kayıt edilecektir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem == "MTK WINDOWS 10 Driver")
            {
                textBox1.Text = "http://www.dosya.tc/en2.php?a=server15/y3qk0n/Windows_10_MTK_VCOM_USB_Preloader_Drivers.rar&b=c0b2a7eafbe773c3976273159225ef5b";
            }
            if (label2.Text != "İndirme Tamamlandı.")
            {
                label2.Text = "İndirme Bekleniyor.";
            }
        }//

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
