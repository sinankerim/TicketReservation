namespace sinema_rezervasyon
{
    partial class giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.kadi_label = new System.Windows.Forms.Label();
            this.sifre_label = new System.Windows.Forms.Label();
            this.girisyap_b = new System.Windows.Forms.Button();
            this.kadi_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz. Lütfen giriş yapınız.";
            // 
            // kadi_label
            // 
            this.kadi_label.AutoSize = true;
            this.kadi_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kadi_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kadi_label.Location = new System.Drawing.Point(12, 75);
            this.kadi_label.Name = "kadi_label";
            this.kadi_label.Size = new System.Drawing.Size(122, 22);
            this.kadi_label.TabIndex = 0;
            this.kadi_label.Text = "Kullanıcı Adı:";
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sifre_label.Location = new System.Drawing.Point(12, 107);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(55, 22);
            this.sifre_label.TabIndex = 0;
            this.sifre_label.Text = "Şifre:";
            // 
            // girisyap_b
            // 
            this.girisyap_b.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisyap_b.Location = new System.Drawing.Point(140, 137);
            this.girisyap_b.Name = "girisyap_b";
            this.girisyap_b.Size = new System.Drawing.Size(150, 23);
            this.girisyap_b.TabIndex = 3;
            this.girisyap_b.Text = "GİRİŞ YAP";
            this.girisyap_b.UseVisualStyleBackColor = true;
            this.girisyap_b.Click += new System.EventHandler(this.girisyap_b_Click);
            // 
            // kadi_txt
            // 
            this.kadi_txt.Location = new System.Drawing.Point(140, 79);
            this.kadi_txt.Name = "kadi_txt";
            this.kadi_txt.Size = new System.Drawing.Size(150, 20);
            this.kadi_txt.TabIndex = 1;
            this.kadi_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kadi_txt_KeyPress);
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(140, 107);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(150, 20);
            this.sifre_txt.TabIndex = 2;
            this.sifre_txt.UseSystemPasswordChar = true;
            this.sifre_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sifre_txt_KeyPress);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(451, 199);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kadi_txt);
            this.Controls.Add(this.girisyap_b);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.kadi_label);
            this.Controls.Add(this.label1);
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kadi_label;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.Button girisyap_b;
        private System.Windows.Forms.TextBox sifre_txt;
        public System.Windows.Forms.TextBox kadi_txt;
    }
}