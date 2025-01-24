namespace TokoBuku_Project
{
    partial class ds_kasir_transaksi_baru_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamaBuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHargaBuku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJumlahBuku = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.bTambahT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bCariProduk = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabel_transaksi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_transaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(61, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nama Buku";
            // 
            // tbNamaBuku
            // 
            this.tbNamaBuku.Enabled = false;
            this.tbNamaBuku.Location = new System.Drawing.Point(225, 432);
            this.tbNamaBuku.Multiline = true;
            this.tbNamaBuku.Name = "tbNamaBuku";
            this.tbNamaBuku.Size = new System.Drawing.Size(211, 30);
            this.tbNamaBuku.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(61, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "Harga Buku";
            // 
            // tbHargaBuku
            // 
            this.tbHargaBuku.Enabled = false;
            this.tbHargaBuku.Location = new System.Drawing.Point(225, 491);
            this.tbHargaBuku.Multiline = true;
            this.tbHargaBuku.Name = "tbHargaBuku";
            this.tbHargaBuku.Size = new System.Drawing.Size(211, 30);
            this.tbHargaBuku.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(61, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 35;
            this.label3.Text = "Jumlah Buku";
            // 
            // tbJumlahBuku
            // 
            this.tbJumlahBuku.Location = new System.Drawing.Point(225, 550);
            this.tbJumlahBuku.MaxLength = 5;
            this.tbJumlahBuku.Multiline = true;
            this.tbJumlahBuku.Name = "tbJumlahBuku";
            this.tbJumlahBuku.Size = new System.Drawing.Size(211, 30);
            this.tbJumlahBuku.TabIndex = 34;
            this.tbJumlahBuku.TextChanged += new System.EventHandler(this.tbJumlahBuku_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(442, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Subtotal";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Location = new System.Drawing.Point(539, 432);
            this.tbSubtotal.Multiline = true;
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(211, 30);
            this.tbSubtotal.TabIndex = 36;
            // 
            // bTambahT
            // 
            this.bTambahT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.bTambahT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTambahT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bTambahT.Location = new System.Drawing.Point(296, 620);
            this.bTambahT.Name = "bTambahT";
            this.bTambahT.Size = new System.Drawing.Size(140, 44);
            this.bTambahT.TabIndex = 39;
            this.bTambahT.Text = "Tambah ";
            this.bTambahT.UseVisualStyleBackColor = false;
            this.bTambahT.Click += new System.EventHandler(this.bTambahT_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(132, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 44);
            this.button2.TabIndex = 40;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bCariProduk
            // 
            this.bCariProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.bCariProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCariProduk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bCariProduk.Location = new System.Drawing.Point(67, 13);
            this.bCariProduk.Name = "bCariProduk";
            this.bCariProduk.Size = new System.Drawing.Size(178, 38);
            this.bCariProduk.TabIndex = 42;
            this.bCariProduk.Text = "Cari Produk";
            this.bCariProduk.UseVisualStyleBackColor = false;
            this.bCariProduk.Click += new System.EventHandler(this.bCariProduk_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(809, 620);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 44);
            this.button4.TabIndex = 44;
            this.button4.Text = "Selesai";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(803, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 46;
            this.label5.Text = "Total Bayar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(809, 475);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 30);
            this.textBox1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(803, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 50;
            this.label7.Text = "Pilih Diskon";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(809, 543);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 28);
            this.comboBox1.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(1057, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 53;
            this.label6.Text = "Kembalian";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1063, 543);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 30);
            this.textBox2.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(1135, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 44);
            this.button1.TabIndex = 54;
            this.button1.Text = "Batalkan";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(1057, 441);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 31);
            this.label8.TabIndex = 56;
            this.label8.Text = "Pembayaran";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1063, 475);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(211, 30);
            this.textBox3.TabIndex = 55;
            // 
            // tabel_transaksi
            // 
            this.tabel_transaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabel_transaksi.BackgroundColor = System.Drawing.Color.White;
            this.tabel_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_transaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.tabel_transaksi.Location = new System.Drawing.Point(67, 70);
            this.tabel_transaksi.Name = "tabel_transaksi";
            this.tabel_transaksi.RowHeadersVisible = false;
            this.tabel_transaksi.RowHeadersWidth = 62;
            this.tabel_transaksi.RowTemplate.Height = 28;
            this.tabel_transaksi.Size = new System.Drawing.Size(1208, 343);
            this.tabel_transaksi.TabIndex = 57;
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
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Subtotal";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // ds_kasir_transaksi_baru_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bCariProduk);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bTambahT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbJumlahBuku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHargaBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNamaBuku);
            this.Controls.Add(this.tabel_transaksi);
            this.Name = "ds_kasir_transaksi_baru_control";
            this.Size = new System.Drawing.Size(1336, 700);
            this.Load += new System.EventHandler(this.ds_kasir_transaksi_baru_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabel_transaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamaBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHargaBuku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJumlahBuku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Button bTambahT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bCariProduk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView tabel_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
