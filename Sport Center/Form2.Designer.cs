namespace Sport_Center
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_sidebar = new System.Windows.Forms.Panel();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.lbl_brand_sub = new System.Windows.Forms.Label();
            this.pnl_nav_divider = new System.Windows.Forms.Panel();
            this.btn_form3 = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_page_title = new System.Windows.Forms.Label();
            this.pnl_form_card = new System.Windows.Forms.Panel();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_stats = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_form_card.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_stats.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Center — Üye Yönetimi";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_main);

           
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Size = new System.Drawing.Size(220, 700);
            this.pnl_sidebar.Controls.Add(this.lbl_brand);
            this.pnl_sidebar.Controls.Add(this.lbl_brand_sub);
            this.pnl_sidebar.Controls.Add(this.pnl_nav_divider);
            this.pnl_sidebar.Controls.Add(this.btn_form3);

            this.lbl_brand.AutoSize = false;
            this.lbl_brand.Size = new System.Drawing.Size(200, 36);
            this.lbl_brand.Location = new System.Drawing.Point(10, 30);
            this.lbl_brand.Text = "⚡ SPORT CENTER";
            this.lbl_brand.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_brand.ForeColor = System.Drawing.Color.White;
            this.lbl_brand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lbl_brand_sub.AutoSize = false;
            this.lbl_brand_sub.Size = new System.Drawing.Size(200, 22);
            this.lbl_brand_sub.Location = new System.Drawing.Point(10, 68);
            this.lbl_brand_sub.Text = "Üyeler";
            this.lbl_brand_sub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_brand_sub.ForeColor = System.Drawing.Color.FromArgb(140, 165, 210);
            this.lbl_brand_sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnl_nav_divider.BackColor = System.Drawing.Color.FromArgb(50, 70, 120);
            this.pnl_nav_divider.Location = new System.Drawing.Point(20, 102);
            this.pnl_nav_divider.Size = new System.Drawing.Size(180, 1);

            this.btn_form3.Location = new System.Drawing.Point(15, 620);
            this.btn_form3.Size = new System.Drawing.Size(190, 42);
            this.btn_form3.Text = "📋  Üyelik Yönetimi";
            this.btn_form3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_form3.ForeColor = System.Drawing.Color.White;
            this.btn_form3.BackColor = System.Drawing.Color.FromArgb(40, 65, 130);
            this.btn_form3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form3.FlatAppearance.BorderSize = 0;
            this.btn_form3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 85, 160);
            this.btn_form3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form3.Click += new System.EventHandler(this.btn_form3_Click);

            
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.pnl_main.Location = new System.Drawing.Point(220, 0);
            this.pnl_main.Size = new System.Drawing.Size(980, 700);
            this.pnl_main.Controls.Add(this.lbl_page_title);
            this.pnl_main.Controls.Add(this.pnl_form_card);
            this.pnl_main.Controls.Add(this.dataGridView1);
            this.pnl_main.Controls.Add(this.pnl_stats);

            this.lbl_page_title.AutoSize = false;
            this.lbl_page_title.Size = new System.Drawing.Size(940, 40);
            this.lbl_page_title.Location = new System.Drawing.Point(20, 18);
            this.lbl_page_title.Text = "Üye Yönetimi";
            this.lbl_page_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_page_title.ForeColor = System.Drawing.Color.FromArgb(24, 40, 80);

            
            this.pnl_form_card.BackColor = System.Drawing.Color.White;
            this.pnl_form_card.Location = new System.Drawing.Point(20, 68);
            this.pnl_form_card.Size = new System.Drawing.Size(940, 130);
            this.pnl_form_card.Controls.Add(this.lbl_isim);
            this.pnl_form_card.Controls.Add(this.txt_isim);
            this.pnl_form_card.Controls.Add(this.lbl_soyisim);
            this.pnl_form_card.Controls.Add(this.txt_soyisim);
            this.pnl_form_card.Controls.Add(this.lbl_email);
            this.pnl_form_card.Controls.Add(this.txt_email);
            this.pnl_form_card.Controls.Add(this.lbl_telefon);
            this.pnl_form_card.Controls.Add(this.txt_telefon);
            this.pnl_form_card.Controls.Add(this.pnl_buttons);

      
            this.lbl_isim.AutoSize = false;
            this.lbl_isim.Size = new System.Drawing.Size(180, 18);
            this.lbl_isim.Location = new System.Drawing.Point(16, 14);
            this.lbl_isim.Text = "Ad";
            this.lbl_isim.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_isim.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            this.txt_isim.Location = new System.Drawing.Point(16, 34);
            this.txt_isim.Size = new System.Drawing.Size(180, 28);
            this.txt_isim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_isim.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.txt_isim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

        
            this.lbl_soyisim.AutoSize = false;
            this.lbl_soyisim.Size = new System.Drawing.Size(180, 18);
            this.lbl_soyisim.Location = new System.Drawing.Point(210, 14);
            this.lbl_soyisim.Text = "Soyad";
            this.lbl_soyisim.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_soyisim.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            this.txt_soyisim.Location = new System.Drawing.Point(210, 34);
            this.txt_soyisim.Size = new System.Drawing.Size(180, 28);
            this.txt_soyisim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_soyisim.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.txt_soyisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

           
            this.lbl_email.AutoSize = false;
            this.lbl_email.Size = new System.Drawing.Size(200, 18);
            this.lbl_email.Location = new System.Drawing.Point(404, 14);
            this.lbl_email.Text = "E-posta";
            this.lbl_email.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            this.txt_email.Location = new System.Drawing.Point(404, 34);
            this.txt_email.Size = new System.Drawing.Size(200, 28);
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            
            this.lbl_telefon.AutoSize = false;
            this.lbl_telefon.Size = new System.Drawing.Size(180, 18);
            this.lbl_telefon.Location = new System.Drawing.Point(618, 14);
            this.lbl_telefon.Text = "Telefon";
            this.lbl_telefon.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_telefon.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            this.txt_telefon.Location = new System.Drawing.Point(618, 34);
            this.txt_telefon.Size = new System.Drawing.Size(180, 28);
            this.txt_telefon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_telefon.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.txt_telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            
            this.pnl_buttons.Location = new System.Drawing.Point(16, 76);
            this.pnl_buttons.Size = new System.Drawing.Size(908, 40);
            this.pnl_buttons.BackColor = System.Drawing.Color.White;
            this.pnl_buttons.Controls.Add(this.btn_listele);
            this.pnl_buttons.Controls.Add(this.btn_ekle);
            this.pnl_buttons.Controls.Add(this.btn_guncelle);
            this.pnl_buttons.Controls.Add(this.btn_sil);

            this.btn_listele.Location = new System.Drawing.Point(0, 4);
            this.btn_listele.Size = new System.Drawing.Size(130, 34);
            this.btn_listele.Text = "Listele";
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 65, 130);
            this.btn_listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);

            this.btn_ekle.Location = new System.Drawing.Point(140, 4);
            this.btn_ekle.Size = new System.Drawing.Size(130, 34);
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(22, 110, 70);
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 140, 90);
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);

            this.btn_guncelle.Location = new System.Drawing.Point(280, 4);
            this.btn_guncelle.Size = new System.Drawing.Size(130, 34);
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(160, 110, 20);
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.FlatAppearance.BorderSize = 0;
            this.btn_guncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(190, 135, 30);
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);

            this.btn_sil.Location = new System.Drawing.Point(420, 4);
            this.btn_sil.Size = new System.Drawing.Size(130, 34);
            this.btn_sil.Text = "Sil";
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 55, 55);
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);

            
            this.dataGridView1.Location = new System.Drawing.Point(20, 212);
            this.dataGridView1.Size = new System.Drawing.Size(940, 340);
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(230, 232, 240);
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 220, 245);
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            this.pnl_stats.BackColor = System.Drawing.Color.White;
            this.pnl_stats.Location = new System.Drawing.Point(20, 566);
            this.pnl_stats.Size = new System.Drawing.Size(940, 110);
            this.pnl_stats.Controls.Add(this.groupBox2);

            this.groupBox2.Location = new System.Drawing.Point(10, 8);
            this.groupBox2.Size = new System.Drawing.Size(918, 90);
            this.groupBox2.Text = "İstatistikler";
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.groupBox2.Controls.Add(this.rd_1);
            this.groupBox2.Controls.Add(this.rd_2);
            this.groupBox2.Controls.Add(this.lbl_1);
            this.groupBox2.Controls.Add(this.lbl_2);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);

            this.rd_1.AutoSize = true;
            this.rd_1.Location = new System.Drawing.Point(14, 30);
            this.rd_1.Text = "En çok üyelik alan üye";
            this.rd_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rd_1.ForeColor = System.Drawing.Color.FromArgb(40, 50, 80);
            this.rd_1.CheckedChanged += new System.EventHandler(this.rd_1_CheckedChanged);

            this.rd_2.AutoSize = true;
            this.rd_2.Location = new System.Drawing.Point(14, 56);
            this.rd_2.Text = "En yüksek gelir getiren paket";
            this.rd_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rd_2.ForeColor = System.Drawing.Color.FromArgb(40, 50, 80);
            this.rd_2.CheckedChanged += new System.EventHandler(this.rd_2_CheckedChanged);

            this.lbl_1.AutoSize = false;
            this.lbl_1.Size = new System.Drawing.Size(600, 22);
            this.lbl_1.Location = new System.Drawing.Point(260, 30);
            this.lbl_1.Text = "";
            this.lbl_1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_1.ForeColor = System.Drawing.Color.FromArgb(24, 40, 80);

            this.lbl_2.AutoSize = false;
            this.lbl_2.Size = new System.Drawing.Size(600, 22);
            this.lbl_2.Location = new System.Drawing.Point(260, 56);
            this.lbl_2.Text = "";
            this.lbl_2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lbl_2.ForeColor = System.Drawing.Color.FromArgb(24, 40, 80);

            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_form_card.ResumeLayout(false);
            this.pnl_form_card.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_stats.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_sidebar;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_nav_divider;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.Label lbl_brand_sub;
        private System.Windows.Forms.Label lbl_page_title;
        private System.Windows.Forms.Panel pnl_form_card;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefon;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnl_stats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_1;
        private System.Windows.Forms.RadioButton rd_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Button btn_form3;
    }
}