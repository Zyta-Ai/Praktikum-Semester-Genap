namespace TokoBuku_Project
{
    partial class DataBuku_Tabel
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
            this.data_buku = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bCari = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_buku)).BeginInit();
            this.SuspendLayout();
            // 
            // data_buku
            // 
            this.data_buku.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_buku.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.data_buku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_buku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.data_buku.Location = new System.Drawing.Point(83, 100);
            this.data_buku.Name = "data_buku";
            this.data_buku.RowHeadersVisible = false;
            this.data_buku.RowHeadersWidth = 62;
            this.data_buku.RowTemplate.Height = 28;
            this.data_buku.Size = new System.Drawing.Size(938, 256);
            this.data_buku.TabIndex = 20;
            this.data_buku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_buku_CellClick);
            this.data_buku.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_buku_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Buku";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Judul Buku";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Pengarang";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Stok";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // bCari
            // 
            this.bCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCari.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCari.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bCari.Location = new System.Drawing.Point(83, 19);
            this.bCari.Name = "bCari";
            this.bCari.Size = new System.Drawing.Size(84, 35);
            this.bCari.TabIndex = 37;
            this.bCari.Text = "Cari";
            this.bCari.UseVisualStyleBackColor = false;
            this.bCari.Click += new System.EventHandler(this.bCari_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbCari.Location = new System.Drawing.Point(232, 19);
            this.tbCari.Multiline = true;
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(789, 35);
            this.tbCari.TabIndex = 36;
            this.tbCari.TextChanged += new System.EventHandler(this.tbCari_TextChanged);
            this.tbCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCari_KeyPress);
            // 
            // DataBuku_Tabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 398);
            this.Controls.Add(this.bCari);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.data_buku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DataBuku_Tabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DataBuku_Tabel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_buku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_buku;
        private System.Windows.Forms.Button bCari;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}