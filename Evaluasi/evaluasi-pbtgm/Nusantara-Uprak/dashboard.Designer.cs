namespace Nusantara_Uprak
{
    partial class dashboard
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbPria = new System.Windows.Forms.RadioButton();
            this.dTanggal = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKode = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.cbProvinsi = new System.Windows.Forms.ComboBox();
            this.cbKab = new System.Windows.Forms.ComboBox();
            this.cbKec = new System.Windows.Forms.ComboBox();
            this.tbNoHp = new System.Windows.Forms.TextBox();
            this.cbAgama = new System.Windows.Forms.ComboBox();
            this.bHapus = new System.Windows.Forms.Button();
            this.bKosongkan = new System.Windows.Forms.Button();
            this.bSimpan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(332, 449);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 24);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Wanita";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbPria
            // 
            this.rbPria.AutoSize = true;
            this.rbPria.Location = new System.Drawing.Point(159, 451);
            this.rbPria.Name = "rbPria";
            this.rbPria.Size = new System.Drawing.Size(61, 24);
            this.rbPria.TabIndex = 53;
            this.rbPria.TabStop = true;
            this.rbPria.Text = "Pria";
            this.rbPria.UseVisualStyleBackColor = true;
            // 
            // dTanggal
            // 
            this.dTanggal.Location = new System.Drawing.Point(159, 123);
            this.dTanggal.Name = "dTanggal";
            this.dTanggal.Size = new System.Drawing.Size(268, 26);
            this.dTanggal.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(512, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(622, 575);
            this.dataGridView1.TabIndex = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kode Member";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Lengkap";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jenis Kelamin";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "No Telepon";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // tbKode
            // 
            this.tbKode.Location = new System.Drawing.Point(159, 13);
            this.tbKode.Name = "tbKode";
            this.tbKode.Size = new System.Drawing.Size(268, 26);
            this.tbKode.TabIndex = 49;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(159, 68);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(268, 26);
            this.tbNama.TabIndex = 48;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(159, 178);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(268, 26);
            this.tbAlamat.TabIndex = 47;
            // 
            // cbProvinsi
            // 
            this.cbProvinsi.FormattingEnabled = true;
            this.cbProvinsi.Location = new System.Drawing.Point(159, 233);
            this.cbProvinsi.Name = "cbProvinsi";
            this.cbProvinsi.Size = new System.Drawing.Size(268, 28);
            this.cbProvinsi.TabIndex = 46;
            this.cbProvinsi.SelectedIndexChanged += new System.EventHandler(this.cbProvinsi_SelectedIndexChanged);
            // 
            // cbKab
            // 
            this.cbKab.FormattingEnabled = true;
            this.cbKab.Location = new System.Drawing.Point(159, 285);
            this.cbKab.Name = "cbKab";
            this.cbKab.Size = new System.Drawing.Size(268, 28);
            this.cbKab.TabIndex = 45;
            this.cbKab.SelectedIndexChanged += new System.EventHandler(this.cbKab_SelectedIndexChanged);
            // 
            // cbKec
            // 
            this.cbKec.FormattingEnabled = true;
            this.cbKec.Location = new System.Drawing.Point(159, 343);
            this.cbKec.Name = "cbKec";
            this.cbKec.Size = new System.Drawing.Size(268, 28);
            this.cbKec.TabIndex = 44;
            // 
            // tbNoHp
            // 
            this.tbNoHp.Location = new System.Drawing.Point(159, 391);
            this.tbNoHp.Name = "tbNoHp";
            this.tbNoHp.Size = new System.Drawing.Size(268, 26);
            this.tbNoHp.TabIndex = 43;
            // 
            // cbAgama
            // 
            this.cbAgama.FormattingEnabled = true;
            this.cbAgama.Items.AddRange(new object[] {
            "Islam",
            "Hindu",
            "Budha",
            "Kristen",
            "Katolik",
            "Khonghucu"});
            this.cbAgama.Location = new System.Drawing.Point(159, 499);
            this.cbAgama.Name = "cbAgama";
            this.cbAgama.Size = new System.Drawing.Size(268, 28);
            this.cbAgama.TabIndex = 42;
            // 
            // bHapus
            // 
            this.bHapus.Location = new System.Drawing.Point(250, 625);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(177, 52);
            this.bHapus.TabIndex = 41;
            this.bHapus.Text = "Hapus";
            this.bHapus.UseVisualStyleBackColor = true;
            // 
            // bKosongkan
            // 
            this.bKosongkan.Location = new System.Drawing.Point(250, 567);
            this.bKosongkan.Name = "bKosongkan";
            this.bKosongkan.Size = new System.Drawing.Size(177, 52);
            this.bKosongkan.TabIndex = 40;
            this.bKosongkan.Text = "Baru";
            this.bKosongkan.UseVisualStyleBackColor = true;
            // 
            // bSimpan
            // 
            this.bSimpan.Location = new System.Drawing.Point(17, 567);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(177, 108);
            this.bSimpan.TabIndex = 39;
            this.bSimpan.Text = "Simpan";
            this.bSimpan.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Agama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Jenis Kelamin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 398);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Nomor Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Kecamatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Kab / Kota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Provinsi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tanggal Lahir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nama Lengkap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kode Member";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(482, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 664);
            this.panel1.TabIndex = 51;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 690);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbPria);
            this.Controls.Add(this.dTanggal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbKode);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.cbProvinsi);
            this.Controls.Add(this.cbKab);
            this.Controls.Add(this.cbKec);
            this.Controls.Add(this.tbNoHp);
            this.Controls.Add(this.cbAgama);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bKosongkan);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbPria;
        private System.Windows.Forms.DateTimePicker dTanggal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox tbKode;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.ComboBox cbProvinsi;
        private System.Windows.Forms.ComboBox cbKab;
        private System.Windows.Forms.ComboBox cbKec;
        private System.Windows.Forms.TextBox tbNoHp;
        private System.Windows.Forms.ComboBox cbAgama;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bKosongkan;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}