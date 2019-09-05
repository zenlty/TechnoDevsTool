namespace TechnoDevs_Tool
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button22 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.button25 = new System.Windows.Forms.Button();
            this.textBox333 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "Seçim Bekleniyor...";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(141, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "GSM Turkey Tool Update :>";
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.ForeColor = System.Drawing.Color.Red;
            this.button22.Location = new System.Drawing.Point(15, 62);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(70, 29);
            this.button22.TabIndex = 24;
            this.button22.Text = "Seç";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click_2);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "GSM Turkey Tool New Update"});
            this.comboBox8.Location = new System.Drawing.Point(15, 35);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(152, 21);
            this.comboBox8.TabIndex = 23;
            this.comboBox8.Text = "Seçim Yapınız >";
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.ForeColor = System.Drawing.Color.Red;
            this.button25.Location = new System.Drawing.Point(101, 62);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(66, 29);
            this.button25.TabIndex = 22;
            this.button25.Text = "İndir";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click_2);
            // 
            // textBox333
            // 
            this.textBox333.Location = new System.Drawing.Point(15, 140);
            this.textBox333.Name = "textBox333";
            this.textBox333.PasswordChar = '*';
            this.textBox333.Size = new System.Drawing.Size(45, 20);
            this.textBox333.TabIndex = 21;
            this.textBox333.Text = "URL";
            this.textBox333.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(152, 24);
            this.progressBar1.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(180, 171);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.textBox333);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "G";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox textBox333;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}