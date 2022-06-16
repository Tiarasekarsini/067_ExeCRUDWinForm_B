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
    public partial class HapusDiagnosa : Form
    {
        public HapusDiagnosa()
        {
            InitializeComponent();
        }

        private void HapusDiagnosa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hellocatsDataSet1.Diagnosa' table. You can move, or remove it, as needed.
            this.diagnosaTableAdapter.Fill(this.hellocatsDataSet1.Diagnosa);

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-O4QM7APE;Initial Catalog=Hellocats;User ID=sa;Password=181920");
        private void button1_Click(object sender, EventArgs e)
        {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.deleteDiagnosa'" + editIDJ.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sukses Menghapus Data");
            new Diagnosa().Show();
            this.Hide();
            }
    }
}
