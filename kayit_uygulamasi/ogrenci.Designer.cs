namespace KeremParlak
{
    partial class ogrenci
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
            this.ogrenci_sil = new System.Windows.Forms.Button();
            this.ogrenci_guncelle = new System.Windows.Forms.Button();
            this.ogrenci_ekle = new System.Windows.Forms.Button();
            this.ogrenci_telefon_text = new System.Windows.Forms.TextBox();
            this.ogrenci_adSoyad_text = new System.Windows.Forms.TextBox();
            this.ogrenci_sinif = new System.Windows.Forms.Label();
            this.ogrenci_telefon = new System.Windows.Forms.Label();
            this.ogrenci_adSoyad = new System.Windows.Forms.Label();
            this.ogrenci_listele = new System.Windows.Forms.Button();
            this.ogrenci_liste = new System.Windows.Forms.DataGridView();
            this.ana_sayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ogrenci_sinif_cb = new System.Windows.Forms.ComboBox();
            this.ogrenci_id = new System.Windows.Forms.Label();
            this.ogrenci_id_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // ogrenci_sil
            // 
            this.ogrenci_sil.Location = new System.Drawing.Point(527, 190);
            this.ogrenci_sil.Name = "ogrenci_sil";
            this.ogrenci_sil.Size = new System.Drawing.Size(151, 31);
            this.ogrenci_sil.TabIndex = 14;
            this.ogrenci_sil.Text = "Sil";
            this.ogrenci_sil.UseVisualStyleBackColor = true;
            this.ogrenci_sil.Click += new System.EventHandler(this.ogrenci_sil_Click);
            // 
            // ogrenci_guncelle
            // 
            this.ogrenci_guncelle.Location = new System.Drawing.Point(340, 190);
            this.ogrenci_guncelle.Name = "ogrenci_guncelle";
            this.ogrenci_guncelle.Size = new System.Drawing.Size(151, 31);
            this.ogrenci_guncelle.TabIndex = 15;
            this.ogrenci_guncelle.Text = "Güncelle";
            this.ogrenci_guncelle.UseVisualStyleBackColor = true;
            this.ogrenci_guncelle.Click += new System.EventHandler(this.ogrenci_guncelle_Click);
            // 
            // ogrenci_ekle
            // 
            this.ogrenci_ekle.Location = new System.Drawing.Point(153, 190);
            this.ogrenci_ekle.Name = "ogrenci_ekle";
            this.ogrenci_ekle.Size = new System.Drawing.Size(151, 31);
            this.ogrenci_ekle.TabIndex = 16;
            this.ogrenci_ekle.Text = "Ekle";
            this.ogrenci_ekle.UseVisualStyleBackColor = true;
            this.ogrenci_ekle.Click += new System.EventHandler(this.ogrenci_ekle_Click);
            // 
            // ogrenci_telefon_text
            // 
            this.ogrenci_telefon_text.Location = new System.Drawing.Point(132, 74);
            this.ogrenci_telefon_text.Name = "ogrenci_telefon_text";
            this.ogrenci_telefon_text.Size = new System.Drawing.Size(153, 22);
            this.ogrenci_telefon_text.TabIndex = 11;
            // 
            // ogrenci_adSoyad_text
            // 
            this.ogrenci_adSoyad_text.Location = new System.Drawing.Point(132, 20);
            this.ogrenci_adSoyad_text.Name = "ogrenci_adSoyad_text";
            this.ogrenci_adSoyad_text.Size = new System.Drawing.Size(153, 22);
            this.ogrenci_adSoyad_text.TabIndex = 12;
            // 
            // ogrenci_sinif
            // 
            this.ogrenci_sinif.AutoSize = true;
            this.ogrenci_sinif.Location = new System.Drawing.Point(23, 132);
            this.ogrenci_sinif.Name = "ogrenci_sinif";
            this.ogrenci_sinif.Size = new System.Drawing.Size(32, 16);
            this.ogrenci_sinif.TabIndex = 8;
            this.ogrenci_sinif.Text = "Sınıf";
            // 
            // ogrenci_telefon
            // 
            this.ogrenci_telefon.AutoSize = true;
            this.ogrenci_telefon.Location = new System.Drawing.Point(23, 77);
            this.ogrenci_telefon.Name = "ogrenci_telefon";
            this.ogrenci_telefon.Size = new System.Drawing.Size(53, 16);
            this.ogrenci_telefon.TabIndex = 9;
            this.ogrenci_telefon.Text = "Telefon";
            // 
            // ogrenci_adSoyad
            // 
            this.ogrenci_adSoyad.AutoSize = true;
            this.ogrenci_adSoyad.Location = new System.Drawing.Point(23, 20);
            this.ogrenci_adSoyad.Name = "ogrenci_adSoyad";
            this.ogrenci_adSoyad.Size = new System.Drawing.Size(67, 16);
            this.ogrenci_adSoyad.TabIndex = 10;
            this.ogrenci_adSoyad.Text = "Ad Soyad";
            // 
            // ogrenci_listele
            // 
            this.ogrenci_listele.Location = new System.Drawing.Point(285, 313);
            this.ogrenci_listele.Name = "ogrenci_listele";
            this.ogrenci_listele.Size = new System.Drawing.Size(525, 43);
            this.ogrenci_listele.TabIndex = 7;
            this.ogrenci_listele.Text = "Listele";
            this.ogrenci_listele.UseVisualStyleBackColor = true;
            this.ogrenci_listele.Click += new System.EventHandler(this.ogrenci_listele_Click);
            // 
            // ogrenci_liste
            // 
            this.ogrenci_liste.AllowUserToAddRows = false;
            this.ogrenci_liste.AllowUserToDeleteRows = false;
            this.ogrenci_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenci_liste.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ogrenci_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenci_liste.Location = new System.Drawing.Point(1, 362);
            this.ogrenci_liste.Name = "ogrenci_liste";
            this.ogrenci_liste.ReadOnly = true;
            this.ogrenci_liste.RowHeadersWidth = 51;
            this.ogrenci_liste.RowTemplate.Height = 24;
            this.ogrenci_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ogrenci_liste.Size = new System.Drawing.Size(820, 234);
            this.ogrenci_liste.TabIndex = 6;
            this.ogrenci_liste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenci_liste_CellEnter);
            // 
            // ana_sayfa
            // 
            this.ana_sayfa.Location = new System.Drawing.Point(1, 602);
            this.ana_sayfa.Name = "ana_sayfa";
            this.ana_sayfa.Size = new System.Drawing.Size(178, 29);
            this.ana_sayfa.TabIndex = 17;
            this.ana_sayfa.Text = "Ana Sayfa";
            this.ana_sayfa.UseVisualStyleBackColor = true;
            this.ana_sayfa.Click += new System.EventHandler(this.ana_sayfa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(133, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "*Telefon kısmı boş kalabilir.";
            // 
            // ogrenci_sinif_cb
            // 
            this.ogrenci_sinif_cb.FormattingEnabled = true;
            this.ogrenci_sinif_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ogrenci_sinif_cb.Location = new System.Drawing.Point(132, 129);
            this.ogrenci_sinif_cb.Name = "ogrenci_sinif_cb";
            this.ogrenci_sinif_cb.Size = new System.Drawing.Size(152, 24);
            this.ogrenci_sinif_cb.TabIndex = 19;
            // 
            // ogrenci_id
            // 
            this.ogrenci_id.AutoSize = true;
            this.ogrenci_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_id.Location = new System.Drawing.Point(27, 325);
            this.ogrenci_id.Name = "ogrenci_id";
            this.ogrenci_id.Size = new System.Drawing.Size(28, 20);
            this.ogrenci_id.TabIndex = 20;
            this.ogrenci_id.Text = "ID";
            // 
            // ogrenci_id_text
            // 
            this.ogrenci_id_text.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ogrenci_id_text.Location = new System.Drawing.Point(73, 323);
            this.ogrenci_id_text.Name = "ogrenci_id_text";
            this.ogrenci_id_text.ReadOnly = true;
            this.ogrenci_id_text.Size = new System.Drawing.Size(171, 22);
            this.ogrenci_id_text.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(292, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kayıtlı verileri aşağıdaki alanda görmek için tıklayınız.";
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrenci_id_text);
            this.Controls.Add(this.ogrenci_id);
            this.Controls.Add(this.ogrenci_sinif_cb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ana_sayfa);
            this.Controls.Add(this.ogrenci_sil);
            this.Controls.Add(this.ogrenci_guncelle);
            this.Controls.Add(this.ogrenci_ekle);
            this.Controls.Add(this.ogrenci_telefon_text);
            this.Controls.Add(this.ogrenci_adSoyad_text);
            this.Controls.Add(this.ogrenci_sinif);
            this.Controls.Add(this.ogrenci_telefon);
            this.Controls.Add(this.ogrenci_adSoyad);
            this.Controls.Add(this.ogrenci_listele);
            this.Controls.Add(this.ogrenci_liste);
            this.Name = "ogrenci";
            this.Text = "Öğrenci";
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ogrenci_sil;
        private System.Windows.Forms.Button ogrenci_guncelle;
        private System.Windows.Forms.Button ogrenci_ekle;
        private System.Windows.Forms.TextBox ogrenci_telefon_text;
        private System.Windows.Forms.TextBox ogrenci_adSoyad_text;
        private System.Windows.Forms.Label ogrenci_sinif;
        private System.Windows.Forms.Label ogrenci_telefon;
        private System.Windows.Forms.Label ogrenci_adSoyad;
        private System.Windows.Forms.Button ogrenci_listele;
        private System.Windows.Forms.DataGridView ogrenci_liste;
        private System.Windows.Forms.Button ana_sayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ogrenci_sinif_cb;
        private System.Windows.Forms.Label ogrenci_id;
        protected System.Windows.Forms.TextBox ogrenci_id_text;
        private System.Windows.Forms.Label label2;
    }
}