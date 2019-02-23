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
using System.Configuration;

namespace Disconnected_Urun_Kategori_Listele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        SqlCommand cmd;
        DataTable dt;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunDoldur_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select * from Products", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                dt = new DataTable("Urunler");
                adp.Fill(dt);
                if (!ds.Tables.Contains("Urunler"))
                {
                    ds.Tables.Add(dt);
                }
                else
                {
                    ds.Tables.Remove("Urunler");
                    ds.Tables.Add(dt);
                }

                MessageBox.Show("Urunleri getirme işlemi başarıyla yapıldı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Urunleri getirme işlemi başarısız oldu");
            }



        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Urunler"];
        }

        private void btnKategoriDoldur_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select * from Categories", con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                dt = new DataTable("Kategoriler");
                adp.Fill(dt);
                if (!ds.Tables.Contains("Kategoriler"))
                {
                    ds.Tables.Add(dt);
                }
                else
                {
                    ds.Tables.Remove("Kategoriler");
                    ds.Tables.Add(dt);
                }

                MessageBox.Show("Kategorileri getirme işlemi başarıyla yapıldı");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Kategorileri getirme işlemi başarısız oldu");
            }
        }

        private void btnKategoriGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Kategoriler"];
        }
    }
}
