namespace KeremParlak
{
    partial class kisi
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
            this.kisi_liste = new System.Windows.Forms.DataGridView();
            this.kisi_listele = new System.Windows.Forms.Button();
            this.kisi_adSoyad = new System.Windows.Forms.Label();
            this.kisi_telefon = new System.Windows.Forms.Label();
            this.kisi_kurum = new System.Windows.Forms.Label();
            this.kisi_adSoyad_text = new System.Windows.Forms.TextBox();
            this.kisi_telefon_text = new System.Windows.Forms.TextBox();
            this.kisi_kurum_richText = new System.Windows.Forms.RichTextBox();
            this.kisi_ekle = new System.Windows.Forms.Button();
            this.kisi_guncelle = new System.Windows.Forms.Button();
            this.kisi_sil = new System.Windows.Forms.Button();
            this.ana_sayfa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kisi_id = new System.Windows.Forms.Label();
            this.kisi_id_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kisi_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // kisi_liste
            // 
            this.kisi_liste.AllowUserToAddRows = false;
            this.kisi_liste.AllowUserToDeleteRows = false;
            this.kisi_liste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kisi_liste.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.kisi_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kisi_liste.Location = new System.Drawing.Point(1, 362);
            this.kisi_liste.Name = "kisi_liste";
            this.kisi_liste.ReadOnly = true;
            this.kisi_liste.RowHeadersWidth = 51;
            this.kisi_liste.RowTemplate.Height = 24;
            this.kisi_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kisi_liste.Size = new System.Drawing.Size(820, 228);
            this.kisi_liste.TabIndex = 0;
            this.kisi_liste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.kisi_liste_CellEnter);
            // 
            // kisi_listele
            // 
            this.kisi_listele.Location = new System.Drawing.Point(285, 313);
            this.kisi_listele.Name = "kisi_listele";
            this.kisi_listele.Size = new System.Drawing.Size(525, 43);
            this.kisi_listele.TabIndex = 1;
            this.kisi_listele.Text = "Listele";
            this.kisi_listele.UseVisualStyleBackColor = true;
            this.kisi_listele.Click += new System.EventHandler(this.kisi_listele_Click);
            // 
            // kisi_adSoyad
            // 
            this.kisi_adSoyad.AutoSize = true;
            this.kisi_adSoyad.Location = new System.Drawing.Point(23, 20);
            this.kisi_adSoyad.Name = "kisi_adSoyad";
            this.kisi_adSoyad.Size = new System.Drawing.Size(70, 16);
            this.kisi_adSoyad.TabIndex = 2;
            this.kisi_adSoyad.Text = "Ad Soyad:";
            // 
            // kisi_telefon
            // 
            this.kisi_telefon.AutoSize = true;
            this.kisi_telefon.Location = new System.Drawing.Point(23, 77);
            this.kisi_telefon.Name = "kisi_telefon";
            this.kisi_telefon.Size = new System.Drawing.Size(53, 16);
            this.kisi_telefon.TabIndex = 2;
            this.kisi_telefon.Text = "Telefon";
            // 
            // kisi_kurum
            // 
            this.kisi_kurum.AutoSize = true;
            this.kisi_kurum.Location = new System.Drawing.Point(23, 132);
            this.kisi_kurum.Name = "kisi_kurum";
            this.kisi_kurum.Size = new System.Drawing.Size(83, 16);
            this.kisi_kurum.TabIndex = 2;
            this.kisi_kurum.Text = "Kurum Bilgisi";
            // 
            // kisi_adSoyad_text
            // 
            this.kisi_adSoyad_text.Location = new System.Drawing.Point(132, 20);
            this.kisi_adSoyad_text.Name = "kisi_adSoyad_text";
            this.kisi_adSoyad_text.Size = new System.Drawing.Size(153, 22);
            this.kisi_adSoyad_text.TabIndex = 3;
            // 
            // kisi_telefon_text
            // 
            this.kisi_telefon_text.Location = new System.Drawing.Point(132, 74);
            this.kisi_telefon_text.Name = "kisi_telefon_text";
            this.kisi_telefon_text.Size = new System.Drawing.Size(153, 22);
            this.kisi_telefon_text.TabIndex = 3;
            // 
            // kisi_kurum_richText
            // 
            this.kisi_kurum_richText.Location = new System.Drawing.Point(132, 129);
            this.kisi_kurum_richText.Name = "kisi_kurum_richText";
            this.kisi_kurum_richText.Size = new System.Drawing.Size(152, 24);
            this.kisi_kurum_richText.TabIndex = 4;
            this.kisi_kurum_richText.Text = "";
            // 
            // kisi_ekle
            // 
            this.kisi_ekle.Location = new System.Drawing.Point(153, 190);
            this.kisi_ekle.Name = "kisi_ekle";
            this.kisi_ekle.Size = new System.Drawing.Size(151, 31);
            this.kisi_ekle.TabIndex = 5;
            this.kisi_ekle.Text = "Ekle";
            this.kisi_ekle.UseVisualStyleBackColor = true;
            this.kisi_ekle.Click += new System.EventHandler(this.kisi_ekle_Click);
            // 
            // kisi_guncelle
            // 
            this.kisi_guncelle.Location = new System.Drawing.Point(340, 190);
            this.kisi_guncelle.Name = "kisi_guncelle";
            this.kisi_guncelle.Size = new System.Drawing.Size(151, 31);
            this.kisi_guncelle.TabIndex = 5;
            this.kisi_guncelle.Text = "Güncelle";
            this.kisi_guncelle.UseVisualStyleBackColor = true;
            this.kisi_guncelle.Click += new System.EventHandler(this.kisi_guncelle_Click);
            // 
            // kisi_sil
            // 
            this.kisi_sil.Location = new System.Drawing.Point(527, 190);
            this.kisi_sil.Name = "kisi_sil";
            this.kisi_sil.Size = new System.Drawing.Size(151, 31);
            this.kisi_sil.TabIndex = 5;
            this.kisi_sil.Text = "Sil";
            this.kisi_sil.UseVisualStyleBackColor = true;
            this.kisi_sil.Click += new System.EventHandler(this.kisi_sil_Click);
            // 
            // ana_sayfa
            // 
            this.ana_sayfa.Location = new System.Drawing.Point(10, 596);
            this.ana_sayfa.Name = "ana_sayfa";
            this.ana_sayfa.Size = new System.Drawing.Size(178, 29);
            this.ana_sayfa.TabIndex = 6;
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
            this.label1.TabIndex = 19;
            this.label1.Text = "*Telefon kısmı boş kalabilir.";
            // 
            // kisi_id
            // 
            this.kisi_id.AutoSize = true;
            this.kisi_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisi_id.Location = new System.Drawing.Point(22, 323);
            this.kisi_id.Name = "kisi_id";
            this.kisi_id.Size = new System.Drawing.Size(28, 20);
            this.kisi_id.TabIndex = 22;
            this.kisi_id.Text = "ID";
            this.kisi_id.Click += new System.EventHandler(this.ogrenci_id_Click);
            // 
            // kisi_id_text
            // 
            this.kisi_id_text.Location = new System.Drawing.Point(71, 323);
            this.kisi_id_text.MinimumSize = new System.Drawing.Size(0, 30);
            this.kisi_id_text.Name = "kisi_id_text";
            this.kisi_id_text.ReadOnly = true;
            this.kisi_id_text.Size = new System.Drawing.Size(171, 22);
            this.kisi_id_text.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(291, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kayıtlı verileri aşağıdaki alanda görmek için tıklayınız.";
            // 
            // kisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(822, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kisi_id_text);
            this.Controls.Add(this.kisi_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ana_sayfa);
            this.Controls.Add(this.kisi_sil);
            this.Controls.Add(this.kisi_guncelle);
            this.Controls.Add(this.kisi_ekle);
            this.Controls.Add(this.kisi_kurum_richText);
            this.Controls.Add(this.kisi_telefon_text);
            this.Controls.Add(this.kisi_adSoyad_text);
            this.Controls.Add(this.kisi_kurum);
            this.Controls.Add(this.kisi_telefon);
            this.Controls.Add(this.kisi_adSoyad);
            this.Controls.Add(this.kisi_listele);
            this.Controls.Add(this.kisi_liste);
            this.Name = "kisi";
            this.Text = "Kişi";
            this.Load += new System.EventHandler(this.kisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kisi_liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kisi_liste;
        private System.Windows.Forms.Button kisi_listele;
        private System.Windows.Forms.Label kisi_adSoyad;
        private System.Windows.Forms.Label kisi_telefon;
        private System.Windows.Forms.Label kisi_kurum;
        private System.Windows.Forms.TextBox kisi_adSoyad_text;
        private System.Windows.Forms.TextBox kisi_telefon_text;
        private System.Windows.Forms.RichTextBox kisi_kurum_richText;
        private System.Windows.Forms.Button kisi_ekle;
        private System.Windows.Forms.Button kisi_guncelle;
        private System.Windows.Forms.Button kisi_sil;
        private System.Windows.Forms.Button ana_sayfa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kisi_id;
        private System.Windows.Forms.TextBox kisi_id_text;
        private System.Windows.Forms.Label label2;
    }
}