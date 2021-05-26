namespace sinema_rezervasyon
{
    partial class film_ekle
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
            this.fefilmadi_label = new System.Windows.Forms.Label();
            this.feyassiniri_label = new System.Windows.Forms.Label();
            this.fekacdk_label = new System.Windows.Forms.Label();
            this.fevbaslangic_label = new System.Windows.Forms.Label();
            this.fevbitis_label = new System.Windows.Forms.Label();
            this.filmekle_b = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fevbitist_dtp = new System.Windows.Forms.DateTimePicker();
            this.fevbaslangict_dtp = new System.Windows.Forms.DateTimePicker();
            this.fekacdk_txt = new System.Windows.Forms.TextBox();
            this.feyassiniri_txt = new System.Windows.Forms.TextBox();
            this.fefilmadi_txt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fsfilmid_txt = new System.Windows.Forms.TextBox();
            this.fssifre_txt = new System.Windows.Forms.TextBox();
            this.filmsil_b = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filmler_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bdyeniveri_txt = new System.Windows.Forms.TextBox();
            this.bdfilmid_txt = new System.Windows.Forms.TextBox();
            this.guncelle_b = new System.Windows.Forms.Button();
            this.bd_cb = new System.Windows.Forms.ComboBox();
            this.filminid_label = new System.Windows.Forms.Label();
            this.yeniveri_label = new System.Windows.Forms.Label();
            this.duzenle_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmler_dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fefilmadi_label
            // 
            this.fefilmadi_label.AutoSize = true;
            this.fefilmadi_label.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fefilmadi_label.ForeColor = System.Drawing.Color.White;
            this.fefilmadi_label.Location = new System.Drawing.Point(30, 44);
            this.fefilmadi_label.Name = "fefilmadi_label";
            this.fefilmadi_label.Size = new System.Drawing.Size(85, 22);
            this.fefilmadi_label.TabIndex = 0;
            this.fefilmadi_label.Text = "Film Adı:";
            // 
            // feyassiniri_label
            // 
            this.feyassiniri_label.AutoSize = true;
            this.feyassiniri_label.Font = new System.Drawing.Font("Arial", 14.25F);
            this.feyassiniri_label.ForeColor = System.Drawing.Color.White;
            this.feyassiniri_label.Location = new System.Drawing.Point(30, 82);
            this.feyassiniri_label.Name = "feyassiniri_label";
            this.feyassiniri_label.Size = new System.Drawing.Size(98, 22);
            this.feyassiniri_label.TabIndex = 0;
            this.feyassiniri_label.Text = "Yaş Sınırı:";
            // 
            // fekacdk_label
            // 
            this.fekacdk_label.AutoSize = true;
            this.fekacdk_label.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fekacdk_label.ForeColor = System.Drawing.Color.White;
            this.fekacdk_label.Location = new System.Drawing.Point(30, 120);
            this.fekacdk_label.Name = "fekacdk_label";
            this.fekacdk_label.Size = new System.Drawing.Size(109, 22);
            this.fekacdk_label.TabIndex = 0;
            this.fekacdk_label.Text = "Kaç Dakika:";
            // 
            // fevbaslangic_label
            // 
            this.fevbaslangic_label.AutoSize = true;
            this.fevbaslangic_label.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fevbaslangic_label.ForeColor = System.Drawing.Color.White;
            this.fevbaslangic_label.Location = new System.Drawing.Point(30, 158);
            this.fevbaslangic_label.Name = "fevbaslangic_label";
            this.fevbaslangic_label.Size = new System.Drawing.Size(209, 22);
            this.fevbaslangic_label.TabIndex = 0;
            this.fevbaslangic_label.Text = "Vizyon Başlangıç Tarihi:";
            // 
            // fevbitis_label
            // 
            this.fevbitis_label.AutoSize = true;
            this.fevbitis_label.Font = new System.Drawing.Font("Arial", 14.25F);
            this.fevbitis_label.ForeColor = System.Drawing.Color.White;
            this.fevbitis_label.Location = new System.Drawing.Point(30, 196);
            this.fevbitis_label.Name = "fevbitis_label";
            this.fevbitis_label.Size = new System.Drawing.Size(161, 22);
            this.fevbitis_label.TabIndex = 0;
            this.fevbitis_label.Text = "Vizyon Bitiş Tarihi:";
            // 
            // filmekle_b
            // 
            this.filmekle_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmekle_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filmekle_b.Location = new System.Drawing.Point(245, 241);
            this.filmekle_b.Name = "filmekle_b";
            this.filmekle_b.Size = new System.Drawing.Size(156, 23);
            this.filmekle_b.TabIndex = 6;
            this.filmekle_b.Text = "Filmi Ekle";
            this.filmekle_b.UseVisualStyleBackColor = true;
            this.filmekle_b.Click += new System.EventHandler(this.filmekle_b_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fevbitist_dtp);
            this.groupBox1.Controls.Add(this.fevbaslangict_dtp);
            this.groupBox1.Controls.Add(this.fekacdk_txt);
            this.groupBox1.Controls.Add(this.feyassiniri_txt);
            this.groupBox1.Controls.Add(this.fefilmadi_txt);
            this.groupBox1.Controls.Add(this.fefilmadi_label);
            this.groupBox1.Controls.Add(this.filmekle_b);
            this.groupBox1.Controls.Add(this.feyassiniri_label);
            this.groupBox1.Controls.Add(this.fekacdk_label);
            this.groupBox1.Controls.Add(this.fevbaslangic_label);
            this.groupBox1.Controls.Add(this.fevbitis_label);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(18, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 317);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Ekle";
            // 
            // fevbitist_dtp
            // 
            this.fevbitist_dtp.Checked = false;
            this.fevbitist_dtp.CustomFormat = "";
            this.fevbitist_dtp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fevbitist_dtp.Location = new System.Drawing.Point(245, 191);
            this.fevbitist_dtp.Name = "fevbitist_dtp";
            this.fevbitist_dtp.Size = new System.Drawing.Size(156, 20);
            this.fevbitist_dtp.TabIndex = 8;
            // 
            // fevbaslangict_dtp
            // 
            this.fevbaslangict_dtp.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fevbaslangict_dtp.Checked = false;
            this.fevbaslangict_dtp.CustomFormat = "";
            this.fevbaslangict_dtp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fevbaslangict_dtp.Location = new System.Drawing.Point(245, 153);
            this.fevbaslangict_dtp.Name = "fevbaslangict_dtp";
            this.fevbaslangict_dtp.Size = new System.Drawing.Size(156, 20);
            this.fevbaslangict_dtp.TabIndex = 7;
            // 
            // fekacdk_txt
            // 
            this.fekacdk_txt.Location = new System.Drawing.Point(245, 117);
            this.fekacdk_txt.Name = "fekacdk_txt";
            this.fekacdk_txt.Size = new System.Drawing.Size(156, 29);
            this.fekacdk_txt.TabIndex = 3;
            this.fekacdk_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fekacdk_txt_KeyPress);
            // 
            // feyassiniri_txt
            // 
            this.feyassiniri_txt.Location = new System.Drawing.Point(245, 79);
            this.feyassiniri_txt.Name = "feyassiniri_txt";
            this.feyassiniri_txt.Size = new System.Drawing.Size(156, 29);
            this.feyassiniri_txt.TabIndex = 2;
            this.feyassiniri_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.feyassiniri_txt_KeyPress);
            // 
            // fefilmadi_txt
            // 
            this.fefilmadi_txt.Location = new System.Drawing.Point(150, 41);
            this.fefilmadi_txt.Name = "fefilmadi_txt";
            this.fefilmadi_txt.Size = new System.Drawing.Size(251, 29);
            this.fefilmadi_txt.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fsfilmid_txt);
            this.groupBox2.Controls.Add(this.fssifre_txt);
            this.groupBox2.Controls.Add(this.filmsil_b);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(435, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Sil";
            // 
            // fsfilmid_txt
            // 
            this.fsfilmid_txt.Location = new System.Drawing.Point(198, 19);
            this.fsfilmid_txt.Name = "fsfilmid_txt";
            this.fsfilmid_txt.Size = new System.Drawing.Size(100, 29);
            this.fsfilmid_txt.TabIndex = 11;
            this.fsfilmid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fsfilmid_txt_KeyPress_1);
            // 
            // fssifre_txt
            // 
            this.fssifre_txt.Location = new System.Drawing.Point(198, 63);
            this.fssifre_txt.Name = "fssifre_txt";
            this.fssifre_txt.Size = new System.Drawing.Size(155, 29);
            this.fssifre_txt.TabIndex = 12;
            this.fssifre_txt.UseSystemPasswordChar = true;
            // 
            // filmsil_b
            // 
            this.filmsil_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmsil_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filmsil_b.Location = new System.Drawing.Point(194, 106);
            this.filmsil_b.Name = "filmsil_b";
            this.filmsil_b.Size = new System.Drawing.Size(156, 23);
            this.filmsil_b.TabIndex = 13;
            this.filmsil_b.Text = "Filmi Sil";
            this.filmsil_b.UseVisualStyleBackColor = true;
            this.filmsil_b.Click += new System.EventHandler(this.filmsil_b_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lütfen Şifrenizi Giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Id:";
            // 
            // filmler_dgv
            // 
            this.filmler_dgv.AllowUserToAddRows = false;
            this.filmler_dgv.AllowUserToDeleteRows = false;
            this.filmler_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.filmler_dgv.Location = new System.Drawing.Point(77, 12);
            this.filmler_dgv.Name = "filmler_dgv";
            this.filmler_dgv.ReadOnly = true;
            this.filmler_dgv.Size = new System.Drawing.Size(658, 166);
            this.filmler_dgv.TabIndex = 14;
            this.filmler_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmler_dgv_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bdyeniveri_txt);
            this.groupBox3.Controls.Add(this.bdfilmid_txt);
            this.groupBox3.Controls.Add(this.guncelle_b);
            this.groupBox3.Controls.Add(this.bd_cb);
            this.groupBox3.Controls.Add(this.filminid_label);
            this.groupBox3.Controls.Add(this.yeniveri_label);
            this.groupBox3.Controls.Add(this.duzenle_label);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(435, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 172);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgileri Düzenle";
            // 
            // bdyeniveri_txt
            // 
            this.bdyeniveri_txt.Location = new System.Drawing.Point(144, 96);
            this.bdyeniveri_txt.Name = "bdyeniveri_txt";
            this.bdyeniveri_txt.Size = new System.Drawing.Size(206, 29);
            this.bdyeniveri_txt.TabIndex = 9;
            // 
            // bdfilmid_txt
            // 
            this.bdfilmid_txt.Location = new System.Drawing.Point(144, 60);
            this.bdfilmid_txt.Name = "bdfilmid_txt";
            this.bdfilmid_txt.Size = new System.Drawing.Size(66, 29);
            this.bdfilmid_txt.TabIndex = 8;
            this.bdfilmid_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bdid_txt_KeyPress);
            // 
            // guncelle_b
            // 
            this.guncelle_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelle_b.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guncelle_b.Location = new System.Drawing.Point(144, 131);
            this.guncelle_b.Name = "guncelle_b";
            this.guncelle_b.Size = new System.Drawing.Size(156, 23);
            this.guncelle_b.TabIndex = 10;
            this.guncelle_b.Text = "Güncelle";
            this.guncelle_b.UseVisualStyleBackColor = true;
            this.guncelle_b.Click += new System.EventHandler(this.guncelle_b_Click);
            // 
            // bd_cb
            // 
            this.bd_cb.FormattingEnabled = true;
            this.bd_cb.Location = new System.Drawing.Point(144, 25);
            this.bd_cb.Name = "bd_cb";
            this.bd_cb.Size = new System.Drawing.Size(116, 30);
            this.bd_cb.TabIndex = 7;
            // 
            // filminid_label
            // 
            this.filminid_label.AutoSize = true;
            this.filminid_label.Location = new System.Drawing.Point(6, 60);
            this.filminid_label.Name = "filminid_label";
            this.filminid_label.Size = new System.Drawing.Size(98, 22);
            this.filminid_label.TabIndex = 0;
            this.filminid_label.Text = "Filmin id\'si";
            // 
            // yeniveri_label
            // 
            this.yeniveri_label.AutoSize = true;
            this.yeniveri_label.Location = new System.Drawing.Point(6, 96);
            this.yeniveri_label.Name = "yeniveri_label";
            this.yeniveri_label.Size = new System.Drawing.Size(88, 22);
            this.yeniveri_label.TabIndex = 0;
            this.yeniveri_label.Text = "Yeni Veri:";
            // 
            // duzenle_label
            // 
            this.duzenle_label.AutoSize = true;
            this.duzenle_label.Location = new System.Drawing.Point(6, 25);
            this.duzenle_label.Name = "duzenle_label";
            this.duzenle_label.Size = new System.Drawing.Size(84, 22);
            this.duzenle_label.TabIndex = 0;
            this.duzenle_label.Text = "Düzenle:";
            // 
            // film_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(805, 513);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.filmler_dgv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "film_ekle";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.film_ekle_FormClosed);
            this.Load += new System.EventHandler(this.film_ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmler_dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fefilmadi_label;
        private System.Windows.Forms.Label feyassiniri_label;
        private System.Windows.Forms.Label fekacdk_label;
        private System.Windows.Forms.Label fevbaslangic_label;
        private System.Windows.Forms.Label fevbitis_label;
        private System.Windows.Forms.Button filmekle_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fssifre_txt;
        private System.Windows.Forms.Button filmsil_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView filmler_dgv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button guncelle_b;
        private System.Windows.Forms.Label filminid_label;
        private System.Windows.Forms.Label yeniveri_label;
        private System.Windows.Forms.Label duzenle_label;
        public System.Windows.Forms.TextBox bdyeniveri_txt;
        public System.Windows.Forms.TextBox bdfilmid_txt;
        public System.Windows.Forms.ComboBox bd_cb;
        private System.Windows.Forms.TextBox fekacdk_txt;
        private System.Windows.Forms.TextBox feyassiniri_txt;
        private System.Windows.Forms.TextBox fefilmadi_txt;
        private System.Windows.Forms.TextBox fsfilmid_txt;
        private System.Windows.Forms.DateTimePicker fevbaslangict_dtp;
        private System.Windows.Forms.DateTimePicker fevbitist_dtp;
    }
}