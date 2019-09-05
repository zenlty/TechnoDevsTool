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
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "cihazbilgileri1.bat";
            process.StartInfo = startInfo;
            process.Start();
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
            console.Clear();
            /*KONSOL TEMİZLEME KOMUTU*/
        }
    }
}
