using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Sport_Center
{
    public partial class Form_Membership : Form
    {
        SportCenterDbContext db = new SportCenterDbContext();
        public Form_Membership()
        {
            InitializeComponent();
        }

        private void Form_Membership_Load(object sender, EventArgs e)
        {
            combo_member.DataSource = db.Members.ToList();
            combo_member.DisplayMember = "Member_Name";
            combo_member.ValueMember = "Member_Id";

            combo_package.DataSource = db.Packages.ToList();
            combo_package.DisplayMember = "Package_Name";
            combo_package.ValueMember = "Package_Id";

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.Memberships
                    .Include(m => m.Member)
                    .Include(m => m.Package)
                    .Select(m => new
                    {
                        Membership_Id = m.Membership_Id,
                        ÜyeAdı = m.Member.Member_Name,
                        ÜyeSoyadı = m.Member.Member_Surname,
                        PaketAdı = m.Package.Package_Name,
                        PaketFiyatı = m.Package.Package_Price,
                        BaşlangıçTarihi = m.Start_Date,
                        BitişTarihi = m.End_Date
                    }).ToList();

                dataGridView1.DataSource = list;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns["Membership_Id"].Visible = false;

                dataGridView1.Columns["ÜyeAdı"].HeaderText = "Üye Adı";
                dataGridView1.Columns["ÜyeSoyadı"].HeaderText = "Üye Soyadı";
                dataGridView1.Columns["PaketAdı"].HeaderText = "Paket Adı";
                dataGridView1.Columns["PaketFiyatı"].HeaderText = "Paket Fiyatı";
                dataGridView1.Columns["BaşlangıçTarihi"].HeaderText = "Başlangıç Tarihi";
                dataGridView1.Columns["BitişTarihi"].HeaderText = "Bitiş Tarihi";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Membership ms = new Membership();
                ms.Member_Id = (int)combo_member.SelectedValue;
                ms.Package_Id = (int)combo_package.SelectedValue;
                ms.Start_Date = DateTime.Now;
                ms.End_Date = DateTime.Now.AddMonths(1);
                db.Memberships.Add(ms);
                db.SaveChanges();

                MessageBox.Show("Üyelik eklendi.");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult sonuc = MessageBox.Show(
                    "Bu üyeliği silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Membership_Id"].Value);
                        var recordToDelete = db.Memberships.Find(selectedId);
                        if (recordToDelete != null)
                        {
                            db.Memberships.Remove(recordToDelete);
                            db.SaveChanges();

                            MessageBox.Show("Üyelik silindi.");
                            btn_listele.PerformClick();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
            this.Close();
        }
    }
}
