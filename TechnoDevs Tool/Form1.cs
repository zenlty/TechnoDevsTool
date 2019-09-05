/* EK BILGILENDIRMELER
BARIŞ MIZRAKLI TARAFINDAN KODLANDI. 
RETZH TARAFINDAN LOGO VE TASARIM EKLENDI
GAMAKEN TARAFINDAN REKLAM YAPILDI.
EMRE CAN AYAS TARAFINDAN SATIŞ VE PAZARLAMA YAPILDI.
BU PROJEYI "TECHNODEVS" PROJE BAŞLIĞI ALTINDA BARIŞ MIZRAKLI YÜRÜTMEKTEDİR.
 12 AĞUSTOS 2018 // 00:45 
 * 
 * 
 * 
 *             YENI FORM AC 
 * /        Form2 f2 = new Form2();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
 * 
 * 
 * 
 * 
 * 
 */
/* Bu Komut Çift Sistem Çalıştırmak içindir.
Process process = new Process();
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
startInfo.FileName = "ilksistem.uzantı";
startInfo2.FileName = "ikincisistem.uzantı";
startInfo.Arguments = "istenirseilksistemekod";
startInfo2.Arguments = "istenirseikincisistemekod";
process.StartInfo = startInfo;
process.Start();
Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
Bu Komut Çift Sistem Çalıştırmak içindir.*/
/*


            
        */
/* TEK SISTEM KODLAMA
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "ilksistem.uzantı";
            startInfo.Arguments = " ilksistemeisternizsekod";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace TechnoDevs_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Bu Komut Çift Sistem Çalıştırmak içindir.
             * Bu komut Program açılışında ADB & FastBoot cihazları algılar.*/
            Process process = new Process();
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
            startInfo2.FileName = "fastboot.exe";
            startInfo.Arguments = "devices";
            startInfo2.Arguments = "devices";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            /* Bu Komut Çift Sistem Çalıştırmak içindir.
            * Bu komut Program açılışında ADB & FastBoot cihazları algılar.*/
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tESTToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            /* KONTROLLU ÇIKIS*/
            if (MessageBox.Show("Çıkış Yapmak istediğinize emin misiniz ?", "Çıkış",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {

            }
            /* KONTROLLU ÇIKIS*/
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oemislemleri f2 = new oemislemleri();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tESTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
            /*BUTONA BASILDIĞINDA ADB & FASTBOOT CIHAZLARI ALGILAR*/
            /*
            Process process = new Process();
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
            startInfo2.FileName = "fastboot.exe";
            startInfo.Arguments = "devices -l";
            startInfo2.Arguments = "devices";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd(); */
            /*BUTONA BASILDIĞINDA ADB & FASTBOOT CIHAZLARI ALGILAR*/
        }

        private void aDBFASTBOOTCONSOLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adbfastboot f2 = new adbfastboot();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            {

            }
        }

        private void dIAGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diag f2 = new diag();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void lOGISLEMLERIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logislemleri f2 = new logislemleri();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
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
                    label1.Text = "Root Erişimi Alındı";
                    label1.BackColor = Color.Cyan;

                            if (console.Text == "")
                            {
                                checkBox1.BackColor = Color.Navy;
                                console.Text = "Root Erişimi Alınamadı";
                                label1.Text = "Root Erişimi Yok";
                            }
            }
            {
            if (console.Text == "")
            {
                console.Text = "Root Erişimi Alınamadı";
                label1.Text = "Root Erişimi Yok";
            }
            if (console.Text == "Root Erişimi Alınamadı")
            {
                console.Clear();
                console.Text = "Root Erişimi Alınamadı";
                label1.Text = "Root Erişimi Yok";
            }
            }
        }

        private void Console_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " start-server";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
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
            startInfo.Arguments = " kill-server";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
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
            startInfo.Arguments = " reboot";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button12_Click(object sender, EventArgs e)
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
            startInfo.Arguments = " reboot recovery";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
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
            startInfo.Arguments = " reboot edl";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button13_Click(object sender, EventArgs e)
        {
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
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem edl";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " reboot recovery";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " reboot-bootloader";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            MessageBox.Show("Fastboot Mode Gereklidir. ", "Uyarı");
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.WindowStyle = 
            ProcessWindowStyle.Minimized;
            p.StartInfo.FileName = "oemsorgula2.bat";
            p.Start();
            p.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("FastBoot Mod Gereklidir. ", "Uyarı");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "serino2.bat";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("FastBoot Mod Gereklidir. ", "Uyarı");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "serino2.bat";
            process.StartInfo = startInfo;
            process.Start();

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("FastBoot Mod Gereklidir. ", "Uyarı");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase cache";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("FastBoot Mod Gereklidir. ", "Uyarı");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem writesecureflag 3";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("FastBoot Mod Gereklidir. ", "Uyarı");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem writecid" + " " + cidDegistirTextBox.Text ;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            Process process2 = new Process();
            Process process3 = new Process();
            Process process4 = new Process();
            Process process5 = new Process();
            Process process6 = new Process();
            Process process7 = new Process();
            Process process8 = new Process();
            Process process9 = new Process();
            Process process10 = new Process();
            Process process11 = new Process();
            Process process12 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            ProcessStartInfo startInfo3 = new ProcessStartInfo();
            ProcessStartInfo startInfo4 = new ProcessStartInfo();
            ProcessStartInfo startInfo5 = new ProcessStartInfo();
            ProcessStartInfo startInfo6 = new ProcessStartInfo();
            ProcessStartInfo startInfo7 = new ProcessStartInfo();
            ProcessStartInfo startInfo8 = new ProcessStartInfo();
            ProcessStartInfo startInfo9 = new ProcessStartInfo();
            ProcessStartInfo startInfo10 = new ProcessStartInfo();
            ProcessStartInfo startInfo11 = new ProcessStartInfo();
            ProcessStartInfo startInfo12 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo8.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo9.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo10.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo11.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo12.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo3.CreateNoWindow = true;
            startInfo4.CreateNoWindow = true;
            startInfo5.CreateNoWindow = true;
            startInfo6.CreateNoWindow = true;
            startInfo7.CreateNoWindow = true;
            startInfo8.CreateNoWindow = true;
            startInfo9.CreateNoWindow = true;
            startInfo10.CreateNoWindow = true;
            startInfo11.CreateNoWindow = true;
            startInfo12.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo3.UseShellExecute = false;
            startInfo4.UseShellExecute = false;
            startInfo5.UseShellExecute = false;
            startInfo6.UseShellExecute = false;
            startInfo7.UseShellExecute = false;
            startInfo8.UseShellExecute = false;
            startInfo9.UseShellExecute = false;
            startInfo10.UseShellExecute = false;
            startInfo11.UseShellExecute = false;
            startInfo11.UseShellExecute = false;
            startInfo12.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;
            startInfo3.RedirectStandardOutput = true;
            startInfo4.RedirectStandardOutput = true;
            startInfo5.RedirectStandardOutput = true;
            startInfo6.RedirectStandardOutput = true;
            startInfo7.RedirectStandardOutput = true;
            startInfo8.RedirectStandardOutput = true;
            startInfo9.RedirectStandardOutput = true;
            startInfo10.RedirectStandardOutput = true;
            startInfo11.RedirectStandardOutput = true;
            startInfo12.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";
            startInfo3.FileName = "adb.exe";
            startInfo4.FileName = "adb.exe";
            startInfo5.FileName = "adb.exe";
            startInfo6.FileName = "adb.exe";
            startInfo7.FileName = "adb.exe";
            startInfo8.FileName = "adb.exe";
            startInfo9.FileName = "adb.exe";
            startInfo10.FileName = "adb.exe";
            startInfo11.FileName = "adb.exe";
            startInfo12.FileName = "adb.exe";
            startInfo.Arguments = " shell getprop ro.product.model ";
            startInfo2.Arguments = " shell getprop ro.product.manufacturer ";
            startInfo3.Arguments = " shell getprop ro.build.version.release";
            startInfo4.Arguments = " shell getprop ro.product.device";
            startInfo5.Arguments = " shell getprop ro.product.brand";
            startInfo6.Arguments = "shell getprop ro.build.id";
            startInfo7.Arguments = "shell getprop ro.build.version.sdk ";
            startInfo8.Arguments = "shell getprop ro.build.version.codename ";
            startInfo9.Arguments = "shell getprop ro.build.version.all_codenames ";
            startInfo10.Arguments = "shell getprop ro.build.version.security_patch ";
            startInfo11.Arguments = "shell getprop ro.product.locale ";
            startInfo12.Arguments = " shell su -v ";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;
            process3.StartInfo = startInfo3;
            process4.StartInfo = startInfo4;
            process5.StartInfo = startInfo5;
            process6.StartInfo = startInfo6;
            process7.StartInfo = startInfo7;
            process8.StartInfo = startInfo8;
            process9.StartInfo = startInfo9;
            process10.StartInfo = startInfo10;
            process11.StartInfo = startInfo11;
            process12.StartInfo = startInfo12;
            process.Start();
            process2.Start();
            process3.Start();
            process4.Start();
            process5.Start();
            process6.Start();
            process7.Start();
            process8.Start();
            process9.Start();
            process10.Start();
            process11.Start();
            process12.Start();
            console.Text = console.Text + "Marka = " + process2.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Model = " + process.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Android Sürümü = " + process3.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Derleme Kodu = " + process6.StandardOutput.ReadToEnd();
            console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd();
            console.Text = console.Text + "Root  = " + process12.StandardOutput.ReadToEnd();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase system ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase boot ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase recovery ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase cache ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase persist ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase splash ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase aboot ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase ddr ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase oem ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase mics ";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat Partition Silinecektir. FastBoot Mod'da olduğunuzdan emin olun.", "DIKKAT !");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase  " + bolumTextBox.Text ;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void dosyaÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyacek f2 = new dosyacek();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fastBootÖzelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastbootdosyayukle f2 = new fastbootdosyayukle();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void recoveryİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recoveryislemleri f2 = new recoveryislemleri();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void aDBSideLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adbsideload f2 = new adbsideload();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            adbsideload f2 = new adbsideload();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            adbsideload f2 = new adbsideload();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button32_Click(object sender, EventArgs e)
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
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "shell am start -a android.intent.action.CALL -d tel:" + araTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            if (console.Text == "")
            {
                console.Text = "Arama Başarılı";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            adbsideload f2 = new adbsideload();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            demo f2 = new demo();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            /*KONSOL TEMİZLEME KOMUTU*/
            console.Text = " ";
            /*KONSOL TEMİZLEME KOMUTU*/
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat ! Sadece Original IMEI Numaranızı yazınız. Yasa Dışı yapılacak işlemlerden kullanıcı sorumludur" , "DIKKAT !");
            MessageBox.Show("Dikkat ! Cihazı FastBoot Mod'a alınız. Ardından bu mesajı onaylayınız.", "Bilgilendirme"); 
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem writeimei " + imeiwritefastbootTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();

        }

        private void button36_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("TWRP Yüklü olmak zorundadır.", "Uyarı");
            MessageBox.Show("Dikkat ! TWRP > Gelişmiş Menüsünden ADB SideLoad Etkinleştiriniz.", "DIKKAT !");
            MessageBox.Show("Dikkat ! Cihazı SideLoad Mod'a Alınız.. Ardından bu mesajı onaylayınız.", "Bilgilendirme");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "supersu.exe";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell content insert --uri content://settings/secure --bind name:s:user_setup_conplete --bind value:s:1";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Factory Reset Yapınız ! ";
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            imeiwritefastbootTextBox.Clear();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Process process = new Process();
            Process process2 = new Process();
            Process process3 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            ProcessStartInfo startInfo3 = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo3.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo2.CreateNoWindow = true;
            startInfo3.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo2.UseShellExecute = false;
            startInfo3.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo2.RedirectStandardOutput = true;
            startInfo3.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo2.FileName = "adb.exe";
            startInfo3.FileName = "adb.exe";
            startInfo.Arguments = " shell getprop ro.product.model ";
            startInfo2.Arguments = " shell getprop ro.product.manufacturer ";
            startInfo3.Arguments = " shell getprop ro.build.version.release";
            process.StartInfo = startInfo;
            process2.StartInfo = startInfo2;
            process3.StartInfo = startInfo3;
            process.Start();
            process2.Start();
            process3.Start();
            label8.Text = process.StandardOutput.ReadToEnd();
            label10.Text = process2.StandardOutput.ReadToEnd();
            label13.Text = process3.StandardOutput.ReadToEnd();

            if (label8.Text == "")
            {
                pictureBox1.BackColor = Color.Red;
                label10.Text = "Cihaz Bağlı Değil";
                label9.Visible = false;
                label8.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
            }
            else
            {
                pictureBox1.BackColor = Color.White;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;

            }
            if (pictureBox1.BackColor != Color.White)
            {
                SoundPlayer ses = new SoundPlayer();
                string dizin = Application.StartupPath + "\\detected.wav";
                ses.SoundLocation = dizin;
                ses.Play();
            }
            else
            {

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button28_MouseHover(object sender, EventArgs e)
        {

        }

        private void button39_Click_1(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            
        }

        private void button40_Click_1(object sender, EventArgs e)
        {

        }

        private void button39_Click_2(object sender, EventArgs e)
        {
            Driver f2 = new Driver();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            recoveryislemleri f2 = new recoveryislemleri();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button40_Click_2(object sender, EventArgs e)
        {
            adbsideload f2 = new adbsideload();
            f2.Show();
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(console.Text);
            if (console.Text == " ")
            {
                MessageBox.Show("Kopyalanacak bir metin bulunmamaktadır.", "Uyarı");
            }
        }
    }
}
