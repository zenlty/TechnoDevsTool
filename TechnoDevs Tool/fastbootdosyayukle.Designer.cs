namespace TechnoDevs_Tool
{
    partial class fastbootdosyayukle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fastbootdosyayukle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.console = new System.Windows.Forms.RichTextBox();
            this.flashsystemTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userdataflashTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.persistflashTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oemflashTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.recoveryflashTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flashbootTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FastBoot ToolKit";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Seçim Yapınız ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(6, 48);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "Seçimi Uygula";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.CornflowerBlue;
            this.console.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.console.ForeColor = System.Drawing.Color.Black;
            this.console.Location = new System.Drawing.Point(19, 224);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(711, 183);
            this.console.TabIndex = 11;
            this.console.Text = "Cihazın FastBoot Mod\'da Olduğundan Emin Olunuz ! >\n";
            // 
            // flashsystemTextbox
            // 
            this.flashsystemTextbox.Location = new System.Drawing.Point(94, 19);
            this.flashsystemTextbox.Name = "flashsystemTextbox";
            this.flashsystemTextbox.Size = new System.Drawing.Size(249, 23);
            this.flashsystemTextbox.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.userdataflashTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.persistflashTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.oemflashTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.recoveryflashTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.flashbootTextbox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.flashsystemTextbox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Candara", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(381, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 205);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dosya Yolları : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "UserData Flash";
            // 
            // userdataflashTextBox
            // 
            this.userdataflashTextBox.Location = new System.Drawing.Point(94, 149);
            this.userdataflashTextBox.Name = "userdataflashTextBox";
            this.userdataflashTextBox.Size = new System.Drawing.Size(249, 23);
            this.userdataflashTextBox.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Seçim Sonucu Otomatik Eklenir.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Persist Flash";
            // 
            // persistflashTextBox
            // 
            this.persistflashTextBox.Location = new System.Drawing.Point(94, 123);
            this.persistflashTextBox.Name = "persistflashTextBox";
            this.persistflashTextBox.Size = new System.Drawing.Size(249, 23);
            this.persistflashTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "OEM Flash";
            // 
            // oemflashTextBox
            // 
            this.oemflashTextBox.Location = new System.Drawing.Point(94, 97);
            this.oemflashTextBox.Name = "oemflashTextBox";
            this.oemflashTextBox.Size = new System.Drawing.Size(249, 23);
            this.oemflashTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Recovery Flash";
            // 
            // recoveryflashTextBox
            // 
            this.recoveryflashTextBox.Location = new System.Drawing.Point(94, 71);
            this.recoveryflashTextBox.Name = "recoveryflashTextBox";
            this.recoveryflashTextBox.Size = new System.Drawing.Size(249, 23);
            this.recoveryflashTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Boot Flash";
            // 
            // flashbootTextbox
            // 
            this.flashbootTextbox.Location = new System.Drawing.Point(94, 45);
            this.flashbootTextbox.Name = "flashbootTextbox";
            this.flashbootTextbox.Size = new System.Drawing.Size(249, 23);
            this.flashbootTextbox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "System Flash";
            // 
            // fastbootdosyayukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(753, 419);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.console);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fastbootdosyayukle";
            this.Text = "Fastboot Tool";
            this.Load += new System.EventHandler(this.fastbootdosyayukle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.TextBox flashsystemTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox persistflashTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oemflashTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox recoveryflashTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox flashbootTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userdataflashTextBox;
    }
}