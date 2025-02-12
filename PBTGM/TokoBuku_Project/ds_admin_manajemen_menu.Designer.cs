namespace TokoBuku_Project
{
    partial class ds_admin_manajemen_menu
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
            this.ddatelabel1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.data_buku = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSimpan = new System.Windows.Forms.Button();
            this.bHapus = new System.Windows.Forms.Button();
            this.bPerbaharui = new System.Windows.Forms.Button();
            this.bKosongkan = new System.Windows.Forms.Button();
            this.bCari = new System.Windows.Forms.Button();
            this.bRefresh = new System.Windows.Forms.Button();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbIdBuku = new System.Windows.Forms.TextBox();
            this.tbKodeBuku = new System.Windows.Forms.TextBox();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.tbPengarang = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbStok = new System.Windows.Forms.TextBox();
            this.tbPenerbit = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bNext = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.lblHalaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_buku)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddatelabel1
            // 
            this.ddatelabel1.AutoSize = true;
            this.ddatelabel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddatelabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ddatelabel1.Location = new System.Drawing.Point(68, 65);
            this.ddatelabel1.Name = "ddatelabel1";
            this.ddatelabel1.Size = new System.Drawing.Size(197, 31);
            this.ddatelabel1.TabIndex = 18;
            this.ddatelabel1.Text = "Rabu, 1 Januari 2025";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 50);
            this.label8.TabIndex = 17;
            this.label8.Text = "Management Barang";
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
            this.Column5,
            this.Column6,
            this.Column7});
            this.data_buku.Location = new System.Drawing.Point(74, 183);
            this.data_buku.Name = "data_buku";
            this.data_buku.RowHeadersVisible = false;
            this.data_buku.RowHeadersWidth = 62;
            this.data_buku.RowTemplate.Height = 28;
            this.data_buku.Size = new System.Drawing.Size(1342, 423);
            this.data_buku.TabIndex = 19;
            this.data_buku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_buku_CellClick);
            this.data_buku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_buku_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Buku";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Buku";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Judul ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Pengarang";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Penerbit";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Harga";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stok";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // bSimpan
            // 
            this.bSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSimpan.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSimpan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bSimpan.Location = new System.Drawing.Point(74, 915);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(169, 58);
            this.bSimpan.TabIndex = 23;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = false;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click_2);
            // 
            // bHapus
            // 
            this.bHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHapus.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHapus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bHapus.Location = new System.Drawing.Point(291, 915);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(169, 58);
            this.bHapus.TabIndex = 24;
            this.bHapus.Text = "Hapus";
            this.bHapus.UseVisualStyleBackColor = false;
            this.bHapus.Click += new System.EventHandler(this.bHapus_Click);
            // 
            // bPerbaharui
            // 
            this.bPerbaharui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bPerbaharui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPerbaharui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPerbaharui.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerbaharui.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bPerbaharui.Location = new System.Drawing.Point(725, 915);
            this.bPerbaharui.Name = "bPerbaharui";
            this.bPerbaharui.Size = new System.Drawing.Size(169, 58);
            this.bPerbaharui.TabIndex = 25;
            this.bPerbaharui.Text = "Perbaharui";
            this.bPerbaharui.UseVisualStyleBackColor = false;
            this.bPerbaharui.Click += new System.EventHandler(this.bPerbaharui_Click);
            // 
            // bKosongkan
            // 
            this.bKosongkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bKosongkan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bKosongkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKosongkan.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bKosongkan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bKosongkan.Location = new System.Drawing.Point(508, 915);
            this.bKosongkan.Name = "bKosongkan";
            this.bKosongkan.Size = new System.Drawing.Size(169, 58);
            this.bKosongkan.TabIndex = 25;
            this.bKosongkan.Text = "Kosongkan";
            this.bKosongkan.UseVisualStyleBackColor = false;
            // 
            // bCari
            // 
            this.bCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bCari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCari.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCari.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bCari.Location = new System.Drawing.Point(1179, 111);
            this.bCari.Name = "bCari";
            this.bCari.Size = new System.Drawing.Size(109, 42);
            this.bCari.TabIndex = 35;
            this.bCari.Text = "Cari";
            this.bCari.UseVisualStyleBackColor = false;
            this.bCari.Click += new System.EventHandler(this.bCari_Click);
            // 
            // bRefresh
            // 
            this.bRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefresh.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefresh.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bRefresh.Location = new System.Drawing.Point(1307, 111);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(109, 42);
            this.bRefresh.TabIndex = 34;
            this.bRefresh.Text = "Refresh";
            this.bRefresh.UseVisualStyleBackColor = false;
            this.bRefresh.Click += new System.EventHandler(this.bRefresh_Click);
            // 
            // tbCari
            // 
            this.tbCari.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCari.Location = new System.Drawing.Point(74, 111);
            this.tbCari.Multiline = true;
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(983, 35);
            this.tbCari.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 219);
            this.panel1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(369, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kode Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(697, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Judul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(1025, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Pengarang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(697, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "Penerbit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(41, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 31);
            this.label6.TabIndex = 36;
            this.label6.Text = "Harga";
            // 
            // tbIdBuku
            // 
            this.tbIdBuku.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbIdBuku.Location = new System.Drawing.Point(47, 72);
            this.tbIdBuku.Multiline = true;
            this.tbIdBuku.Name = "tbIdBuku";
            this.tbIdBuku.Size = new System.Drawing.Size(265, 38);
            this.tbIdBuku.TabIndex = 40;
            this.tbIdBuku.TextChanged += new System.EventHandler(this.bSimpan_Click);
            // 
            // tbKodeBuku
            // 
            this.tbKodeBuku.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbKodeBuku.Location = new System.Drawing.Point(375, 72);
            this.tbKodeBuku.Multiline = true;
            this.tbKodeBuku.Name = "tbKodeBuku";
            this.tbKodeBuku.Size = new System.Drawing.Size(265, 38);
            this.tbKodeBuku.TabIndex = 46;
            // 
            // tbJudul
            // 
            this.tbJudul.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbJudul.Location = new System.Drawing.Point(703, 72);
            this.tbJudul.Multiline = true;
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(265, 38);
            this.tbJudul.TabIndex = 47;
            // 
            // tbPengarang
            // 
            this.tbPengarang.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbPengarang.Location = new System.Drawing.Point(1031, 72);
            this.tbPengarang.Multiline = true;
            this.tbPengarang.Name = "tbPengarang";
            this.tbPengarang.Size = new System.Drawing.Size(265, 38);
            this.tbPengarang.TabIndex = 48;
            // 
            // tbHarga
            // 
            this.tbHarga.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbHarga.Location = new System.Drawing.Point(47, 154);
            this.tbHarga.Multiline = true;
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(265, 38);
            this.tbHarga.TabIndex = 49;
            // 
            // tbStok
            // 
            this.tbStok.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbStok.Location = new System.Drawing.Point(375, 154);
            this.tbStok.Multiline = true;
            this.tbStok.Name = "tbStok";
            this.tbStok.Size = new System.Drawing.Size(265, 38);
            this.tbStok.TabIndex = 50;
            // 
            // tbPenerbit
            // 
            this.tbPenerbit.Font = new System.Drawing.Font("Poppins", 8F);
            this.tbPenerbit.Location = new System.Drawing.Point(703, 154);
            this.tbPenerbit.Multiline = true;
            this.tbPenerbit.Name = "tbPenerbit";
            this.tbPenerbit.Size = new System.Drawing.Size(265, 38);
            this.tbPenerbit.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.panel2.Controls.Add(this.tbPenerbit);
            this.panel2.Controls.Add(this.tbStok);
            this.panel2.Controls.Add(this.tbHarga);
            this.panel2.Controls.Add(this.tbPengarang);
            this.panel2.Controls.Add(this.tbJudul);
            this.panel2.Controls.Add(this.tbKodeBuku);
            this.panel2.Controls.Add(this.tbIdBuku);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(74, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 230);
            this.panel2.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(369, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Stok";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Location = new System.Drawing.Point(1423, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(66, 219);
            this.panel3.TabIndex = 37;
            // 
            // bNext
            // 
            this.bNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNext.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bNext.Location = new System.Drawing.Point(202, 612);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(109, 42);
            this.bNext.TabIndex = 38;
            this.bNext.Text = "Next ";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bBack.Location = new System.Drawing.Point(74, 612);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(109, 42);
            this.bBack.TabIndex = 39;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lblHalaman
            // 
            this.lblHalaman.AutoSize = true;
            this.lblHalaman.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalaman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHalaman.Location = new System.Drawing.Point(1252, 617);
            this.lblHalaman.Name = "lblHalaman";
            this.lblHalaman.Size = new System.Drawing.Size(0, 31);
            this.lblHalaman.TabIndex = 40;
            // 
            // ds_admin_manajemen_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 994);
            this.Controls.Add(this.lblHalaman);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCari);
            this.Controls.Add(this.bRefresh);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bKosongkan);
            this.Controls.Add(this.bPerbaharui);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.data_buku);
            this.Controls.Add(this.ddatelabel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ds_admin_manajemen_menu";
            this.Text = "manajemen_page";
            this.Load += new System.EventHandler(this.ds_admin_manajemen_menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_buku)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ddatelabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView data_buku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bPerbaharui;
        private System.Windows.Forms.Button bKosongkan;
        private System.Windows.Forms.Button bCari;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbIdBuku;
        private System.Windows.Forms.TextBox tbKodeBuku;
        private System.Windows.Forms.TextBox tbJudul;
        private System.Windows.Forms.TextBox tbPengarang;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbStok;
        private System.Windows.Forms.TextBox tbPenerbit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label lblHalaman;
    }
}