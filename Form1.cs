using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pastane_Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-N9EER84;Initial Catalog=Pastane_Otomasyon;Integrated Security=True");

        void MalzemeListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void UrunListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Kasa()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLKASA", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Tarifler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLURUNLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DisplayMember = "AD";
            cmbUrun.DataSource = dt;
            baglanti.Close();
        }

        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLMALZEMELER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt;
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListele();

            Tarifler();

            Malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListele();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblmalzemeler (ad,stok,fıyat,notlar) values (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@P2", txtMalzemeStok.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@P4", txtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme başarıyla eklendi!");
            MalzemeListele();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLURUNLER (ad) values (@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1",txtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün sisteme eklendi!");
            UrunListele();
        }

        private void btnTarifOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFIRIN (URUNID,MALZEMEID,MIKTAR,MALIYET) VALUES (@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@P2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@P3", txtMiktar.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme eklendi!");

            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (txtMiktar.Text=="")
            {
                txtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select FIYAT from TBLMALZEMELER where MALZEMEID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMaliyet.Text = dr[0].ToString();
            }
            baglanti.Close();

            maliyet = Convert.ToDouble(txtMaliyet.Text)/1000 * Convert.ToInt64(txtMiktar.Text);

            txtMaliyet.Text = maliyet.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(malıyet) from tblfırın where urunıd=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtMFiyat.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
    }
}
