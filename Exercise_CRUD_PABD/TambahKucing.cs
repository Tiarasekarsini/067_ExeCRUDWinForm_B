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
    public partial class TambahKucing : Form
    {
        public TambahKucing()
        {
            InitializeComponent();
        }

        private void TambahKucing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hellocatsDataSet.MyCats' table. You can move, or remove it, as needed.
            this.myCatsTableAdapter.Fill(this.hellocatsDataSet.MyCats);

        }
        SqlConnection koneksi = new SqlConnection("Data Source=LAPTOP-O4QM7APE;Initial Catalog=Hellocats;User ID=sa;Password=181920");
        private void simpankucing_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            SqlCommand com = new SqlCommand("exec dbo.addmycats '" + txtIDkucing.Text + "','" + txtNamaKucing.Text + "','" + txtTanggalLahir.Text + "'", koneksi);
            com.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Sukses Menambah Data");
            new MyCats().Show();
            this.Hide();
        }
    }
}
