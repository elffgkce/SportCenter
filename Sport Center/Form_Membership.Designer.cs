namespace Sport_Center
{
    partial class Form_Membership
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_page_title = new System.Windows.Forms.Label();
            this.pnl_form_card = new System.Windows.Forms.Panel();
            this.lbl_member = new System.Windows.Forms.Label();
            this.combo_member = new System.Windows.Forms.ComboBox();
            this.lbl_package = new System.Windows.Forms.Label();
            this.combo_package = new System.Windows.Forms.ComboBox();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_form_card.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sport Center — Üyelik Yönetimi";
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Load += new System.EventHandler(this.Form_Membership_Load);
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_main);

           
            this.pnl_sidebar.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.pnl_sidebar.Location = new System.Drawing.Point(0, 0);
            this.pnl_sidebar.Size = new System.Drawing.Size(220, 700);
            this.pnl_sidebar.Controls.Add(this.lbl_brand);
            this.pnl_sidebar.Controls.Add(this.lbl_brand_sub);
            this.pnl_sidebar.Controls.Add(this.pnl_nav_divider);
            this.pnl_sidebar.Controls.Add(this.btn_geri);

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
            this.lbl_brand_sub.Text = "Üyelikler";
            this.lbl_brand_sub.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lbl_brand_sub.ForeColor = System.Drawing.Color.FromArgb(140, 165, 210);
            this.lbl_brand_sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnl_nav_divider.BackColor = System.Drawing.Color.FromArgb(50, 70, 120);
            this.pnl_nav_divider.Location = new System.Drawing.Point(20, 102);
            this.pnl_nav_divider.Size = new System.Drawing.Size(180, 1);

            this.btn_geri.Location = new System.Drawing.Point(15, 620);
            this.btn_geri.Size = new System.Drawing.Size(190, 42);
            this.btn_geri.Text = "◀  Üye Yönetimine Dön";
            this.btn_geri.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(40, 65, 130);
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(55, 85, 160);
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);

            
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(245, 245, 250);
            this.pnl_main.Location = new System.Drawing.Point(220, 0);
            this.pnl_main.Size = new System.Drawing.Size(980, 700);
            this.pnl_main.Controls.Add(this.lbl_page_title);
            this.pnl_main.Controls.Add(this.pnl_form_card);
            this.pnl_main.Controls.Add(this.dataGridView1);

            this.lbl_page_title.AutoSize = false;
            this.lbl_page_title.Size = new System.Drawing.Size(940, 40);
            this.lbl_page_title.Location = new System.Drawing.Point(20, 18);
            this.lbl_page_title.Text = "Üyelik Yönetimi";
            this.lbl_page_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_page_title.ForeColor = System.Drawing.Color.FromArgb(24, 40, 80);

            
            this.pnl_form_card.BackColor = System.Drawing.Color.White;
            this.pnl_form_card.Location = new System.Drawing.Point(20, 68);
            this.pnl_form_card.Size = new System.Drawing.Size(940, 110);
            this.pnl_form_card.Controls.Add(this.lbl_member);
            this.pnl_form_card.Controls.Add(this.combo_member);
            this.pnl_form_card.Controls.Add(this.lbl_package);
            this.pnl_form_card.Controls.Add(this.combo_package);
            this.pnl_form_card.Controls.Add(this.pnl_buttons);

            this.lbl_member.AutoSize = false;
            this.lbl_member.Size = new System.Drawing.Size(280, 18);
            this.lbl_member.Location = new System.Drawing.Point(16, 14);
            this.lbl_member.Text = "Üye";
            this.lbl_member.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_member.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            this.combo_member.Location = new System.Drawing.Point(16, 34);
            this.combo_member.Size = new System.Drawing.Size(280, 28);
            this.combo_member.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_member.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.combo_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_member.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lbl_package.AutoSize = false;
            this.lbl_package.Size = new System.Drawing.Size(280, 18);
            this.lbl_package.Location = new System.Drawing.Point(316, 14);
            this.lbl_package.Text = "Paket";
            this.lbl_package.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lbl_package.ForeColor = System.Drawing.Color.FromArgb(60, 70, 100);

            this.combo_package.Location = new System.Drawing.Point(316, 34);
            this.combo_package.Size = new System.Drawing.Size(280, 28);
            this.combo_package.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_package.BackColor = System.Drawing.Color.FromArgb(247, 248, 252);
            this.combo_package.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_package.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            
            this.pnl_buttons.Location = new System.Drawing.Point(16, 74);
            this.pnl_buttons.Size = new System.Drawing.Size(908, 26);
            this.pnl_buttons.BackColor = System.Drawing.Color.White;
            this.pnl_buttons.Controls.Add(this.btn_listele);
            this.pnl_buttons.Controls.Add(this.btn_ekle);
            this.pnl_buttons.Controls.Add(this.btn_sil);

            this.btn_listele.Location = new System.Drawing.Point(0, 0);
            this.btn_listele.Size = new System.Drawing.Size(130, 32);
            this.btn_listele.Text = "Listele";
            this.btn_listele.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_listele.ForeColor = System.Drawing.Color.White;
            this.btn_listele.BackColor = System.Drawing.Color.FromArgb(24, 40, 80);
            this.btn_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listele.FlatAppearance.BorderSize = 0;
            this.btn_listele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 65, 130);
            this.btn_listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);

            this.btn_ekle.Location = new System.Drawing.Point(140, 0);
            this.btn_ekle.Size = new System.Drawing.Size(130, 32);
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(22, 110, 70);
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.FlatAppearance.BorderSize = 0;
            this.btn_ekle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 140, 90);
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);

            this.btn_sil.Location = new System.Drawing.Point(280, 0);
            this.btn_sil.Size = new System.Drawing.Size(130, 32);
            this.btn_sil.Text = "Sil";
            this.btn_sil.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(180, 40, 40);
            this.btn_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sil.FlatAppearance.BorderSize = 0;
            this.btn_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(210, 55, 55);
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);

            
            this.dataGridView1.Location = new System.Drawing.Point(20, 192);
            this.dataGridView1.Size = new System.Drawing.Size(940, 480);
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

            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.pnl_form_card.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lbl_member;
        private System.Windows.Forms.Label lbl_package;
        private System.Windows.Forms.ComboBox combo_member;
        private System.Windows.Forms.ComboBox combo_package;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}