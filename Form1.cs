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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private static DataTable _rehber;
        public static DataTable Rehber
        {
            get
            {
                return _rehber;
            }
            set
            {
                _rehber = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _rehber = Telefon.Select();
            dataGridView1.DataSource = _rehber;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            yeni_kayit_ekle goster = new yeni_kayit_ekle();
            goster.Owner = this;
            goster.ShowDialog();
            if (goster.ttbool == true)
            {
                Form1_Load(sender, e);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // sil
            //DB.ConnectionString("DELETE FROM Person WHERE FirstName = 'Bobo'")
            //row.Cells[0].Value.ToString();
            var ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult dr = MessageBox.Show($"{adi} Kişisini Silmek İstediğinize Emin misiniz?", "Dikkat !", MessageBoxButtons.OKCancel);
            //MessageBox.Show(ID.ToString());

            if (dr == DialogResult.OK)
            {
                DB.InsertUpdateDelete($"DELETE FROM Telefon WHERE ID={ID.ToString()}");
                Form1_Load(sender, e);
                MessageBox.Show("Silindi.");
            }
            else
            {
                MessageBox.Show("Silinme İptal.");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var adi = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var evtel = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            var ceptel = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var meslek  = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DialogResult dr = MessageBox.Show($"{adi} Güncelle?", "Dkkat !", MessageBoxButtons.OKCancel);
            //MessageBox.Show(ID.ToString());
            yeni_kayit_ekle goster = new yeni_kayit_ekle();
            goster.Owner = this;
            goster.txtIsim.Text = adi;
            goster.ID = ID;
            goster.txtCepTelefonu.Text = ceptel;
            goster.txtMeslegi.Text = meslek;
            goster.txtEvTelefonu.Text = evtel;
            goster.update = true;
            goster.ShowDialog();
            if (goster.ttbool == true)
            {
                Form1_Load(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection c = new SqlConnection();
            c.ConnectionString = DB.ConnectionString;

            c.Open();

            int ID = 0;
            if (int.TryParse(textBox1.Text, out ID))
            {
                SqlCommand cmd = new SqlCommand("select * from kayıtlar where id = @id", c);
                cmd.Parameters.AddWithValue("@id", ID);

                SqlDataReader dr = cmd.ExecuteReader();


                c.Close();
            }
        }
    }
}
