﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TechnoDevs_Tool
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(System.Int32 vKey);
        string kopyalanacakDosya = "", dosyanınKopyanacagiKlasor = "", kopyalanacakDosyaIsmi = "";
        private int i;
        public Form1()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x219)
            {
                console.Clear();
                {
                    {

                        {

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
                            if (label10.Text != "Cihaz Bağlı Değil")
                            {
                                Process aprocess = new Process();
                                Process aprocess2 = new Process();
                                Process aprocess3 = new Process();
                                Process process4 = new Process();
                                Process process5 = new Process();
                                Process process6 = new Process();
                                Process process7 = new Process();
                                Process process8 = new Process();
                                Process process9 = new Process();
                                Process process10 = new Process();
                                Process process11 = new Process();
                                Process process12 = new Process();
                                ProcessStartInfo astartInfo = new ProcessStartInfo();
                                ProcessStartInfo astartInfo2 = new ProcessStartInfo();
                                ProcessStartInfo astartInfo3 = new ProcessStartInfo();
                                ProcessStartInfo startInfo4 = new ProcessStartInfo();
                                ProcessStartInfo startInfo5 = new ProcessStartInfo();
                                ProcessStartInfo startInfo6 = new ProcessStartInfo();
                                ProcessStartInfo startInfo7 = new ProcessStartInfo();
                                ProcessStartInfo startInfo8 = new ProcessStartInfo();
                                ProcessStartInfo startInfo9 = new ProcessStartInfo();
                                ProcessStartInfo startInfo10 = new ProcessStartInfo();
                                ProcessStartInfo startInfo11 = new ProcessStartInfo();
                                ProcessStartInfo startInfo12 = new ProcessStartInfo();
                                astartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                                astartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                                astartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo8.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo9.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo10.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo11.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo12.WindowStyle = ProcessWindowStyle.Hidden;
                                astartInfo.CreateNoWindow = true;
                                astartInfo2.CreateNoWindow = true;
                                astartInfo3.CreateNoWindow = true;
                                startInfo4.CreateNoWindow = true;
                                startInfo5.CreateNoWindow = true;
                                startInfo6.CreateNoWindow = true;
                                startInfo7.CreateNoWindow = true;
                                startInfo8.CreateNoWindow = true;
                                startInfo9.CreateNoWindow = true;
                                startInfo10.CreateNoWindow = true;
                                startInfo11.CreateNoWindow = true;
                                startInfo12.CreateNoWindow = true;
                                astartInfo.UseShellExecute = false;
                                astartInfo2.UseShellExecute = false;
                                astartInfo3.UseShellExecute = false;
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
                                astartInfo.RedirectStandardOutput = true;
                                astartInfo2.RedirectStandardOutput = true;
                                astartInfo3.RedirectStandardOutput = true;
                                startInfo4.RedirectStandardOutput = true;
                                startInfo5.RedirectStandardOutput = true;
                                startInfo6.RedirectStandardOutput = true;
                                startInfo7.RedirectStandardOutput = true;
                                startInfo8.RedirectStandardOutput = true;
                                startInfo9.RedirectStandardOutput = true;
                                startInfo10.RedirectStandardOutput = true;
                                startInfo11.RedirectStandardOutput = true;
                                startInfo12.RedirectStandardOutput = true;
                                astartInfo.FileName = "adb.exe";
                                astartInfo2.FileName = "adb.exe";
                                astartInfo3.FileName = "adb.exe";
                                startInfo4.FileName = "adb.exe";
                                startInfo5.FileName = "adb.exe";
                                startInfo6.FileName = "adb.exe";
                                startInfo7.FileName = "adb.exe";
                                startInfo8.FileName = "adb.exe";
                                startInfo9.FileName = "adb.exe";
                                startInfo10.FileName = "adb.exe";
                                startInfo11.FileName = "adb.exe";
                                startInfo12.FileName = "adb.exe";
                                astartInfo.Arguments = " shell getprop ro.product.model";
                                astartInfo2.Arguments = " shell getprop ro.product.manufacturer";
                                astartInfo3.Arguments = " shell getprop ro.build.version.release";
                                startInfo4.Arguments = " shell getprop ro.product.device";
                                startInfo5.Arguments = " shell getprop ro.product.brand";
                                startInfo6.Arguments = "shell getprop ro.build.id";
                                startInfo7.Arguments = "shell getprop ro.build.version.sdk";
                                startInfo8.Arguments = "shell getprop ro.build.version.codename";
                                startInfo9.Arguments = "shell getprop ro.build.version.all_codenames";
                                startInfo10.Arguments = "shell getprop ro.build.version.security_patch";
                                startInfo11.Arguments = "shell getprop ro.product.locale";
                                startInfo12.Arguments = " shell su -v ";
                                aprocess.StartInfo = astartInfo;
                                aprocess2.StartInfo = astartInfo2;
                                aprocess3.StartInfo = astartInfo3;
                                process4.StartInfo = startInfo4;
                                process5.StartInfo = startInfo5;
                                process6.StartInfo = startInfo6;
                                process7.StartInfo = startInfo7;
                                process8.StartInfo = startInfo8;
                                process9.StartInfo = startInfo9;
                                process10.StartInfo = startInfo10;
                                process11.StartInfo = startInfo11;
                                process12.StartInfo = startInfo12;
                                aprocess.Start();
                                aprocess2.Start();
                                aprocess3.Start();
                                process4.Start();
                                process5.Start();
                                process6.Start();
                                process7.Start();
                                process8.Start();
                                process9.Start();
                                process10.Start();
                                process11.Start();
                                process12.Start();
                                /* console.Text = console.Text + "Marka = " + aprocess2.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Android Versiyon = " + aprocess3.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd() + "\n";
                                 console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd() + "\n";*/
                                //console.Text = console.Text + "Marka = " + aprocess2.StandardOutput.ReadToEnd() + "\n";
                                label24.Text = aprocess2.StandardOutput.ReadToEnd();
                                //  label24.Text =aprocess2.StandardOutput.ReadToEnd();
                                //   console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd() + "\n";
                                label25.Text = aprocess.StandardOutput.ReadToEnd() + "\n";

                                // console.Text = console.Text + "Android Versiyon = " + aprocess3.StandardOutput.ReadToEnd() + "\n";
                                label26.Text = aprocess3.StandardOutput.ReadToEnd() + "\n";
                                //console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd() + "\n";
                                label27.Text = process4.StandardOutput.ReadToEnd() + "\n";
                                //console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd() + "\n";
                                label28.Text = process5.StandardOutput.ReadToEnd() + "\n";
                                //console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd() + "\n";
                                label29.Text = process6.StandardOutput.ReadToEnd() + "\n";
                                //console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd() + "\n";
                                label30.Text = process7.StandardOutput.ReadToEnd() + "\n";
                                // console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd() + "\n";
                                label31.Text = process8.StandardOutput.ReadToEnd() + "\n";
                                // console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd() + "\n";
                                label32.Text = process9.StandardOutput.ReadToEnd() + "\n";
                                //  console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd() + "\n";
                                label33.Text = process10.StandardOutput.ReadToEnd() + "\n";
                                //   console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd() + "\n";
                                label34.Text = process11.StandardOutput.ReadToEnd() + "\n";

                            }


                            if (label8.Text == "")
                            {
                                pictureBox1.BackColor = Color.Red;
                                label10.Text = "Cihaz Bağlı Değil";
                                label9.Visible = false;
                                label8.Visible = false;
                                label11.Visible = false;
                                label12.Visible = false;
                                label13.Visible = false;
                                if (label10.Text == "Cihaz Bağlı Değil")
                                {
                                    Process process4 = new Process();
                                    ProcessStartInfo startInfo4 = new ProcessStartInfo();
                                    startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                                    startInfo4.CreateNoWindow = true;
                                    startInfo4.UseShellExecute = false;
                                    startInfo4.RedirectStandardOutput = true;
                                    startInfo4.FileName = "fastboot.exe";
                                    startInfo4.Arguments = "devices";
                                    process.StartInfo = startInfo4;
                                    process.Start();
                                    label10.Text = process.StandardOutput.ReadToEnd();
                                    console.Text = process.StandardOutput.ReadToEnd();
                                    if (label10.Text == "")
                                    {
                                        label9.Visible = false;
                                        label10.Text = "Cihaz Bağlı Değil";
                                    }
                                    else
                                    {
                                        label9.Visible = true;
                                        pictureBox1.Visible = true;
                                        label10.Visible = true;
                                        pictureBox1.BackColor = Color.Aqua;

                                    }

                                }
                            }
                            else
                            {
                                pictureBox1.BackColor = Color.Blue;
                                label8.Visible = true;
                                label9.Visible = true;
                                label10.Visible = true;
                                label11.Visible = true;
                                label12.Visible = true;
                                label13.Visible = true;

                            }
                        }
                    }

                }
            }
            base.WndProc(ref m);
        }

        //Process
        //Process process = new Process();
        //ProcessStartInfo startInfo = new ProcessStartInfo();
        //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //startInfo.CreateNoWindow = true;
        //startInfo.UseShellExecute = false;
        //startInfo.RedirectStandardOutput = true;
        //startInfo.FileName = "adb.exe";
        //startInfo.Arguments = "reboot";
        //process.StartInfo = startInfo;
        //process.Start();
        //console.Text = console.Text + process.StandardOutput.ReadToEnd();
        /*
         * 
         * 
         * 
         * */
        private void UpdateKontrol()
        {
            if (CheckUpdate())
            {
                DialogResult dialog = MessageBox.Show("Yeni Güncelleme Var. \n\rŞimdi Yüklemek istermisiniz?", "Güncelleme Bulundu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(updateMe));
                    t.Start();
                    this.Close();

                }
            }
        }

        public static void updateMe()
        {
            Application.Run(new Form3());
        }


        private Boolean CheckUpdate()
        {
            Boolean ret;
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("http://forum.ForumAndroid.org/ForumAndroidtool/ForumAndroidtoolbuild/check.php?v=" + Program.versionCode); //Burdaki domain.com kısmını kendinize göre düzenlemeniz gerek. Artık sunucunuzun ip numarasını yada varsa domain adresinizi yazıp php dosyasını nereye attıysanız onun yolunu bu kısma yazmanız gerek. check.php?v= kısmından sonra yazan kod ise Program.csde tanımladığımız program versionunu çekmeye yarıyor.
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                if (content == "UPDATE") //Dönen veriyi kontrol ediyor. Dönen veri UPDATE ise güncelleme aşamasına geçiyor.
                {
                    ret = true;
                }
                else
                {
                    ret = false;
                }
            }
            catch
            {
                ret = false;
            }
            return ret;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Cihaz Denetleme");
            toolTip1.ToolTipTitle = "Kırmızı Olduğunda Kapalı, Mavi Olduğunda ADB, Turkuaz Olduğunda FastBoot Mod'dasınızdır.";
            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            if (pictureBox1.BackColor == Color.Red)
            {
                info.BackColor = Color.Red;
                info.Text = "Şu An Cihazınız Bağlı Değil";
                info.ForeColor = Color.Bisque;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                info.BackColor = Color.Aqua;
                info.Text = "Şu An Cihazınız FastBoot Moddadır.";
                info.ForeColor = Color.Black;

            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                info.BackColor = Color.Blue;
                info.Text = "Şu An Cihazınız ADB Moddadır.";
            }
            UpdateKontrol();
           Directory.CreateDirectory("C:/DosyaCek");
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            Random rnd = new Random();
            int renk = rnd.Next(1, 9);
            if (renk == 1)
            {
                console.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
                label11.ForeColor = Color.Red;
                label12.ForeColor = Color.Red;
            }
            if (renk == 2)
            {
                console.ForeColor = Color.Green;
                label9.ForeColor = Color.Green;
                label11.ForeColor = Color.Green;
                label12.ForeColor = Color.Green;
            }
            if (renk == 3)
            {
                console.ForeColor = Color.Blue;
                label9.ForeColor = Color.Blue;
                label11.ForeColor = Color.Blue;
                label12.ForeColor = Color.Blue;
            }
            if (renk == 4)
            {
                console.ForeColor = Color.Purple;
                label9.ForeColor = Color.Purple;
                label11.ForeColor = Color.Purple;
                label12.ForeColor = Color.Purple;
            }
            if (renk == 5)
            {
                console.ForeColor = Color.DarkBlue;
                label9.ForeColor = Color.DarkBlue;
                label11.ForeColor = Color.DarkBlue;
                label12.ForeColor = Color.DarkBlue;
            }
            if (renk == 6)
            {
                console.ForeColor = Color.DarkRed;
                label9.ForeColor = Color.DarkRed;
                label11.ForeColor = Color.DarkRed;
                label12.ForeColor = Color.DarkRed;
            }
            if (renk == 7)
            {
                console.ForeColor = Color.Black;
                label9.ForeColor = Color.DarkRed;
                label11.ForeColor = Color.DarkRed;
                label12.ForeColor = Color.DarkRed;
            }
            if (renk == 8)
            {
                console.ForeColor = Color.CadetBlue;
                label9.ForeColor = Color.CadetBlue;
                label11.ForeColor = Color.CadetBlue;
                label12.ForeColor = Color.CadetBlue;
            }
            if (renk == 9)
            {
                console.ForeColor = Color.Brown;
                label9.ForeColor = Color.Brown;
                label11.ForeColor = Color.Brown;
                label12.ForeColor = Color.Brown;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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
            if (label10.Text != "Cihaz Bağlı Değil")
            {
                Process aprocess = new Process();
                Process aprocess2 = new Process();
                Process aprocess3 = new Process();
                Process process4 = new Process();
                Process process5 = new Process();
                Process process6 = new Process();
                Process process7 = new Process();
                Process process8 = new Process();
                Process process9 = new Process();
                Process process10 = new Process();
                Process process11 = new Process();
                Process process12 = new Process();
                ProcessStartInfo astartInfo = new ProcessStartInfo();
                ProcessStartInfo astartInfo2 = new ProcessStartInfo();
                ProcessStartInfo astartInfo3 = new ProcessStartInfo();
                ProcessStartInfo startInfo4 = new ProcessStartInfo();
                ProcessStartInfo startInfo5 = new ProcessStartInfo();
                ProcessStartInfo startInfo6 = new ProcessStartInfo();
                ProcessStartInfo startInfo7 = new ProcessStartInfo();
                ProcessStartInfo startInfo8 = new ProcessStartInfo();
                ProcessStartInfo startInfo9 = new ProcessStartInfo();
                ProcessStartInfo startInfo10 = new ProcessStartInfo();
                ProcessStartInfo startInfo11 = new ProcessStartInfo();
                ProcessStartInfo startInfo12 = new ProcessStartInfo();
                astartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                astartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                astartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo8.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo9.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo10.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo11.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo12.WindowStyle = ProcessWindowStyle.Hidden;
                astartInfo.CreateNoWindow = true;
                astartInfo2.CreateNoWindow = true;
                astartInfo3.CreateNoWindow = true;
                startInfo4.CreateNoWindow = true;
                startInfo5.CreateNoWindow = true;
                startInfo6.CreateNoWindow = true;
                startInfo7.CreateNoWindow = true;
                startInfo8.CreateNoWindow = true;
                startInfo9.CreateNoWindow = true;
                startInfo10.CreateNoWindow = true;
                startInfo11.CreateNoWindow = true;
                startInfo12.CreateNoWindow = true;
                astartInfo.UseShellExecute = false;
                astartInfo2.UseShellExecute = false;
                astartInfo3.UseShellExecute = false;
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
                astartInfo.RedirectStandardOutput = true;
                astartInfo2.RedirectStandardOutput = true;
                astartInfo3.RedirectStandardOutput = true;
                startInfo4.RedirectStandardOutput = true;
                startInfo5.RedirectStandardOutput = true;
                startInfo6.RedirectStandardOutput = true;
                startInfo7.RedirectStandardOutput = true;
                startInfo8.RedirectStandardOutput = true;
                startInfo9.RedirectStandardOutput = true;
                startInfo10.RedirectStandardOutput = true;
                startInfo11.RedirectStandardOutput = true;
                startInfo12.RedirectStandardOutput = true;
                astartInfo.FileName = "adb.exe";
                astartInfo2.FileName = "adb.exe";
                astartInfo3.FileName = "adb.exe";
                startInfo4.FileName = "adb.exe";
                startInfo5.FileName = "adb.exe";
                startInfo6.FileName = "adb.exe";
                startInfo7.FileName = "adb.exe";
                startInfo8.FileName = "adb.exe";
                startInfo9.FileName = "adb.exe";
                startInfo10.FileName = "adb.exe";
                startInfo11.FileName = "adb.exe";
                startInfo12.FileName = "adb.exe";
                astartInfo.Arguments = " shell getprop ro.product.model ";
                astartInfo2.Arguments = " shell getprop ro.product.manufacturer ";
                astartInfo3.Arguments = " shell getprop ro.build.version.release";
                startInfo4.Arguments = " shell getprop ro.product.device";
                startInfo5.Arguments = " shell getprop ro.product.brand";
                startInfo6.Arguments = "shell getprop ro.build.id";
                startInfo7.Arguments = "shell getprop ro.build.version.sdk ";
                startInfo8.Arguments = "shell getprop ro.build.version.codename ";
                startInfo9.Arguments = "shell getprop ro.build.version.all_codenames ";
                startInfo10.Arguments = "shell getprop ro.build.version.security_patch ";
                startInfo11.Arguments = "shell getprop ro.product.locale ";
                startInfo12.Arguments = " shell su -v ";
                aprocess.StartInfo = astartInfo;
                aprocess2.StartInfo = astartInfo2;
                aprocess3.StartInfo = astartInfo3;
                process4.StartInfo = startInfo4;
                process5.StartInfo = startInfo5;
                process6.StartInfo = startInfo6;
                process7.StartInfo = startInfo7;
                process8.StartInfo = startInfo8;
                process9.StartInfo = startInfo9;
                process10.StartInfo = startInfo10;
                process11.StartInfo = startInfo11;
                process12.StartInfo = startInfo12;
                aprocess.Start();
                aprocess2.Start();
                aprocess3.Start();
                process4.Start();
                process5.Start();
                process6.Start();
                process7.Start();
                process8.Start();
                process9.Start();
                process10.Start();
                process11.Start();
                process12.Start();
                console.Text = console.Text + "Brand = " + aprocess2.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Android Version = " + aprocess3.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Code Name  = " + process4.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Producter = " + process5.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd();
                console.Text = console.Text + "SDK Number = " + process7.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Security Patch History = " + process10.StandardOutput.ReadToEnd();
                console.Text = console.Text + "Language and Country = " + process11.StandardOutput.ReadToEnd();
                if (process12.StandardOutput.ReadToEnd() == "")
                {
                    console.Text = console.Text + "Root  = " + "Root Not Found\n";
                }
                else
                {
                    console.Text = console.Text + "Root  = " + process12.StandardOutput.ReadToEnd() + "\n";

                }

            }


            if (label8.Text == "")
            {
                pictureBox1.BackColor = Color.Red;
                label10.Text = "Cihaz Bağlı Değil";
                label9.Visible = false;
                label8.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                if (label10.Text == "Cihaz Bağlı Değil")
                {
                    Process process4 = new Process();
                    ProcessStartInfo startInfo4 = new ProcessStartInfo();
                    startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo4.CreateNoWindow = true;
                    startInfo4.UseShellExecute = false;
                    startInfo4.RedirectStandardOutput = true;
                    startInfo4.FileName = "fastboot.exe";
                    startInfo4.Arguments = "devices";
                    process.StartInfo = startInfo4;
                    process.Start();
                    label10.Text = process.StandardOutput.ReadToEnd();
                    console.Text = process.StandardOutput.ReadToEnd();
                    if (label10.Text == "")
                    {
                        label9.Visible = false;
                        label10.Text = "Cihaz Bağlı Değil";
                    }
                    else
                    {
                        label9.Visible = true;
                        pictureBox1.Visible = true;
                        label10.Visible = true;
                        pictureBox1.BackColor = Color.Aqua;

                    }

                }
            }
            else
            {
                pictureBox1.BackColor = Color.Blue;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;

            }
        }

        private void cihazadi_detecter_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (console.Text == "")
            {

                MessageBox.Show("Kopyalanacak bir metin bulunmamaktadır.", "Uyarı");
            }
            else
            {
                Clipboard.SetText(console.Text);

                button4.Text = "Kopyalandı";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            console.Clear();
            button4.Text = "Kopyala";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("FastBoot Mod Gereklidir. ", "Uyarı");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " oem writecid" + " " + cidDegistirTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
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

        private void button35_Click(object sender, EventArgs e)
        {
            imeiwritefastbootTextBox.Clear();

        }

        private void button38_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("Dikkat ! Sadece Original IMEI Numaranızı yazınız. Yasa Dışı yapılacak işlemlerden kullanıcı sorumludur", "DIKKAT !");
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
            if (pictureBox1.BackColor != Color.Blue)
            {
                MessageBox.Show("Lütfen cihazınızı TWRP Recovery'e alınız.");
            }
            else
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { }

        private void button12_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void systemcheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase system";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase boot";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase recovery";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase oem";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase persist";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase ddr";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase splash";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
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
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase aboot";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase misc";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız. !", "Uyarı");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase userdata";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click_2(object sender, EventArgs e)
        {

        }

        private void button32_Click_1(object sender, EventArgs e)
        {

        }

        private void button28_MouseHover(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

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
            startInfo.Arguments = "shell am start -a android.intent.action.CALL -d tel:" + araTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
        }

        private void araTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen cihazınızı FastBoot Mode Alınız.");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.WindowStyle =
                ProcessWindowStyle.Minimized;
                p.StartInfo.FileName = "oemsorgula2.bat";
                p.Start();
                p.WaitForExit();
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Aqua)
            {
                MessageBox.Show("Lütfen cihazınızı FastBoot Mode Alınız.");
            }
            if (pictureBox1.BackColor == Color.Aqua)
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
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor != Color.Blue)
            {
                MessageBox.Show("Lütfen cihazı TWRP Recovery Mode alınız", "Uyarı");
            }
            else
            {
                Process process = new Process();
                MessageBox.Show("TWRP'de Gelişmiş > ADB SideLoad Etkinleştirin.");
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "desenkilidikir.bat";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = "reboot bootloader";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();

            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = "reboot bootloader";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
                if (pictureBox1.BackColor != Color.Aqua && pictureBox1.BackColor != Color.Blue)
                {
                    MessageBox.Show("Cihazınızı lütfen bir Erişim Moduna Alınız(ADB veya FastBoot)", "Uyarı");
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = "reboot";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (pictureBox1.BackColor == Color.Aqua)
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
                if (pictureBox1.BackColor != Color.Aqua && pictureBox1.BackColor != Color.Blue)
                {
                    MessageBox.Show("Cihazınızı lütfen bir Erişim Moduna Alınız(ADB veya FastBoot)", "Uyarı");
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c" + " dd if=" + partyukleTextBox.Text + " " + "of=/sdcard/yedekalindi.img bs=4096";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("Partition bilgilerini doğru girdiyseniz 'yedekalindi.img' dosyası cihaz hafızasında olacaktır", "Bilgilendirme");
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Lütfen cihazı ADB Mod'a alınız.", "Uyarı");
            }

        }

        private void button31_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "APK Dosyası|*.APK";
            openfile.Title = ".APK Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                adbyukleTextBox.Text = openfile.FileName;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " install " + adbyukleTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "ZIP Dosyası|*.ZIP";
            openfile.Title = ".ZIP Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                zipyukleTextBox.Text = openfile.FileName;
            }
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " sideload " + zipyukleTextBox.Text;
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls /dev/block";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }

            if (comboBox4.SelectedIndex == 1) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell cat /proc/partitions";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox4.SelectedIndex == 2) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell ls /dev/block/platforms";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (comboBox4.SelectedIndex == 3) // İlk Menü Seçiliyse
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c ls -l /dev/block/bootdevice";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {

            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c setprop persist.system.at-proxy.mode 2";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = "KONTROL EDINIZ.";
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {

            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = " shell su -c setprop sys.usb.config diag,adb";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "AYGIT YONETICISINI KONTROL EDINIZ.";
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        { }

        private void button41_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /system/etc/mddb C:/DosyaCek";
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

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /system/build.prop C:/DosyaCek";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (comboBox5.SelectedIndex == 0) // İlk Menü Seçiliyse
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
                    if (pictureBox1.BackColor != Color.Aqua)
                    {
                        MessageBox.Show("Fastboot cihaz algılanmadı.", "Uyarı");
                    }
                }

                if (comboBox5.SelectedIndex == 1) //fastboot flash
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
                    if (comboBox5.SelectedIndex == 2) //fastboot boot
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
                    if (comboBox5.SelectedIndex == 3) //fastboot recovery
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
                    if (comboBox5.SelectedIndex == 4) //fastboot OEM
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
                    if (comboBox5.SelectedIndex == 5) //fastboot Persist
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
                    if (comboBox5.SelectedIndex == 6) //fastboot UserData
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
            else
            {
                MessageBox.Show("Lütfen cihazınızı FastBoot Mode Alınız", "Uyarı");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Directory.CreateDirectory("C:/DosyaCek");
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button51_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button54_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button52_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button49_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " -w";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:1";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button45_Click(object sender, EventArgs e)
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

        private void button46_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = " 0x2a96 erase config";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void SetForegroundWindow(IntPtr h)
        {
            throw new NotImplementedException();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AÇILAN PENCEREDE LOG ALMA ISLEMI BASLAYACAKTIR. BELLI BIR SURE SONRA KAPATINIZ. LOG KONSOL ICINDE OLACAKTIR", "UYARI");
            console.Clear();
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
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (comboBox6.SelectedIndex == 0) // İlk Menü Seçiliyse
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

                if (comboBox6.SelectedIndex == 1) //fastboot flash
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
            else
            {
                MessageBox.Show("Lütfen cihazı FastBoot Mode Alınız", "Uyarı");
            }




        }

        private void button24_Click_1(object sender, EventArgs e)
        { }

        private void button22_Click_1(object sender, EventArgs e)
        { }

        private void button25_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Sunucularımızda Sorun Olduğundan dolayı gerçekleştiremiyoruz.","Info");
            /*WebClient driver = new WebClient();
            driver.DownloadFileAsync(new Uri(textBox333.Text), Application.StartupPath + @"\" + comboBox8.Text + ".zip");
            driver.DownloadFileCompleted += driver_DownloadFileCompleted;
            driver.DownloadProgressChanged += driver_DownloadProgressChanged;*/
        }
        void driver_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

        }
        void driver_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Directory.CreateDirectory("C:/DosyaCek");
            string myPath = Application.ExecutablePath;
            string myPath2 = Application.StartupPath;
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath2;
            prc.Start();


        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            console.Clear();
            console.Text = "MOTO Ve SAMSUNG Cihazlarda ADB Diğer cihazlarda FASTBOOT Mode Gereklidir!\n ForumAndroid Barış MIZRAKLI";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void button60_Click(object sender, EventArgs e)
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
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                MessageBox.Show("Cihazın Fastboot Mod'a Alındığından Emin Olun.", "Uyarı !");
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Cihazı fastboot mode alınız", "Uyarı");
            }
        }

        private void button62_Click(object sender, EventArgs e)
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

        private void button61_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
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
            else
            {
                MessageBox.Show("Cihazı FastBoot Mode Alınız", "Uyarı");
            }

        }

        private void linkLabel3_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.instagram.com/baris.mizrakli");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "port\\cleanup.bat";
                process.StartInfo = startInfo;
                process.Start();

                Process process2 = new Process();
                ProcessStartInfo startInfo2 = new ProcessStartInfo();
                startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo2.CreateNoWindow = true;
                startInfo2.UseShellExecute = false;
                startInfo2.RedirectStandardOutput = true;
                startInfo2.FileName = "stock\\cleanup.bat";
                process2.StartInfo = startInfo2;
                process2.Start();
            }
            Application.Exit();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            console.Clear();
            {
                {

                    {

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
                        if (label10.Text != "Cihaz Bağlı Değil")
                        {
                            Process aprocess = new Process();
                            Process aprocess2 = new Process();
                            Process aprocess3 = new Process();
                            Process process4 = new Process();
                            Process process5 = new Process();
                            Process process6 = new Process();
                            Process process7 = new Process();
                            Process process8 = new Process();
                            Process process9 = new Process();
                            Process process10 = new Process();
                            Process process11 = new Process();
                            Process process12 = new Process();
                            ProcessStartInfo astartInfo = new ProcessStartInfo();
                            ProcessStartInfo astartInfo2 = new ProcessStartInfo();
                            ProcessStartInfo astartInfo3 = new ProcessStartInfo();
                            ProcessStartInfo startInfo4 = new ProcessStartInfo();
                            ProcessStartInfo startInfo5 = new ProcessStartInfo();
                            ProcessStartInfo startInfo6 = new ProcessStartInfo();
                            ProcessStartInfo startInfo7 = new ProcessStartInfo();
                            ProcessStartInfo startInfo8 = new ProcessStartInfo();
                            ProcessStartInfo startInfo9 = new ProcessStartInfo();
                            ProcessStartInfo startInfo10 = new ProcessStartInfo();
                            ProcessStartInfo startInfo11 = new ProcessStartInfo();
                            ProcessStartInfo startInfo12 = new ProcessStartInfo();
                            astartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo5.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo6.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo7.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo8.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo9.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo10.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo11.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo12.WindowStyle = ProcessWindowStyle.Hidden;
                            astartInfo.CreateNoWindow = true;
                            astartInfo2.CreateNoWindow = true;
                            astartInfo3.CreateNoWindow = true;
                            startInfo4.CreateNoWindow = true;
                            startInfo5.CreateNoWindow = true;
                            startInfo6.CreateNoWindow = true;
                            startInfo7.CreateNoWindow = true;
                            startInfo8.CreateNoWindow = true;
                            startInfo9.CreateNoWindow = true;
                            startInfo10.CreateNoWindow = true;
                            startInfo11.CreateNoWindow = true;
                            startInfo12.CreateNoWindow = true;
                            astartInfo.UseShellExecute = false;
                            astartInfo2.UseShellExecute = false;
                            astartInfo3.UseShellExecute = false;
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
                            astartInfo.RedirectStandardOutput = true;
                            astartInfo2.RedirectStandardOutput = true;
                            astartInfo3.RedirectStandardOutput = true;
                            startInfo4.RedirectStandardOutput = true;
                            startInfo5.RedirectStandardOutput = true;
                            startInfo6.RedirectStandardOutput = true;
                            startInfo7.RedirectStandardOutput = true;
                            startInfo8.RedirectStandardOutput = true;
                            startInfo9.RedirectStandardOutput = true;
                            startInfo10.RedirectStandardOutput = true;
                            startInfo11.RedirectStandardOutput = true;
                            startInfo12.RedirectStandardOutput = true;
                            astartInfo.FileName = "adb.exe";
                            astartInfo2.FileName = "adb.exe";
                            astartInfo3.FileName = "adb.exe";
                            startInfo4.FileName = "adb.exe";
                            startInfo5.FileName = "adb.exe";
                            startInfo6.FileName = "adb.exe";
                            startInfo7.FileName = "adb.exe";
                            startInfo8.FileName = "adb.exe";
                            startInfo9.FileName = "adb.exe";
                            startInfo10.FileName = "adb.exe";
                            startInfo11.FileName = "adb.exe";
                            startInfo12.FileName = "adb.exe";
                            astartInfo.Arguments = " shell getprop ro.product.model";
                            astartInfo2.Arguments = " shell getprop ro.product.manufacturer";
                            astartInfo3.Arguments = " shell getprop ro.build.version.release";
                            startInfo4.Arguments = " shell getprop ro.product.device";
                            startInfo5.Arguments = " shell getprop ro.product.brand";
                            startInfo6.Arguments = "shell getprop ro.build.id";
                            startInfo7.Arguments = "shell getprop ro.build.version.sdk";
                            startInfo8.Arguments = "shell getprop ro.build.version.codename";
                            startInfo9.Arguments = "shell getprop ro.build.version.all_codenames";
                            startInfo10.Arguments = "shell getprop ro.build.version.security_patch";
                            startInfo11.Arguments = "shell getprop ro.product.locale";
                            startInfo12.Arguments = " shell su -v ";
                            aprocess.StartInfo = astartInfo;
                            aprocess2.StartInfo = astartInfo2;
                            aprocess3.StartInfo = astartInfo3;
                            process4.StartInfo = startInfo4;
                            process5.StartInfo = startInfo5;
                            process6.StartInfo = startInfo6;
                            process7.StartInfo = startInfo7;
                            process8.StartInfo = startInfo8;
                            process9.StartInfo = startInfo9;
                            process10.StartInfo = startInfo10;
                            process11.StartInfo = startInfo11;
                            process12.StartInfo = startInfo12;
                            aprocess.Start();
                            aprocess2.Start();
                            aprocess3.Start();
                            process4.Start();
                            process5.Start();
                            process6.Start();
                            process7.Start();
                            process8.Start();
                            process9.Start();
                            process10.Start();
                            process11.Start();
                            process12.Start();
                            /* console.Text = console.Text + "Marka = " + aprocess2.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Android Versiyon = " + aprocess3.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd() + "\n";
                             console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd() + "\n";*/
                            //console.Text = console.Text + "Marka = " + aprocess2.StandardOutput.ReadToEnd() + "\n";
                            label24.Text = aprocess2.StandardOutput.ReadToEnd();
                            //  label24.Text =aprocess2.StandardOutput.ReadToEnd();
                            //   console.Text = console.Text + "Model = " + aprocess.StandardOutput.ReadToEnd() + "\n";
                            label25.Text = aprocess.StandardOutput.ReadToEnd() + "\n";

                            // console.Text = console.Text + "Android Versiyon = " + aprocess3.StandardOutput.ReadToEnd() + "\n";
                            label26.Text = aprocess3.StandardOutput.ReadToEnd() + "\n";
                            //console.Text = console.Text + "Kod Adı  = " + process4.StandardOutput.ReadToEnd() + "\n";
                            label27.Text = process4.StandardOutput.ReadToEnd() + "\n";
                            //console.Text = console.Text + "Üretici = " + process5.StandardOutput.ReadToEnd() + "\n";
                            label28.Text = process5.StandardOutput.ReadToEnd() + "\n";
                            //console.Text = console.Text + "Compilation Code = " + process6.StandardOutput.ReadToEnd() + "\n";
                            label29.Text = process6.StandardOutput.ReadToEnd() + "\n";
                            //console.Text = console.Text + "SDK Numarası = " + process7.StandardOutput.ReadToEnd() + "\n";
                            label30.Text = process7.StandardOutput.ReadToEnd() + "\n";
                            // console.Text = console.Text + "Code Versiyon 1 = " + process8.StandardOutput.ReadToEnd() + "\n";
                            label31.Text = process8.StandardOutput.ReadToEnd() + "\n";
                            // console.Text = console.Text + "Code Versiyon 2 = " + process9.StandardOutput.ReadToEnd() + "\n";
                            label32.Text = process9.StandardOutput.ReadToEnd() + "\n";
                            //  console.Text = console.Text + "Güvenlik Yaması Tarihi = " + process10.StandardOutput.ReadToEnd() + "\n";
                            label33.Text = process10.StandardOutput.ReadToEnd() + "\n";
                            //   console.Text = console.Text + "Dil ve Ülke = " + process11.StandardOutput.ReadToEnd() + "\n";
                            label34.Text = process11.StandardOutput.ReadToEnd() + "\n";

                        }


                        if (label8.Text == "")
                        {
                            pictureBox1.BackColor = Color.Red;
                            label10.Text = "Cihaz Bağlı Değil";
                            label9.Visible = false;
                            label8.Visible = false;
                            label11.Visible = false;
                            label12.Visible = false;
                            label13.Visible = false;
                            if (label10.Text == "Cihaz Bağlı Değil")
                            {
                                Process process4 = new Process();
                                ProcessStartInfo startInfo4 = new ProcessStartInfo();
                                startInfo4.WindowStyle = ProcessWindowStyle.Hidden;
                                startInfo4.CreateNoWindow = true;
                                startInfo4.UseShellExecute = false;
                                startInfo4.RedirectStandardOutput = true;
                                startInfo4.FileName = "fastboot.exe";
                                startInfo4.Arguments = "devices";
                                process.StartInfo = startInfo4;
                                process.Start();
                                label10.Text = process.StandardOutput.ReadToEnd();
                                console.Text = process.StandardOutput.ReadToEnd();
                                if (label10.Text == "")
                                {
                                    label9.Visible = false;
                                    label10.Text = "Cihaz Bağlı Değil";
                                }
                                else
                                {
                                    label9.Visible = true;
                                    pictureBox1.Visible = true;
                                    label10.Visible = true;
                                    pictureBox1.BackColor = Color.Aqua;

                                }

                            }
                        }
                        else
                        {
                            pictureBox1.BackColor = Color.Blue;
                            label8.Visible = true;
                            label9.Visible = true;
                            label10.Visible = true;
                            label11.Visible = true;
                            label12.Visible = true;
                            label13.Visible = true;

                        }
                    }
                }

            }
        }






        private void button58_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Imaj Dosyası|*.img";
            openfile.Title = "Recovery.img Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                recoveryislemleriTextBox.Text = openfile.FileName;
            }
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            MessageBox.Show("TWRP'de Gelişmiş > ADB SideLoad Etkinleştirin.");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "desenkilidikir.bat";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:0";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void button64_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " shell content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:1";
            process.StartInfo = startInfo;
            process.Start();
            console.Clear();
            console.Text = "Yargı tamamlandı. ! ";
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "FirmWare Developer";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

        }

        private void button65_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
                this.Show();
            }
        }

        private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "reboot";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void rebootRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "reboot recovery";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void rebootEDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "reboot bootloader";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = "reboot edl";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void rebootToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = "reboot";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void rebootBootloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = "reboot bootloader";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void rebootEDLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = "oem edl";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void oEMUnlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = "oem unlock-go";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void oEMLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = "oem lock";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void cut_Click(object sender, EventArgs e)
        {

            //Bitmap bitmap = new Bitmap(this.Width, this.Height);
            //DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, Height));
            Bitmap FormScreenShot = new Bitmap(this.Width, this.Height);

            Graphics G = Graphics.FromImage(FormScreenShot);

            G.CopyFromScreen(this.Location, new Point(0, 0), this.Size);

            Clipboard.SetImage(FormScreenShot);
            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.
            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            sfd.FileName = "resim";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                FormScreenShot.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
            }

        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void cut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cut, "Sadece Tool'un Ekran Alıntısını Alabilirsiniz");
            toolTip1.ToolTipTitle = "Ekran Alıntısı Al";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu



        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Cihazı Yeniden Başlatma İşlevleri";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "ADB Reboot= " + toolTip1.ToolTipTitle;

        }

        private void button66_Click(object sender, EventArgs e)
        {
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Cihazı Yeniden Başlatma İşlevleri";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "FastBoot Reboot= " + toolTip1.ToolTipTitle;

        }

        private void button32_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button32, "Hızlıca Arama Yap");
            toolTip1.ToolTipTitle = "Fast Call (Hızlı Arama)";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "Arama = " + toolTip1.ToolTipTitle;

        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Root Kontrol";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "Root  = " + toolTip1.ToolTipTitle;


        }

        private void button36_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button36_MouseHover(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Sadece ADB SideLoad Mod içindir.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "Root = " + toolTip1.ToolTipTitle;

        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button12, "ADB'yi Başlat");
            toolTip1.ToolTipTitle = "ADB Başlatma Butonu";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button11, "ADB'yi Kapat");
            toolTip1.ToolTipTitle = "ADB Kapatma Butonu";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button4, "Metni Kopyala");
            toolTip1.ToolTipTitle = "Console Kopyalama İşlevi";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button5, "Metni Temizle");
            toolTip1.ToolTipTitle = "Console Temizleme İşlevi";

            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
        }

        private void button26_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Sadece ADB SideLoad Mod'da Çalışır.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "Unlock = " + toolTip1.ToolTipTitle;

        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "Sadece ADB SideLoad Mod'da Çalışır.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button6, "HTC Cihazlara Özeldir");
            toolTip1.ToolTipTitle = "HTC Cihazların Tamirini Buradan Yapabilirsiniz.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "HTC= " + toolTip1.ToolTipTitle;


        }

        private void cidDegistirTextBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cidDegistirTextBox, "Cid Numarsı Yazma");
            toolTip1.ToolTipTitle = "Cihaza Cid Numarasını Yazabilirsiniz.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void imeiwritefastbootTextBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(imeiwritefastbootTextBox, "Lütfen Orijinal IMEI Numaranızı Kullanınız !");
            toolTip1.ToolTipTitle = "IMEI Writer";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Cihazın Bağlı Olup Olmadığını Sorgulamak için Tıklayın.");
            toolTip1.ToolTipTitle = "Cihaz Algılayıcıyı";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;

        }

        private void linkLabel3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(linkLabel3, "Geliştirici ile İletişime Geçmek İçin Tıklayın");
            toolTip1.ToolTipTitle = "FirmWare Developer";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "Barış MIZRAKLI  = " + toolTip1.ToolTipTitle;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //0x2C Print Screen
            //0x1B for ESC

            if (GetAsyncKeyState(0x2C) != 0)
            {
                //Bitmap bitmap = new Bitmap(this.Width, this.Height);
                //DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, Height));
                Bitmap FormScreenShot = new Bitmap(this.Width, this.Height);

                Graphics G = Graphics.FromImage(FormScreenShot);

                G.CopyFromScreen(this.Location, new Point(0, 0), this.Size);

                Clipboard.SetImage(FormScreenShot);
                SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.
                sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

                sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

                sfd.FileName = "resim";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

                DialogResult sonuç = sfd.ShowDialog();

                if (sonuç == DialogResult.OK)
                {
                    FormScreenShot.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.
                }
                if (GetAsyncKeyState(0x1B) != 0)
                {
                    Application.Exit();
                }
            }
        }

        private void menüyüGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel4_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "FirmWare Developer";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "Emre Can Ayas  = " + toolTip1.ToolTipTitle;
        }

        private void button32_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, "Cihaz Denetleme");
            toolTip1.ToolTipTitle = "Kırmızı Olduğunda Kapalı, Mavi Olduğunda ADB, Turkuaz Olduğunda FastBoot Mod'dasınızdır.";
            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            if (pictureBox1.BackColor == Color.Red)
            {
                info.BackColor = Color.Red;
                info.Text = "Şu An Cihazınız Bağlı Değil";
                info.ForeColor = Color.Bisque;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                info.BackColor = Color.Aqua;
                info.Text = "Şu An Cihazınız FastBoot Moddadır.";
                info.ForeColor = Color.Black;

            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                info.BackColor = Color.Blue;
                info.Text = "Şu An Cihazınız ADB Moddadır.";
            }

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label9, "Cihaz Denetleme");
            toolTip1.ToolTipTitle = "Cihaz Markasını Gösterir";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label11, "Cihaz Denetleme");
            toolTip1.ToolTipTitle = "Cihaz Modelini Gösterir";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label12, "Cihaz Denetleme");
            toolTip1.ToolTipTitle = "Cihaz Android Sürümünü Gösterir";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button7, "Cid Numarsı Yazma");
            toolTip1.ToolTipTitle = "Cihaza Cid Numarasını Yazabilirsiniz.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button8_MouseEnter_1(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "ADB Mod'u Başlatırsınız.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "ADB Mod'u Kapatırsınız.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button38_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button38, "Lütfen Orijinal IMEI Numaranızı Kullanınız !");
            toolTip1.ToolTipTitle = "IMEI Writer";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button35_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button35, "Temizle !");
            toolTip1.ToolTipTitle = "IMEI Yazma Kutucuğunu Temizlersiniz.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void comboBox7_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "OEM Kilidini Açar veya Kapatırsınız.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button24_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.ToolTipTitle = "OEM Kilidini Açar veya Kapatırsınız.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }



        private void button28_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                toolTip1.ToolTipTitle = "Cihazı Yeniden Başlatırsınız ancak Cihaz Algılanamıyor. Güncellemeyi Deneyiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                toolTip1.ToolTipTitle = "Cihazınız FastBoot Mod'da ve Normal Olarak Açabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                toolTip1.ToolTipTitle = "Cihazınız ADB Mod'da ve Normal Olarak Açabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
        }

        private void button27_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                toolTip1.ToolTipTitle = "Cihazı FastBoot Mode Alırsınız ancak Cihaz Algılanamıyor. Güncellemeyi Deneyiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                toolTip1.ToolTipTitle = "Cihazınız FastBoot Mod'da ve FastBoot Mode tekrar alabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                toolTip1.ToolTipTitle = "Cihazınız ADB Mod'da  ve FastBoot Mode Alabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
        }

        private void button42_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                toolTip1.SetToolTip(button42, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz. Ancak cihazınız algılanamıyor.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                toolTip1.SetToolTip(button42, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihazınız FastBoot Mod'da ve Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz..";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                toolTip1.SetToolTip(button42, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihazınız ADB Mod'da, FastBoot Mode alarak Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
        }

        private void comboBox5_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                toolTip1.SetToolTip(comboBox5, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz. Ancak cihazınız algılanamıyor.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                toolTip1.SetToolTip(comboBox5, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihazınız FastBoot Mod'da ve Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz..";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                toolTip1.SetToolTip(comboBox5, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihazınız ADB Mod'da, FastBoot Mode alarak Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
        }

        private void button58_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button58, "FastBoot üzerinden Yükleme Yap");
            toolTip1.ToolTipTitle = "Cihaza Yüklemek için bir Recovery Seçiniz.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void comboBox6_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(comboBox6, "FastBoot üzerinden Yükleme Yap");
            toolTip1.ToolTipTitle = "Cihaza Yüklemek için bir Recovery Biçimi Seçiniz.";

            toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
            info.Text = "İşlev = " + toolTip1.ToolTipTitle;
        }

        private void button57_MouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Red)
            {
                toolTip1.SetToolTip(button57, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz. Ancak cihazınız algılanamıyor.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                toolTip1.SetToolTip(button57, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihazınız FastBoot Mod'da ve Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz..";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                toolTip1.SetToolTip(button57, "FastBoot üzerinden Yükleme Yap");
                toolTip1.ToolTipTitle = "Cihazınız ADB Mod'da, FastBoot Mode alarak Cihaza FastBoot üzerinden Yükleme Yapabilirsiniz.";

                toolTip1.ToolTipIcon = ToolTipIcon.Info; //Bilgilendirme İconu
                info.Text = "İşlev = " + toolTip1.ToolTipTitle;
            }
        }

        private void adbyukleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void geliştiricilerBarışMIZRAKLIEmreCanAYASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.forumandroid.com/");
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (normalrebootradiobuton.Checked == true)
            {
                if (pictureBox1.BackColor == Color.Blue)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "adb.exe";
                    startInfo.Arguments = "reboot";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else if (pictureBox1.BackColor == Color.Aqua)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = "reboot";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else
                {
                    MessageBox.Show("Cihazınızda Reboot işlevini gerçekleştirmek için tool ile bağlantısını sağlamalısınız","Uyarı");
                }
            }
            if (rebootrecoveryradiobuton.Checked == true)
            {
                if (pictureBox1.BackColor == Color.Blue)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "adb.exe";
                    startInfo.Arguments = "reboot recovery";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else
                {

                }
            }//adb reboot recovery
            else if (pictureBox1.BackColor == Color.Aqua)
            {
                MessageBox.Show("Fastboot modundan manuel olarak recovery'e geçiş yapabilirsiniz.","Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Cihazınızda Reboot işlevini gerçekleştirmek için tool ile bağlantısını sağlamalısınız", "Uyarı");

            }
            if (rebootbootloaderradiobuton.Checked == true)
            {
                if (pictureBox1.BackColor == Color.Blue)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "adb.exe";
                    startInfo.Arguments = "reboot bootloader";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else if (pictureBox1.BackColor == Color.Aqua)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = "reboot bootloader";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else
                {
                    MessageBox.Show("Cihazınızda Reboot işlevini gerçekleştirmek için tool ile bağlantısını sağlamalısınız", "Uyarı");

                }
            }
            if (rebootedlradiobuton.Checked == true)
            {
                if (pictureBox1.BackColor == Color.Blue)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "adb.exe";
                    startInfo.Arguments = "reboot edl";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else if (pictureBox1.BackColor == Color.Aqua)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = "oem edl";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else
                {

                }
            }
            if (rebootdownloadsamsungradiobuton.Checked == true)
            {
                if (pictureBox1.BackColor == Color.Blue)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "adb.exe";
                    startInfo.Arguments = "reboot download mode";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                else
                {

                }
            }

        }

        private void button60_Click_1(object sender, EventArgs e)
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
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = textBox1.Text;
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Lütfen Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız","Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " oem writecid HTC__M27";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
	        {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " getvar modelid";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " getvar cid";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
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
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " oem writemid " + midTextBox.Text;
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.htcdev.com");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.htcdev.com");

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " oem get_identifier_token";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (oemacradiobuton.Checked == true)
                {
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
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    console.Text = "İşlem tamam. Kontrollerinizi Sağlayınız.";
                }
                if (oemkapatradiobuton.Checked == true)
                {
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
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    console.Text = "İşlem tamam. Kontrollerinizi Sağlayınız.";

                }

            }
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");
            }
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (oemacradiobuton.Checked == true)
                {
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
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    console.Text = "İşlem tamam. Kontrollerinizi Sağlayınız.";
                }
                if (oemkapatradiobuton.Checked == true)
                {
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
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    console.Text = "İşlem tamam. Kontrollerinizi Sağlayınız.";

                }

            }
            else
            {
                MessageBox.Show("Cihazınızı FastBoot Mode Alınız", "Uyarı");

            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Black)
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
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " reboot bootloader";
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            else
            {
                MessageBox.Show("Program cihazınız ile bağlantı kurmadı.","USB Kablosunu Takınız !");
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {

            {
                if (pictureBox1.BackColor == Color.Black)
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
                if (pictureBox1.BackColor == Color.Aqua)
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
                else
                {
                    MessageBox.Show("Program cihazınız ile bağlantı kurmadı.", "USB Kablosunu Takınız !");
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (radioButton9.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase system";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton10.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase boot";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton11.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase recovery";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton12.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase oem";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton13.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase persist";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton14.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase ddr";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton15.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase splash";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton16.Checked == true)
                {
                    Process process = new Process();
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
                if (radioButton16.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase aboot";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }//userdata cust modem
                if (radioButton17.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase userdata";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton17.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase cust";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
                if (radioButton18.Checked == true)
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.CreateNoWindow = true;
                    startInfo.UseShellExecute = false;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.FileName = "fastboot.exe";
                    startInfo.Arguments = " erase vendor";
                    process.StartInfo = startInfo;
                    process.Start();
                    console.Text = console.Text + process.StandardOutput.ReadToEnd();
                }
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazı FastBoot Moduna Alınız","Uyarı");
            }
            else
            {
                MessageBox.Show("Cihazınız Algılanamıyor.","Uyarı");
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase " + fastbooteraseTextBox.Text;
                process.StartInfo = startInfo;
                process.Start();
                console.Text = console.Text + process.StandardOutput.ReadToEnd();
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınız ADB Mod'dadır. İşlevi gerçekleştirmek için FastBoot (BootLoader) Mode Geçiniz","Bilgilendirme Kutucuğu");
            }
            else
            {
                MessageBox.Show("Program Cihazınızı Algılamadı.","Bilgilendirme Kutucuğu");
            }
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            fastbooteraseTextBox.Clear();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            console.Text = "Bu bölümde partition silme işlevi yapılır. Soldan silmek istediğiniz partitionu seçiniz ardından resime tıklayınız. Özel olarak partition adı girerek te sıfırlama yapabilirsiniz.";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button16.Text = textBox3.Text + "'i Flashla";
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Seçiniz > |*";
            openfile.Title = "Dosyanızı Seçiniz";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openfile.FileName;
                label23.Text = "Durum : Dosyanız Seçildi.";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (button16.Text != "Yükle")
                {
                    if (textBox4.Text != "Seçim Bekleniyor:..  <")
                    {
                        Process process = new Process();
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        startInfo.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo.RedirectStandardOutput = true;
                        startInfo.FileName = "fastboot.exe";
                        startInfo.Arguments = " flash " + textBox3.Text + " " + textBox2.Text;
                        process.StartInfo = startInfo;
                        process.Start();
                        console.Text = console.Text + process.StandardOutput.ReadToEnd();
                    }

                }
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode alınız.","Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Cihazınız Program İle Bağlantı Kurmadı","Hata");
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Seçiniz > |*";
            openfile.Title = "Dosyanızı Seçiniz";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openfile.FileName;
                label23.Text = "Durum : Dosyanız Seçildi.";
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                if (button17.Text == "Yükle")
                {
                    if (textBox4.Text != "Seçim Bekleniyor:..  <")
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Process process = new Process();
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo.CreateNoWindow = true;
                            startInfo.UseShellExecute = false;
                            startInfo.RedirectStandardOutput = true;
                            startInfo.FileName = "fastboot.exe";
                            startInfo.Arguments = " boot " + textBox4.Text;
                            process.StartInfo = startInfo;
                            process.Start();
                            console.Text = console.Text + process.StandardOutput.ReadToEnd();
                        }
                        if (comboBox1.SelectedIndex == 0)
                        {
                            Process process = new Process();
                            ProcessStartInfo startInfo = new ProcessStartInfo();
                            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            startInfo.CreateNoWindow = true;
                            startInfo.UseShellExecute = false;
                            startInfo.RedirectStandardOutput = true;
                            startInfo.FileName = "fastboot.exe";
                            startInfo.Arguments = " flash recovery " + textBox4.Text;
                            process.StartInfo = startInfo;
                            process.Start();
                            console.Text = console.Text + process.StandardOutput.ReadToEnd();
                        }
                    }


                }
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                MessageBox.Show("Cihazınızı FastBoot Mode alınız.", "Bilgilendirme");
            }
            else
            {
                MessageBox.Show("Cihazınız Program İle Bağlantı Kurmadı", "Hata");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            console.Text = "Önce recovery dosyanızı seçiniz. Ardından tek seferlik ya da kalıcı recovery yüklemesini seçiniz. Kurulumu yapabilirsiniz.";
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "Seçim Bekleniyor:..  <";
            textBox4.Text = "Seçim Bekleniyor:..  <";
            label23.Text = "Durum : Dosya Seçimi Bekleniyor ...";
            comboBox1.Text = "Seçim Yapınız";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            console.Text = "Telefonunuzu Seviyorsanız Dikkat Ediniz.";
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " pull /oem C:/DosyaCek";
            process.StartInfo = startInfo;
            process.Start();
            console.Text = console.Text + process.StandardOutput.ReadToEnd();
            string myPath = @"C:/DosyaCek";
            System.Diagnostics.Process prc = new
            System.Diagnostics.Process();
            prc.StartInfo.FileName = myPath;
            prc.Start();
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Aqua)
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " erase config";
                process.StartInfo = startInfo;
                process.Start();
                console.Clear();
                console.Text = "Yargı tamamlandı. ! ";
            }
            if (pictureBox1.BackColor == Color.Blue)
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";
            }
            else
            {
                console.Text = "FastBoot Mode Cihazınızı Alınız";

            }
        }

        private void button24_Click_2(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "stock\\stock.bat";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "port\\port.bat";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button22_Click_2(object sender, EventArgs e)
        {
            File.Delete("port\\split_img\\recovery.img-zImage");
            File.Delete("port\\ramdisk\\fstab.qcom");
            File.Copy("stock\\split_img\\recovery.img-zImage", "port\\split_img\\recovery.img-zImage");
            File.Copy("stock\\ramdisk\\fstab.qcom", "port\\ramdisk\\fstab.qcom");
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "port\\repackimg.bat";
            process.StartInfo = startInfo;
            process.Start();
            Random rnd = new Random();
            rnd.Next(2544444);
            File.Copy("port\\image-new.img", "output\\" + textBox5.Text + ".img");
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            Process.Start("output");
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "port\\cleanup.bat";
            process.StartInfo = startInfo;
            process.Start();

            Process process2 = new Process();
            ProcessStartInfo startInfo2 = new ProcessStartInfo();
            startInfo2.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo2.CreateNoWindow = true;
            startInfo2.UseShellExecute = false;
            startInfo2.RedirectStandardOutput = true;
            startInfo2.FileName = "stock\\cleanup.bat";
            process2.StartInfo = startInfo2;
            process2.Start();
        }

        private void button26_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Recovery Dosyası|*.img";
            openfile.Title = ".img Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                kopyalanacakDosyaIsmi = openfile.SafeFileName.ToString();
                kopyalanacakDosya = openfile.FileName.ToString();
                recoveryoluTextBox.Text = kopyalanacakDosya;
                dosyanınKopyanacagiKlasor = Application.StartupPath.ToString();
                File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + "stock\\recovery.img");

            }
        }

        private void button25_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Recovery Dosyası|*.img";
            openfile.Title = ".img Seçiniz..";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                kopyalanacakDosyaIsmi = openfile.SafeFileName.ToString();
                kopyalanacakDosya = openfile.FileName.ToString();
                recoveryoluTextBox.Text = kopyalanacakDosya;
                dosyanınKopyanacagiKlasor = Application.StartupPath.ToString();
                File.Copy(kopyalanacakDosya, dosyanınKopyanacagiKlasor + "\\" + "port\\recovery.img");

            }
        }
    }
}







/*
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
*/





/*
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
            */
