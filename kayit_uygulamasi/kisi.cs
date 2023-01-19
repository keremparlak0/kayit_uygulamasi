using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeremParlak
{
    public partial class kisi : Form
    {
        private MySqlConnection _connection = new MySqlConnection("Server=localhost;Database=kisi_ekle;Uid=root;Pwd='';");
        MySqlCommand _command;
        MySqlDataAdapter _adapter;
        DataTable _data;

        Thread _thread;

        public void veriGetir()
        {
            _data = new DataTable();
            _connection.Open();
            _adapter = new MySqlDataAdapter("SELECT * FROM kisi", _connection);
            _adapter.Fill(_data);
            kisi_liste.DataSource = _data;
            _connection.Close();

        }
        public kisi()
        {
            InitializeComponent();
        }

        private void kisi_listele_Click(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void ana_sayfa_Click(object sender, EventArgs e)
        {
            Close();
            _thread = new Thread(anaSayfayaGit);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void kisi_Load(object sender, EventArgs e)
        {

        }

        private void anaSayfayaGit()
        {
            Application.Run(new ana_sayfa());
        }

        private void kisi_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            kisi_id_text.Text = kisi_liste.CurrentRow.Cells[0].Value.ToString();
            kisi_adSoyad_text.Text = kisi_liste.CurrentRow.Cells[1].Value.ToString();
            kisi_telefon_text.Text = kisi_liste.CurrentRow.Cells[2].Value.ToString();
            kisi_kurum_richText.Text = kisi_liste.CurrentRow.Cells[3].Value.ToString();

        }

        private void kisi_ekle_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO kisi(kisi_adSoyad, kisi_telefon, kisi_kurum)" +
                "VALUES (@adSoyad, @telefon, @kurum)";
            
            if (kisi_adSoyad_text.Text == "" || kisi_kurum_richText.Text == "")
            {
                MessageBox.Show("Ad Soyad ve Kurum kısmı boş bırakılamaz!");
            }
            else
            {
                _command = new MySqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@adSoyad", kisi_adSoyad_text.Text);
                _command.Parameters.AddWithValue("@telefon", kisi_telefon_text.Text);
                _command.Parameters.AddWithValue("@kurum", kisi_kurum_richText.Text);
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();
                veriGetir();
                MessageBox.Show("Kişi Eklendi!");

            }



        }

        private void kisi_sil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM kisi WHERE kisi_id = @id";
            _command = new MySqlCommand(query, _connection);
            _command.Parameters.AddWithValue("@id", kisi_id_text.Text);
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
            veriGetir();
            MessageBox.Show("Kişi Silindi!");
        }

        private void kisi_guncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE kisi " +
                "SET kisi_adSoyad = @adSoyad, kisi_telefon = @telefon, kisi_kurum = @kurum " +
                "WHERE kisi_id = @id";


            if (kisi_adSoyad_text.Text == "" || kisi_kurum_richText.Text == "")
            {
                MessageBox.Show("Ad Soyad ve Kurum kısmı boş bırakılamaz!");
            }
            else
            {
                _command = new MySqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@id", kisi_id_text.Text);
                _command.Parameters.AddWithValue("@adSoyad", kisi_adSoyad_text.Text);
                _command.Parameters.AddWithValue("@telefon", kisi_telefon_text.Text);
                _command.Parameters.AddWithValue("@kurum", kisi_kurum_richText.Text);
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();
                veriGetir();

                MessageBox.Show("Kişi Kaydı Güncellendi!");
            }
        }

        private void ogrenci_id_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogrenci_id_Click(object sender, EventArgs e)
        {

        }
    }
}
