
namespace Exercise_CRUD_PABD
{
    partial class TambahDiagnosa
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
            this.simpankucing = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNamaPenyakit = new System.Windows.Forms.TextBox();
            this.txtNamaKucing = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDJadwal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpankucing
            // 
            this.simpankucing.Location = new System.Drawing.Point(635, 207);
            this.simpankucing.Name = "simpankucing";
            this.simpankucing.Size = new System.Drawing.Size(75, 23);
            this.simpankucing.TabIndex = 3;
            this.simpankucing.Text = "Simpan";
            this.simpankucing.UseVisualStyleBackColor = true;
            this.simpankucing.Click += new System.EventHandler(this.simpankucing_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtNamaPenyakit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNamaKucing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIDJadwal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(90, 97);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 256);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // txtNamaPenyakit
            // 
            this.txtNamaPenyakit.Location = new System.Drawing.Point(224, 165);
            this.txtNamaPenyakit.Name = "txtNamaPenyakit";
            this.txtNamaPenyakit.Size = new System.Drawing.Size(100, 22);
            this.txtNamaPenyakit.TabIndex = 5;
            // 
            // txtNamaKucing
            // 
            this.txtNamaKucing.Location = new System.Drawing.Point(224, 82);
            this.txtNamaKucing.Name = "txtNamaKucing";
            this.txtNamaKucing.Size = new System.Drawing.Size(100, 22);
            this.txtNamaKucing.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Diagnosa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kucing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Penyakit";
            // 
            // txtIDJadwal
            // 
            this.txtIDJadwal.Location = new System.Drawing.Point(224, 3);
            this.txtIDJadwal.Name = "txtIDJadwal";
            this.txtIDJadwal.Size = new System.Drawing.Size(100, 22);
            this.txtIDJadwal.TabIndex = 3;
            // 
            // TambahDiagnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpankucing);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TambahDiagnosa";
            this.Text = "TambahDiagnosa";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simpankucing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtNamaPenyakit;
        private System.Windows.Forms.TextBox txtNamaKucing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDJadwal;
    }
}