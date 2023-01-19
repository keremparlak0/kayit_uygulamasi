namespace KeremParlak
{
    partial class ana_sayfa
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
            this.kisi = new System.Windows.Forms.Button();
            this.ogrenci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kisi
            // 
            this.kisi.Location = new System.Drawing.Point(166, 124);
            this.kisi.Name = "kisi";
            this.kisi.Size = new System.Drawing.Size(182, 59);
            this.kisi.TabIndex = 0;
            this.kisi.Text = "Kişi";
            this.kisi.UseVisualStyleBackColor = true;
            this.kisi.Click += new System.EventHandler(this.kisi_Click);
            // 
            // ogrenci
            // 
            this.ogrenci.Location = new System.Drawing.Point(454, 124);
            this.ogrenci.Name = "ogrenci";
            this.ogrenci.Size = new System.Drawing.Size(182, 59);
            this.ogrenci.TabIndex = 0;
            this.ogrenci.Text = "Öğrenci";
            this.ogrenci.UseVisualStyleBackColor = true;
            this.ogrenci.Click += new System.EventHandler(this.ogrenci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(37, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİŞİ VE ÖĞRENCİ KAYIT ETME, SİLME VEYA GÜNCELLEME FORMU";
            // 
            // ana_sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(822, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ogrenci);
            this.Controls.Add(this.kisi);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ana_sayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kisi;
        private System.Windows.Forms.Button ogrenci;
        private System.Windows.Forms.Label label1;
    }
}

