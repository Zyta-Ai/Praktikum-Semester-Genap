namespace TokoBuku_Project
{
    partial class ds_kasir_menu_utama
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMain = new System.Windows.Forms.Panel();
            this.bTransaksiBaru = new System.Windows.Forms.Button();
            this.tbStokBarang = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddatelabel1
            // 
            this.ddatelabel1.AutoSize = true;
            this.ddatelabel1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddatelabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ddatelabel1.Location = new System.Drawing.Point(76, 85);
            this.ddatelabel1.Name = "ddatelabel1";
            this.ddatelabel1.Size = new System.Drawing.Size(197, 31);
            this.ddatelabel1.TabIndex = 18;
            this.ddatelabel1.Text = "Rabu, 1 Januari 2025";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(309, 50);
            this.label8.TabIndex = 17;
            this.label8.Text = "Welcome Back, Lara!";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(81, 139);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1336, 700);
            this.panelMain.TabIndex = 20;
            // 
            // bTransaksiBaru
            // 
            this.bTransaksiBaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.bTransaksiBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTransaksiBaru.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bTransaksiBaru.Location = new System.Drawing.Point(268, 882);
            this.bTransaksiBaru.Name = "bTransaksiBaru";
            this.bTransaksiBaru.Size = new System.Drawing.Size(195, 55);
            this.bTransaksiBaru.TabIndex = 21;
            this.bTransaksiBaru.Text = "Transaksi Baru";
            this.bTransaksiBaru.UseVisualStyleBackColor = false;
            this.bTransaksiBaru.Click += new System.EventHandler(this.bTransaksiBaru_Click);
            // 
            // tbStokBarang
            // 
            this.tbStokBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.tbStokBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbStokBarang.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tbStokBarang.Location = new System.Drawing.Point(524, 882);
            this.tbStokBarang.Name = "tbStokBarang";
            this.tbStokBarang.Size = new System.Drawing.Size(195, 55);
            this.tbStokBarang.TabIndex = 22;
            this.tbStokBarang.Text = "Stok Barang";
            this.tbStokBarang.UseVisualStyleBackColor = false;
            this.tbStokBarang.Click += new System.EventHandler(this.tbStokBarang_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(780, 882);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 55);
            this.button3.TabIndex = 23;
            this.button3.Text = "Cetak Ulang Struk";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(1036, 882);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 55);
            this.button4.TabIndex = 24;
            this.button4.Text = "Diskon Menu";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ds_kasir_menu_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 995);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbStokBarang);
            this.Controls.Add(this.bTransaksiBaru);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ddatelabel1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ds_kasir_menu_utama";
            this.Text = "kasir_menu_utama";
            this.Load += new System.EventHandler(this.ds_kasir_menu_utama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ddatelabel1;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button bTransaksiBaru;
        private System.Windows.Forms.Button tbStokBarang;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}