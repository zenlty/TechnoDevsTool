namespace TechnoDevs_Tool
{
    partial class diag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diag));
            this.button1 = new System.Windows.Forms.Button();
            this.Console = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "DIAG AÇ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.Black;
            this.Console.ForeColor = System.Drawing.Color.Aqua;
            this.Console.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Console.Location = new System.Drawing.Point(29, 83);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(509, 123);
            this.Console.TabIndex = 4;
            this.Console.Text = "\n\nROOT YETKISINE SAHIP OLMALISINIZ. BUTONA BASMADAN ÖNCE CIHAZI ADB MOD\'A ALIN.";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(178, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(360, 65);
            this.button3.TabIndex = 6;
            this.button3.Text = "Asus Virtual COM AÇ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // diag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(565, 223);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "diag";
            this.Text = "Port Açma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.Button button3;
    }
}