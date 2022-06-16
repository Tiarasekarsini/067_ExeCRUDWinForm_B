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
    public partial class JadwalVaksinasi : Form
    {
        public JadwalVaksinasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new TambahJadwal().Show();
            this.Hide();
        }

        private void JadwalVaksinasi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hellocatsDataSet1.JadwalVaksinasi' table. You can move, or remove it, as needed.
            this.jadwalVaksinasiTableAdapter.Fill(this.hellocatsDataSet1.JadwalVaksinasi);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
