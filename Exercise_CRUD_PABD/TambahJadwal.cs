using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_CRUD_PABD
{
    public partial class TambahJadwal : Form
    {
        public TambahJadwal()
        {
            InitializeComponent();
        }
        SqlConnection koneksi = new SqlConnection("Data Source=LAPTOP-O4QM7APE;Initial Catalog=Hellocats;User ID=sa;Password=181920");
        private void simpanjadwal_Click(object sender, EventArgs e)
        {
                koneksi.Open();
                SqlCommand com = new SqlCommand("exec dbo.tambahJadwal '" + txtIDJadwal.Text + "','" + txtNamaKucing.Text + "','" + txtTanggalV.Text + "'", koneksi);
                com.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Sukses Menambah Data");
      
            }
    }
}
