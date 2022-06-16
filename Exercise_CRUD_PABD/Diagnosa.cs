using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_CRUD_PABD
{
    public partial class Diagnosa : Form
    {
        public Diagnosa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TambahDiagnosa().Show();
            this.Hide();
        }

        private void Diagnosa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hellocatsDataSet1.Diagnosa' table. You can move, or remove it, as needed.
            this.diagnosaTableAdapter.Fill(this.hellocatsDataSet1.Diagnosa);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new EditDiagnosa().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new HapusDiagnosa().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
