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
/* DIZAYN
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * /*/
namespace TechnoDevs_Tool
{
    public partial class Form2 : Form
    {
        int mouseX = 0, mouseY = 0;
        bool mouseHareket;
        public Form2()
        {
            InitializeComponent();
        }
        /* DIZAYN*/

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseHareket = true;
        }
        /* DIZAYN*/

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseHareket)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        /* DIZAYN*/

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseHareket = false;
        }
        /* DIZAYN*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /* ÇIKIS*/
                this.Close();
            /* ÇIKIS*/
        }
        /* DIZAYN*/
        /*
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * /*/


        /*DEVICE KONTROL ADB VE FASTBOOT*/
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*KONSOL TEMİZLEME KOMUTU*/
            Console2.Clear();
            /*KONSOL TEMİZLEME KOMUTU*/
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = " devices -l";
            process.StartInfo = startInfo;
            process.Start();
            Console2.Text = Console2.Text + process.StandardOutput.ReadToEnd();
            /*DEVICE KONTROL ADB VE FASTBOOT*/
        }

        private void pictureBox4_Click(object sender, EventArgs e)
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
            Console2.Text = Console2.Text + process.StandardOutput.ReadToEnd();
        }
    }
}
