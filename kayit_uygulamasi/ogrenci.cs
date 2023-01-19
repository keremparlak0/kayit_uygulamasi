using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeremParlak
{
    public partial class ogrenci : Form
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
            _adapter = new MySqlDataAdapter("SELECT * FROM ogrenci", _connection);
            _adapter.Fill(_data);
            ogrenci_liste.DataSource = _data;
            _connection.Close();

        }
        public ogrenci()
        {
            InitializeComponent();
        }

        private void ana_sayfa_Click(object sender, EventArgs e)
        {
            Close();
            _thread = new Thread(anaSayfayaGit);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
        }

        private void ogrenci_listele_Click(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void anaSayfayaGit()
        {
            Application.Run(new ana_sayfa());
        }

        private void ogrenci_liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ogrenci_id_text.Text = ogrenci_liste.CurrentRow.Cells[0].Value.ToString();
            ogrenci_adSoyad_text.Text = ogrenci_liste.CurrentRow.Cells[1].Value.ToString();
            ogrenci_telefon_text.Text = ogrenci_liste.CurrentRow.Cells[2].Value.ToString();
            ogrenci_sinif_cb.Text = ogrenci_liste.CurrentRow.Cells[3].Value.ToString();
        }

        private void ogrenci_ekle_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ogrenci(ogrenci_adSoyad, ogrenci_telefon, ogrenci_sinif)" +
                "VALUES (@adSoyad, @telefon, @sinif)";

            if (ogrenci_adSoyad_text.Text == "" || ogrenci_sinif_cb.Text == "")
            {
                MessageBox.Show("Ad Soyad ve Sınıf kısmı boş bırakılamaz!");
            }
            else
            {
                _command = new MySqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@adSoyad", ogrenci_adSoyad_text.Text);
                _command.Parameters.AddWithValue("@telefon", ogrenci_telefon_text.Text);
                _command.Parameters.AddWithValue("@sinif", ogrenci_sinif_cb.Text);
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();
                veriGetir();
                MessageBox.Show("Kayıt Eklendi!");
            }
                
        }
        
        private void ogrenci_sil_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM ogrenci WHERE ogrenci_id = @id";
            _command = new MySqlCommand(query, _connection);
            _command.Parameters.AddWithValue("@id", ogrenci_id_text.Text);
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
            veriGetir();
            MessageBox.Show("Öğrenci Silindi!");
        }

        private void ogrenci_guncelle_Click(object sender, EventArgs e)
        {
            string query = "UPDATE ogrenci " +
                "SET ogrenci_adSoyad = @adSoyad, ogrenci_telefon = @telefon, ogrenci_sinif = @kurum " +
                "WHERE ogrenci_id = @id";
            if (ogrenci_adSoyad_text.Text == "" || ogrenci_sinif_cb.Text == "")
            {
                MessageBox.Show("Ad Soyad ve Sınıf kısmı boş bırakılamaz!");
            }
            else
            {
                _command = new MySqlCommand(query, _connection);
                _command.Parameters.AddWithValue("@id", ogrenci_id_text.Text);
                _command.Parameters.AddWithValue("@adSoyad", ogrenci_adSoyad_text.Text);
                _command.Parameters.AddWithValue("@telefon", ogrenci_telefon_text.Text);
                _command.Parameters.AddWithValue("@kurum", ogrenci_sinif_cb.Text);
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();
                veriGetir();
                MessageBox.Show("Öğrenci Kaydı Güncellendi!");
            }
        }
    }
}
