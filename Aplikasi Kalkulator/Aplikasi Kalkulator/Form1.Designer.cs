namespace Aplikasi_Kalkulator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.operasi = new System.Windows.Forms.ComboBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.angka1 = new System.Windows.Forms.TextBox();
            this.angka2 = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NilaiB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // operasi
            // 
            this.operasi.FormattingEnabled = true;
            this.operasi.Location = new System.Drawing.Point(68, 17);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(121, 21);
            this.operasi.TabIndex = 4;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(68, 180);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // angka1
            // 
            this.angka1.Location = new System.Drawing.Point(68, 77);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(100, 20);
            this.angka1.TabIndex = 6;
            // 
            // angka2
            // 
            this.angka2.Location = new System.Drawing.Point(68, 110);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(100, 20);
            this.angka2.TabIndex = 7;
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(68, 145);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(100, 20);
            this.hasil.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Keluar";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 245);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox operasi;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox angka1;
        private System.Windows.Forms.TextBox angka2;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Button btnExit;
    }
}

