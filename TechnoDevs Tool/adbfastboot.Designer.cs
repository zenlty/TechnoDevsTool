namespace TechnoDevs_Tool
{
    partial class adbfastboot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adbfastboot));
            this.adbconsoleTextBox = new System.Windows.Forms.TextBox();
            this.fastbootconsoleTextBox = new System.Windows.Forms.TextBox();
            this.AdbConsole = new System.Windows.Forms.RichTextBox();
            this.FastbootConsole = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // adbconsoleTextBox
            // 
            this.adbconsoleTextBox.Location = new System.Drawing.Point(6, 74);
            this.adbconsoleTextBox.Name = "adbconsoleTextBox";
            this.adbconsoleTextBox.Size = new System.Drawing.Size(344, 20);
            this.adbconsoleTextBox.TabIndex = 1;
            this.adbconsoleTextBox.TextChanged += new System.EventHandler(this.adbconsoleTextBox_TextChanged);
            // 
            // fastbootconsoleTextBox
            // 
            this.fastbootconsoleTextBox.Location = new System.Drawing.Point(6, 74);
            this.fastbootconsoleTextBox.Name = "fastbootconsoleTextBox";
            this.fastbootconsoleTextBox.Size = new System.Drawing.Size(344, 20);
            this.fastbootconsoleTextBox.TabIndex = 3;
            this.fastbootconsoleTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AdbConsole
            // 
            this.AdbConsole.BackColor = System.Drawing.Color.Black;
            this.AdbConsole.ForeColor = System.Drawing.Color.Cyan;
            this.AdbConsole.Location = new System.Drawing.Point(433, 14);
            this.AdbConsole.Name = "AdbConsole";
            this.AdbConsole.Size = new System.Drawing.Size(365, 98);
            this.AdbConsole.TabIndex = 4;
            this.AdbConsole.Text = "ADB Console >\n\n";
            // 
            // FastbootConsole
            // 
            this.FastbootConsole.BackColor = System.Drawing.Color.Black;
            this.FastbootConsole.ForeColor = System.Drawing.Color.Cyan;
            this.FastbootConsole.Location = new System.Drawing.Point(433, 150);
            this.FastbootConsole.Name = "FastbootConsole";
            this.FastbootConsole.Size = new System.Drawing.Size(365, 100);
            this.FastbootConsole.TabIndex = 4;
            this.FastbootConsole.Text = "FastBoot Console >\n";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(356, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(356, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(287, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Fastboot Mod\'a Al";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(287, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Reboot System";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.adbconsoleTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADB Konsol >";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fastbootconsoleTextBox);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FastBoot Konsol >";
            // 
            // adbfastboot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(812, 280);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.FastbootConsole);
            this.Controls.Add(this.AdbConsole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adbfastboot";
            this.Text = "ADB & FastBoot >";
            this.Load += new System.EventHandler(this.adbfastboot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox adbconsoleTextBox;
        private System.Windows.Forms.TextBox fastbootconsoleTextBox;
        private System.Windows.Forms.RichTextBox AdbConsole;
        private System.Windows.Forms.RichTextBox FastbootConsole;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}