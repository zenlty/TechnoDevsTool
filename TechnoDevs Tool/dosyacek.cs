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
            MessageBox.Show("Dosya Çekme İşlemlerinizde Dosyalar C:/DosyaCek konumunda olacaktır. İşlemlerinizin ardından klasör otomatik olarak açılacaktır.", "Dikkat !");
            Directory.CreateDirectory("C:/DosyaCek");
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();

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
            startInfo.Arguments = "pull " + dosyacekTextBox.Text + " " + "C:/DosyaCek";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
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
            startInfo.Arguments = " push " + " " + dosyayukleTextBox.Text + " " + dosyakonumuTextBox.Text;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /system/etc/mddb C:/DosyaCek" ;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /system/media C:/DosyaCek";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /system C:/DosyaCek";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Yüklemek istediğiniz dosyayı Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                dosyayukleTextBox.Text = openfile.FileName;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            Process process2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;

            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";

            startInfo.Arguments = " shell su -c mount -o rw,remount /system";

            startInfo2.Arguments = " shell su -c mount -o ro,remount /system";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;

            process.Start();
            process2.Start();


            console.Text = "Komut Algılandı.";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            Process process2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;

            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";

            startInfo.Arguments = " shell su -c mount -o rw,remount /data";

            startInfo2.Arguments = " shell su -c mount -o ro,remount /data";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;

            process.Start();
            process2.Start();

            console.Text = "Komut Algılandı.";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            Process process2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;

            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";

            startInfo.Arguments = " shell su -c mount -o rw,remount /oem";

            startInfo2.Arguments = " shell su -c mount -o ro,remount /oem";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;

            process.Start();
            process2.Start();

            console.Text = "Komut Algılandı.";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            Process process2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;

            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";

            startInfo.Arguments = " shell su -c mount -o rw,remount /persist";

            startInfo2.Arguments = " shell su -c mount -o ro,remount /persist";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;

            process.Start();
            process2.Start();

            console.Text = "Komut Algılandı.";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Dikkat /system/etc değildir.", "Uyarı");
            Process process = new Process();
            Process process2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;

            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";

            startInfo.Arguments = " shell su -c mount -o rw,remount /etc";

            startInfo2.Arguments = " shell su -c mount -o ro,remount /etc";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;

            process.Start();
            process2.Start();

            console.Text = "Komut Algılandı.";
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            Process process2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;

            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";

            startInfo.Arguments = " shell su -c mount -o rw,remount /vendor";

            startInfo2.Arguments = " shell su -c mount -o ro,remount /vendor";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;

            process.Start();
            process2.Start();

            console.Text = "Komut Algılandı.";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /system/build.orop C:/DosyaCek";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }
    }
}
/* List of devices attached


*/