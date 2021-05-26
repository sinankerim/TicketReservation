namespace sinema_rezervasyon
{
    partial class seans_ekle
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
            this.seanslar_dgv = new System.Windows.Forms.DataGridView();
            this.seansekle_gb = new System.Windows.Forms.GroupBox();
            this.seseansekle_b = new System.Windows.Forms.Button();
            this.seikiducd_cb = new System.Windows.Forms.ComboBox();
            this.sealtyazidublaj_cb = new System.Windows.Forms.ComboBox();
            this.seseanssaati_cb = new System.Windows.Forms.ComboBox();
            this.sesalon_cb = new System.Windows.Forms.ComboBox();
            this.sefilm_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seanssil_gb = new System.Windows.Forms.GroupBox();
            this.seanssil_b = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ssseansid_label = new System.Windows.Forms.Label();
            this.sssifre_txt = new System.Windows.Forms.TextBox();
            this.ssseansid_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ssduzenle_b = new System.Windows.Forms.Button();
            this.ssduzenle_label = new System.Windows.Forms.Label();
            this.sd_b = new System.Windows.Forms.Button();
            this.db_b = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seanslar_dgv)).BeginInit();
            this.seansekle_gb.SuspendLayout();
            this.seanssil_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seanslar_dgv
            // 
            this.seanslar_dgv.AllowUserToAddRows = false;
            this.seanslar_dgv.AllowUserToDeleteRows = false;
            this.seanslar_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seanslar_dgv.Location = new System.Drawing.Point(12, 12);
            this.seanslar_dgv.Name = "seanslar_dgv";
            this.seanslar_dgv.ReadOnly = true;
            this.seanslar_dgv.Size = new System.Drawing.Size(660, 168);
            this.seanslar_dgv.TabIndex = 0;
            // 
            // seansekle_gb
            // 
            this.seansekle_gb.Controls.Add(this.seseansekle_b);
            this.seansekle_gb.Controls.Add(this.seikiducd_cb);
            this.seansekle_gb.Controls.Add(this.sealtyazidublaj_cb);
            this.seansekle_gb.Controls.Add(this.seseanssaati_cb);
            this.seansekle_gb.Controls.Add(this.sesalon_cb);
            this.seansekle_gb.Controls.Add(this.sefilm_cb);
            this.seansekle_gb.Controls.Add(this.label6);
            this.seansekle_gb.Controls.Add(this.label5);
            this.seansekle_gb.Controls.Add(this.label4);
            this.seansekle_gb.Controls.Add(this.label3);
            this.seansekle_gb.Controls.Add(this.label1);
            this.seansekle_gb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seansekle_gb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.seansekle_gb.Location = new System.Drawing.Point(12, 186);
            this.seansekle_gb.Name = "seansekle_gb";
            this.seansekle_gb.Size = new System.Drawing.Size(341, 252);
            this.seansekle_gb.TabIndex = 1;
            this.seansekle_gb.TabStop = false;
            this.seansekle_gb.Text = "Sean Ekle";
            // 
            // seseansekle_b
            // 
            this.seseansekle_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seseansekle_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seseansekle_b.Location = new System.Drawing.Point(161, 211);
            this.seseansekle_b.Name = "seseansekle_b";
            this.seseansekle_b.Size = new System.Drawing.Size(159, 23);
            this.seseansekle_b.TabIndex = 2;
            this.seseansekle_b.Text = "Seans Ekle";
            this.seseansekle_b.UseVisualStyleBackColor = true;
            this.seseansekle_b.Click += new System.EventHandler(this.seseansekle_b_Click);
            // 
            // seikiducd_cb
            // 
            this.seikiducd_cb.FormattingEnabled = true;
            this.seikiducd_cb.Location = new System.Drawing.Point(161, 168);
            this.seikiducd_cb.Name = "seikiducd_cb";
            this.seikiducd_cb.Size = new System.Drawing.Size(159, 30);
            this.seikiducd_cb.TabIndex = 1;
            // 
            // sealtyazidublaj_cb
            // 
            this.sealtyazidublaj_cb.FormattingEnabled = true;
            this.sealtyazidublaj_cb.Location = new System.Drawing.Point(161, 135);
            this.sealtyazidublaj_cb.Name = "sealtyazidublaj_cb";
            this.sealtyazidublaj_cb.Size = new System.Drawing.Size(159, 30);
            this.sealtyazidublaj_cb.TabIndex = 1;
            this.sealtyazidublaj_cb.SelectedIndexChanged += new System.EventHandler(this.sealtyazidublaj_cb_SelectedIndexChanged);
            // 
            // seseanssaati_cb
            // 
            this.seseanssaati_cb.FormattingEnabled = true;
            this.seseanssaati_cb.Location = new System.Drawing.Point(161, 102);
            this.seseanssaati_cb.Name = "seseanssaati_cb";
            this.seseanssaati_cb.Size = new System.Drawing.Size(159, 30);
            this.seseanssaati_cb.TabIndex = 1;
            this.seseanssaati_cb.SelectedIndexChanged += new System.EventHandler(this.seseanssaati_cb_SelectedIndexChanged);
            // 
            // sesalon_cb
            // 
            this.sesalon_cb.FormattingEnabled = true;
            this.sesalon_cb.Location = new System.Drawing.Point(161, 69);
            this.sesalon_cb.Name = "sesalon_cb";
            this.sesalon_cb.Size = new System.Drawing.Size(159, 30);
            this.sesalon_cb.TabIndex = 1;
            this.sesalon_cb.SelectedIndexChanged += new System.EventHandler(this.sesalon_cb_SelectedIndexChanged);
            // 
            // sefilm_cb
            // 
            this.sefilm_cb.FormattingEnabled = true;
            this.sefilm_cb.Location = new System.Drawing.Point(103, 36);
            this.sefilm_cb.Name = "sefilm_cb";
            this.sefilm_cb.Size = new System.Drawing.Size(217, 30);
            this.sefilm_cb.TabIndex = 1;
            this.sefilm_cb.SelectedIndexChanged += new System.EventHandler(this.sefilm_cb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "2D/3D:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Altyazı/Dublaj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seans saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film:";
            // 
            // seanssil_gb
            // 
            this.seanssil_gb.Controls.Add(this.seanssil_b);
            this.seanssil_gb.Controls.Add(this.label2);
            this.seanssil_gb.Controls.Add(this.ssseansid_label);
            this.seanssil_gb.Controls.Add(this.sssifre_txt);
            this.seanssil_gb.Controls.Add(this.ssseansid_txt);
            this.seanssil_gb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seanssil_gb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.seanssil_gb.Location = new System.Drawing.Point(386, 291);
            this.seanssil_gb.Name = "seanssil_gb";
            this.seanssil_gb.Size = new System.Drawing.Size(393, 147);
            this.seanssil_gb.TabIndex = 1;
            this.seanssil_gb.TabStop = false;
            this.seanssil_gb.Text = "Seans Sil";
            // 
            // seanssil_b
            // 
            this.seanssil_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seanssil_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seanssil_b.Location = new System.Drawing.Point(164, 106);
            this.seanssil_b.Name = "seanssil_b";
            this.seanssil_b.Size = new System.Drawing.Size(146, 23);
            this.seanssil_b.TabIndex = 2;
            this.seanssil_b.Text = "Seans Sil";
            this.seanssil_b.UseVisualStyleBackColor = true;
            this.seanssil_b.Click += new System.EventHandler(this.seanssil_b_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifrenizi Giriniz:";
            // 
            // ssseansid_label
            // 
            this.ssseansid_label.AutoSize = true;
            this.ssseansid_label.Location = new System.Drawing.Point(19, 25);
            this.ssseansid_label.Name = "ssseansid_label";
            this.ssseansid_label.Size = new System.Drawing.Size(89, 22);
            this.ssseansid_label.TabIndex = 1;
            this.ssseansid_label.Text = "Seans id:";
            // 
            // sssifre_txt
            // 
            this.sssifre_txt.Location = new System.Drawing.Point(164, 61);
            this.sssifre_txt.Name = "sssifre_txt";
            this.sssifre_txt.Size = new System.Drawing.Size(156, 29);
            this.sssifre_txt.TabIndex = 0;
            this.sssifre_txt.UseSystemPasswordChar = true;
            // 
            // ssseansid_txt
            // 
            this.ssseansid_txt.Location = new System.Drawing.Point(164, 22);
            this.ssseansid_txt.Name = "ssseansid_txt";
            this.ssseansid_txt.Size = new System.Drawing.Size(85, 29);
            this.ssseansid_txt.TabIndex = 0;
            this.ssseansid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssseansid_txt_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ssduzenle_b);
            this.groupBox1.Controls.Add(this.ssduzenle_label);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(386, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seans Saatleri";
            // 
            // ssduzenle_b
            // 
            this.ssduzenle_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ssduzenle_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ssduzenle_b.Location = new System.Drawing.Point(118, 61);
            this.ssduzenle_b.Name = "ssduzenle_b";
            this.ssduzenle_b.Size = new System.Drawing.Size(140, 23);
            this.ssduzenle_b.TabIndex = 1;
            this.ssduzenle_b.Text = "Düzenle";
            this.ssduzenle_b.UseVisualStyleBackColor = true;
            this.ssduzenle_b.Click += new System.EventHandler(this.ssduzenle_b_Click);
            // 
            // ssduzenle_label
            // 
            this.ssduzenle_label.AutoSize = true;
            this.ssduzenle_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ssduzenle_label.Location = new System.Drawing.Point(83, 25);
            this.ssduzenle_label.Name = "ssduzenle_label";
            this.ssduzenle_label.Size = new System.Drawing.Size(227, 22);
            this.ssduzenle_label.TabIndex = 0;
            this.ssduzenle_label.Text = "Seans Saatlerini Ayarlayın";
            // 
            // sd_b
            // 
            this.sd_b.Location = new System.Drawing.Point(678, 45);
            this.sd_b.Name = "sd_b";
            this.sd_b.Size = new System.Drawing.Size(110, 39);
            this.sd_b.TabIndex = 3;
            this.sd_b.Text = "Seansları Düzenle";
            this.sd_b.UseVisualStyleBackColor = true;
            this.sd_b.Click += new System.EventHandler(this.sd_b_Click);
            // 
            // db_b
            // 
            this.db_b.Location = new System.Drawing.Point(678, 90);
            this.db_b.Name = "db_b";
            this.db_b.Size = new System.Drawing.Size(110, 39);
            this.db_b.TabIndex = 3;
            this.db_b.Text = "Düzenlemeyi Bitir";
            this.db_b.UseVisualStyleBackColor = true;
            this.db_b.Click += new System.EventHandler(this.db_b_Click);
            // 
            // seans_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.db_b);
            this.Controls.Add(this.sd_b);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seanssil_gb);
            this.Controls.Add(this.seansekle_gb);
            this.Controls.Add(this.seanslar_dgv);
            this.Name = "seans_ekle";
            this.Text = "seans_ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.seans_ekle_FormClosed);
            this.Load += new System.EventHandler(this.seans_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanslar_dgv)).EndInit();
            this.seansekle_gb.ResumeLayout(false);
            this.seansekle_gb.PerformLayout();
            this.seanssil_gb.ResumeLayout(false);
            this.seanssil_gb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seanslar_dgv;
        private System.Windows.Forms.GroupBox seansekle_gb;
        private System.Windows.Forms.GroupBox seanssil_gb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ssseansid_label;
        private System.Windows.Forms.TextBox sssifre_txt;
        private System.Windows.Forms.TextBox ssseansid_txt;
        private System.Windows.Forms.Button seanssil_b;
        private System.Windows.Forms.ComboBox seikiducd_cb;
        private System.Windows.Forms.ComboBox sealtyazidublaj_cb;
        private System.Windows.Forms.ComboBox seseanssaati_cb;
        private System.Windows.Forms.ComboBox sesalon_cb;
        private System.Windows.Forms.ComboBox sefilm_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button seseansekle_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ssduzenle_b;
        private System.Windows.Forms.Label ssduzenle_label;
        private System.Windows.Forms.Button sd_b;
        private System.Windows.Forms.Button db_b;
    }
}