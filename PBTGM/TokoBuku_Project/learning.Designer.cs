namespace TokoBuku_Project
{
    partial class learning
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbPembayaran = new System.Windows.Forms.TextBox();
            this.tbBatalkan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKembalian = new System.Windows.Forms.TextBox();
            this.cbDiskon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTotalBayar = new System.Windows.Forms.TextBox();
            this.bSelesaiT = new System.Windows.Forms.Button();
            this.bHapus = new System.Windows.Forms.Button();
            this.bTambahT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJumlahBuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHargaBuku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKodeBuku = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbJudul = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPenerbit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(328, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 31);
            this.label8.TabIndex = 77;
            this.label8.Text = "Pembayaran";
            // 
            // tbPembayaran
            // 
            this.tbPembayaran.Location = new System.Drawing.Point(334, 439);
            this.tbPembayaran.Multiline = true;
            this.tbPembayaran.Name = "tbPembayaran";
            this.tbPembayaran.Size = new System.Drawing.Size(211, 30);
            this.tbPembayaran.TabIndex = 76;
            // 
            // tbBatalkan
            // 
            this.tbBatalkan.BackColor = System.Drawing.Color.Red;
            this.tbBatalkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbBatalkan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbBatalkan.Location = new System.Drawing.Point(80, 584);
            this.tbBatalkan.Name = "tbBatalkan";
            this.tbBatalkan.Size = new System.Drawing.Size(140, 44);
            this.tbBatalkan.TabIndex = 75;
            this.tbBatalkan.Text = "Batalkan";
            this.tbBatalkan.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(328, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 74;
            this.label6.Text = "Kembalian";
            // 
            // tbKembalian
            // 
            this.tbKembalian.Enabled = false;
            this.tbKembalian.Location = new System.Drawing.Point(334, 507);
            this.tbKembalian.Multiline = true;
            this.tbKembalian.Name = "tbKembalian";
            this.tbKembalian.Size = new System.Drawing.Size(211, 30);
            this.tbKembalian.TabIndex = 73;
            this.tbKembalian.Text = "Rp 0";
            // 
            // cbDiskon
            // 
            this.cbDiskon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiskon.FormattingEnabled = true;
            this.cbDiskon.Location = new System.Drawing.Point(80, 507);
            this.cbDiskon.Name = "cbDiskon";
            this.cbDiskon.Size = new System.Drawing.Size(211, 28);
            this.cbDiskon.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(74, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 71;
            this.label7.Text = "Pilih Diskon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(74, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 31);
            this.label5.TabIndex = 70;
            this.label5.Text = "Total Bayar";
            // 
            // tbTotalBayar
            // 
            this.tbTotalBayar.Enabled = false;
            this.tbTotalBayar.Location = new System.Drawing.Point(80, 439);
            this.tbTotalBayar.Multiline = true;
            this.tbTotalBayar.Name = "tbTotalBayar";
            this.tbTotalBayar.Size = new System.Drawing.Size(211, 30);
            this.tbTotalBayar.TabIndex = 69;
            this.tbTotalBayar.Text = "Rp 0";
            // 
            // bSelesaiT
            // 
            this.bSelesaiT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.bSelesaiT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSelesaiT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bSelesaiT.Location = new System.Drawing.Point(406, 584);
            this.bSelesaiT.Name = "bSelesaiT";
            this.bSelesaiT.Size = new System.Drawing.Size(140, 44);
            this.bSelesaiT.TabIndex = 68;
            this.bSelesaiT.Text = "Selesai";
            this.bSelesaiT.UseVisualStyleBackColor = false;
            // 
            // bHapus
            // 
            this.bHapus.BackColor = System.Drawing.Color.Red;
            this.bHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHapus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bHapus.Location = new System.Drawing.Point(64, 125);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(140, 44);
            this.bHapus.TabIndex = 67;
            this.bHapus.Text = "Hapus";
            this.bHapus.UseVisualStyleBackColor = false;
            // 
            // bTambahT
            // 
            this.bTambahT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(172)))), ((int)(((byte)(108)))));
            this.bTambahT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTambahT.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bTambahT.Location = new System.Drawing.Point(242, 125);
            this.bTambahT.Name = "bTambahT";
            this.bTambahT.Size = new System.Drawing.Size(140, 44);
            this.bTambahT.TabIndex = 66;
            this.bTambahT.Text = "Tambah ";
            this.bTambahT.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(1190, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 65;
            this.label4.Text = "Subtotal";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Location = new System.Drawing.Point(1196, 57);
            this.tbSubtotal.Multiline = true;
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(211, 30);
            this.tbSubtotal.TabIndex = 64;
            this.tbSubtotal.Text = "Rp 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(1012, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 31);
            this.label3.TabIndex = 63;
            this.label3.Text = "Jumlah";
            // 
            // tbJumlahBuku
            // 
            this.tbJumlahBuku.Location = new System.Drawing.Point(1018, 57);
            this.tbJumlahBuku.MaxLength = 5;
            this.tbJumlahBuku.Multiline = true;
            this.tbJumlahBuku.Name = "tbJumlahBuku";
            this.tbJumlahBuku.Size = new System.Drawing.Size(126, 30);
            this.tbJumlahBuku.TabIndex = 62;
            this.tbJumlahBuku.Enter += new System.EventHandler(this.tbJumlahBuku_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(749, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "Harga Buku";
            // 
            // tbHargaBuku
            // 
            this.tbHargaBuku.Enabled = false;
            this.tbHargaBuku.Location = new System.Drawing.Point(755, 57);
            this.tbHargaBuku.Multiline = true;
            this.tbHargaBuku.Name = "tbHargaBuku";
            this.tbHargaBuku.Size = new System.Drawing.Size(211, 30);
            this.tbHargaBuku.TabIndex = 60;
            this.tbHargaBuku.Text = "Rp 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(58, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 31);
            this.label2.TabIndex = 59;
            this.label2.Text = "Kode";
            // 
            // tbKodeBuku
            // 
            this.tbKodeBuku.Location = new System.Drawing.Point(64, 57);
            this.tbKodeBuku.Multiline = true;
            this.tbKodeBuku.Name = "tbKodeBuku";
            this.tbKodeBuku.Size = new System.Drawing.Size(98, 30);
            this.tbKodeBuku.TabIndex = 58;
            this.tbKodeBuku.Enter += new System.EventHandler(this.tbKodeBuku_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(208, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 31);
            this.label9.TabIndex = 79;
            this.label9.Text = "Judul";
            // 
            // tbJudul
            // 
            this.tbJudul.Location = new System.Drawing.Point(214, 57);
            this.tbJudul.Multiline = true;
            this.tbJudul.Name = "tbJudul";
            this.tbJudul.Size = new System.Drawing.Size(241, 30);
            this.tbJudul.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(501, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 31);
            this.label10.TabIndex = 81;
            this.label10.Text = "Penerbit";
            // 
            // tbPenerbit
            // 
            this.tbPenerbit.Location = new System.Drawing.Point(507, 57);
            this.tbPenerbit.Multiline = true;
            this.tbPenerbit.Name = "tbPenerbit";
            this.tbPenerbit.Size = new System.Drawing.Size(196, 30);
            this.tbPenerbit.TabIndex = 80;
            // 
            // learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1475, 800);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPenerbit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbJudul);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbPembayaran);
            this.Controls.Add(this.tbBatalkan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbKembalian);
            this.Controls.Add(this.cbDiskon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTotalBayar);
            this.Controls.Add(this.bSelesaiT);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bTambahT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbJumlahBuku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbHargaBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKodeBuku);
            this.Name = "learning";
            this.Text = "learning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPembayaran;
        private System.Windows.Forms.Button tbBatalkan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbKembalian;
        private System.Windows.Forms.ComboBox cbDiskon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotalBayar;
        private System.Windows.Forms.Button bSelesaiT;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bTambahT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJumlahBuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHargaBuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKodeBuku;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbJudul;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPenerbit;
    }
}