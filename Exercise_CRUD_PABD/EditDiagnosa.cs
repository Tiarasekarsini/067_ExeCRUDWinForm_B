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
    public partial class EditDiagnosa : Form
    {
        public EditDiagnosa()
        {
            InitializeComponent();
        }

        private void EditDiagnosa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hellocatsDataSet1.Diagnosa' table. You can move, or remove it, as needed.
            this.diagnosaTableAdapter.Fill(this.hellocatsDataSet1.Diagnosa);

        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-O4QM7APE;Initial Catalog=Hellocats;User ID=sa;Password=181920");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.updatediagnosa'" + editIDJ.Text + "','" + editNamaK.Text + "','" + textBox3.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sukses Mengubah Data");
            new Diagnosa().Show();
            this.Hide();
        }
    }
}
