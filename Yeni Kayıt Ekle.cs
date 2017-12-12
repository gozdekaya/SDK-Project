using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp16.Models;

namespace WindowsFormsApp16
{
    public partial class yeni_kayit_ekle : Form
    {
        public yeni_kayit_ekle()
        {
            InitializeComponent();
        }
        public bool ttbool = false;
        public string ID = "";
        public bool update = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (update == true)
            {
                //UPDATE kisiler SET Ad=@ad,Soyad=@soyad,Yas=@yas,Tarih=@tarih,Onay=@onay WHERE ID=@id
                var t = new Telefon();
                t.ID = int.Parse(ID);
                t.Isim = txtIsim.Text;
                t.Meslek = txtMeslegi.Text;
                t.EvTelefonu = txtEvTelefonu.Text;
                t.CepTelefonu = txtCepTelefonu.Text;
                Telefon.Update(t);
                MessageBox.Show("Başarılı");
                ttbool = true;
                this.Close();
            }
            else
            {
                Telefon t = new Telefon();
                t.Isim = txtIsim.Text;
                t.CepTelefonu = txtCepTelefonu.Text;
                t.EvTelefonu = txtEvTelefonu.Text;
                t.Meslek = txtMeslegi.Text;

                Telefon.Insert(t);


                Form1.Rehber = Telefon.Select();
                ttbool = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yeni_kayit_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
