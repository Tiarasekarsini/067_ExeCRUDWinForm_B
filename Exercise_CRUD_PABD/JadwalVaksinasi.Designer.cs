
namespace Exercise_CRUD_PABD
{
    partial class JadwalVaksinasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalVaksinasi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hellocatsDataSet1 = new Exercise_CRUD_PABD.HellocatsDataSet1();
            this.jadwalVaksinasiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalVaksinasiTableAdapter = new Exercise_CRUD_PABD.HellocatsDataSet1TableAdapters.JadwalVaksinasiTableAdapter();
            this.idJadwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKucingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalVaksinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hellocatsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalVaksinasiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(532, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "Jadwal Vaksinasi";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(502, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(502, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(502, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJadwalDataGridViewTextBoxColumn,
            this.namaKucingDataGridViewTextBoxColumn,
            this.tanggalVaksinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jadwalVaksinasiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(450, 240);
            this.dataGridView1.TabIndex = 6;
            // 
            // hellocatsDataSet1
            // 
            this.hellocatsDataSet1.DataSetName = "HellocatsDataSet1";
            this.hellocatsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jadwalVaksinasiBindingSource
            // 
            this.jadwalVaksinasiBindingSource.DataMember = "JadwalVaksinasi";
            this.jadwalVaksinasiBindingSource.DataSource = this.hellocatsDataSet1;
            // 
            // jadwalVaksinasiTableAdapter
            // 
            this.jadwalVaksinasiTableAdapter.ClearBeforeFill = true;
            // 
            // idJadwalDataGridViewTextBoxColumn
            // 
            this.idJadwalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idJadwalDataGridViewTextBoxColumn.DataPropertyName = "Id_Jadwal";
            this.idJadwalDataGridViewTextBoxColumn.HeaderText = "Id_Jadwal";
            this.idJadwalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idJadwalDataGridViewTextBoxColumn.Name = "idJadwalDataGridViewTextBoxColumn";
            // 
            // namaKucingDataGridViewTextBoxColumn
            // 
            this.namaKucingDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kucing";
            this.namaKucingDataGridViewTextBoxColumn.HeaderText = "Nama_Kucing";
            this.namaKucingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaKucingDataGridViewTextBoxColumn.Name = "namaKucingDataGridViewTextBoxColumn";
            this.namaKucingDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalVaksinDataGridViewTextBoxColumn
            // 
            this.tanggalVaksinDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Vaksin";
            this.tanggalVaksinDataGridViewTextBoxColumn.HeaderText = "Tanggal_Vaksin";
            this.tanggalVaksinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalVaksinDataGridViewTextBoxColumn.Name = "tanggalVaksinDataGridViewTextBoxColumn";
            this.tanggalVaksinDataGridViewTextBoxColumn.Width = 125;
            // 
            // JadwalVaksinasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(728, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JadwalVaksinasi";
            this.Text = "JadwalVaksinasi";
            this.Load += new System.EventHandler(this.JadwalVaksinasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hellocatsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalVaksinasiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HellocatsDataSet1 hellocatsDataSet1;
        private System.Windows.Forms.BindingSource jadwalVaksinasiBindingSource;
        private HellocatsDataSet1TableAdapters.JadwalVaksinasiTableAdapter jadwalVaksinasiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJadwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKucingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalVaksinDataGridViewTextBoxColumn;
    }
}