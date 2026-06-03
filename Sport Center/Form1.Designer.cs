namespace Sport_Center
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_left = new System.Windows.Forms.Panel();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_slogan = new System.Windows.Forms.Label();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_subtitle = new System.Windows.Forms.Label();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.pnl_divider = new System.Windows.Forms.Panel();
            this.pnl_left.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.SuspendLayout();

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Center — Giriş";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_divider);
            this.Controls.Add(this.pnl_right);

            
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Size = new System.Drawing.Size(380, 560);
            this.pnl_left.Controls.Add(this.lbl_brand);
            this.pnl_left.Controls.Add(this.lbl_slogan);

           
            this.lbl_brand.AutoSize = false;
            this.lbl_brand.Size = new System.Drawing.Size(340, 60);
            this.lbl_brand.Location = new System.Drawing.Point(20, 220);
            this.lbl_brand.Text = "⚡ SPORT CENTER";
            this.lbl_brand.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_brand.ForeColor = System.Drawing.Color.White;
            this.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.lbl_slogan.AutoSize = false;
            this.lbl_slogan.Size = new System.Drawing.Size(340, 40);
            this.lbl_slogan.Location = new System.Drawing.Point(20, 290);
            this.lbl_slogan.Text = "Yönetim Paneline Hoş Geldiniz";
            this.lbl_slogan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lbl_slogan.ForeColor = System.Drawing.Color.FromArgb(160, 180, 220);
            this.lbl_slogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            this.pnl_divider.BackColor = System.Drawing.Color.FromArgb(210, 215, 230);
            this.pnl_divider.Location = new System.Drawing.Point(380, 0);
            this.pnl_divider.Size = new System.Drawing.Size(1, 560);

            
            this.pnl_right.BackColor = System.Drawing.Color.White;
            this.pnl_right.Location = new System.Drawing.Point(381, 0);
            this.pnl_right.Size = new System.Drawing.Size(519, 560);
            this.pnl_right.Controls.Add(this.lbl_welcome);
            this.pnl_right.Controls.Add(this.lbl_subtitle);
            this.pnl_right.Controls.Add(this.lbl_kullaniciAdi);
            this.pnl_right.Controls.Add(this.txt_kullaniciAdi);
            this.pnl_right.Controls.Add(this.lbl_sifre);
            this.pnl_right.Controls.Add(this.txt_sifre);
            this.pnl_right.Controls.Add(this.btn_giris);

            
            this.lbl_welcome.AutoSize = false;
            this.lbl_welcome.Size = new System.Drawing.Size(380, 45);
            this.lbl_welcome.Location = new System.Drawing.Point(65, 100);
            this.lbl_welcome.Text = "Giriş Yap";
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(24, 40, 80);

            
            this.lbl_subtitle.AutoSize = false;
            this.lbl_subtitle.Size = new System.Drawing.Size(380, 30);
            this.lbl_subtitle.Location = new System.Drawing.Point(65, 150);
            this.lbl_subtitle.Text = "Hesabınıza erişmek için bilgilerinizi girin.";
            this.lbl_subtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lbl_subtitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);

            
            this.lbl_kullaniciAdi.AutoSize = false;
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(380, 22);
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(65, 220);
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_kullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

           
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(65, 246);
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(380, 38);
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_kullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(30, 40, 70);
            this.txt_kullaniciAdi.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.txt_kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            
            this.lbl_sifre.AutoSize = false;
            this.lbl_sifre.Size = new System.Drawing.Size(380, 22);
            this.lbl_sifre.Location = new System.Drawing.Point(65, 308);
            this.lbl_sifre.Text = "Şifre";
            this.lbl_sifre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_sifre.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            
            this.txt_sifre.Location = new System.Drawing.Point(65, 334);
            this.txt_sifre.Size = new System.Drawing.Size(380, 38);
            this.txt_sifre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_sifre.ForeColor = System.Drawing.Color.FromArgb(30, 40, 70);
            this.txt_sifre.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.txt_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sifre.PasswordChar = '●';

           
            this.btn_giris.Location = new System.Drawing.Point(65, 408);
            this.btn_giris.Size = new System.Drawing.Size(380, 46);
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_giris.ForeColor = System.Drawing.Color.White;
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 65, 130);
            this.btn_giris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(15, 28, 60);
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);

            this.pnl_left.ResumeLayout(false);
            this.pnl_right.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_divider;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_slogan;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_subtitle;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}