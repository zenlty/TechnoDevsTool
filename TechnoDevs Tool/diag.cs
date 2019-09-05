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
    public partial class diag : Form
    {
        public diag()
        {
            InitializeComponent();
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
            startInfo.Arguments = " shell su -c setprop sys.usb.config diag,adb";
            process.StartInfo = startInfo;
            process.Start();
            Console.Text = "KONTROL EDINIZ.";
            Console.Text = Console.Text + process.StandardOutput.ReadToEnd();
            
        }
    }
}
