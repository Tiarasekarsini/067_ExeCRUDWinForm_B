
namespace Exercise_CRUD_PABD
{
    partial class MyCats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCats));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idKucingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKucingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hellocatsDataSet = new Exercise_CRUD_PABD.HellocatsDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myCatsTableAdapter = new Exercise_CRUD_PABD.HellocatsDataSetTableAdapters.MyCatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hellocatsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKucingDataGridViewTextBoxColumn,
            this.namaKucingDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.myCatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(540, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // idKucingDataGridViewTextBoxColumn
            // 
            this.idKucingDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idKucingDataGridViewTextBoxColumn.DataPropertyName = "Id_Kucing";
            this.idKucingDataGridViewTextBoxColumn.HeaderText = "Id_Kucing";
            this.idKucingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idKucingDataGridViewTextBoxColumn.Name = "idKucingDataGridViewTextBoxColumn";
            // 
            // namaKucingDataGridViewTextBoxColumn
            // 
            this.namaKucingDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kucing";
            this.namaKucingDataGridViewTextBoxColumn.HeaderText = "Nama_Kucing";
            this.namaKucingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaKucingDataGridViewTextBoxColumn.Name = "namaKucingDataGridViewTextBoxColumn";
            this.namaKucingDataGridViewTextBoxColumn.Width = 125;
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            this.tanggalLahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // myCatsBindingSource
            // 
            this.myCatsBindingSource.DataMember = "MyCats";
            this.myCatsBindingSource.DataSource = this.hellocatsDataSet;
            // 
            // hellocatsDataSet
            // 
            this.hellocatsDataSet.DataSetName = "HellocatsDataSet";
            this.hellocatsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(596, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(596, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(190)))), ((int)(((byte)(2)))));
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(596, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Kucing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 441);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // myCatsTableAdapter
            // 
            this.myCatsTableAdapter.ClearBeforeFill = true;
            // 
            // MyCats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(854, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyCats";
            this.Text = "MyCats";
            this.Load += new System.EventHandler(this.MyCats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hellocatsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private HellocatsDataSet hellocatsDataSet;
        private System.Windows.Forms.BindingSource myCatsBindingSource;
        private HellocatsDataSetTableAdapters.MyCatsTableAdapter myCatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKucingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKucingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
    }
}