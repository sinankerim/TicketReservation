namespace sinema_rezervasyon
{
    partial class seans_saatleri
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
            this.seanssaatleri_dgv = new System.Windows.Forms.DataGridView();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seanssaatleri_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // seanssaatleri_dgv
            // 
            this.seanssaatleri_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seanssaatleri_dgv.Location = new System.Drawing.Point(43, 12);
            this.seanssaatleri_dgv.Name = "seanssaatleri_dgv";
            this.seanssaatleri_dgv.Size = new System.Drawing.Size(300, 101);
            this.seanssaatleri_dgv.TabIndex = 0;
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.Location = new System.Drawing.Point(369, 32);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(132, 23);
            this.btn_duzenle.TabIndex = 1;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = true;
            this.btn_duzenle.Click += new System.EventHandler(this.btn_duzenle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Düzenlemeyi Bitir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seans_saatleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(513, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.seanssaatleri_dgv);
            this.Name = "seans_saatleri";
            this.Text = "seans_saatleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.seans_saatleri_FormClosed);
            this.Load += new System.EventHandler(this.seans_saatleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanssaatleri_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seanssaatleri_dgv;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.Button button1;
    }
}