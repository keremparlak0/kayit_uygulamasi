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
using MySql.Data.MySqlClient;

namespace KeremParlak
{
    
    public partial class ana_sayfa : Form
    {
        Thread _thread;
        public ana_sayfa()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void kisi_Click(object sender, EventArgs e)
        {
            this.Close();
            //kisi _kisi = new kisi();
            //_kisi.Show();
            _thread = new Thread(yeniFormuAc_kisi);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();
            
        }

        private void ogrenci_Click(object sender, EventArgs e)
        {
            this.Close();
            //ogrenci _ogrenci = new ogrenci();
            //_ogrenci.Show();
            _thread = new Thread(yeniFormuAc_ogrenci);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Start();

        }

        private void yeniFormuAc_kisi()
        {
            Application.Run(new kisi());
        } void yeniFormuAc_ogrenci()
        {
            Application.Run(new ogrenci());
        }
    }
}
