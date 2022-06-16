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
    public partial class MyCats : Form
    {
        public MyCats()
        {
            InitializeComponent();
        }

        private void MyCats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hellocatsDataSet.MyCats' table. You can move, or remove it, as needed.
            this.myCatsTableAdapter.Fill(this.hellocatsDataSet.MyCats);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TambahKucing().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
