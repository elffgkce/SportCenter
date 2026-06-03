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
    public partial class Form2 : Form
    {
        SportCenterDbContext db = new SportCenterDbContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                var members = db.Members.ToList();
                dataGridView1.DataSource = members;

                dataGridView1.Columns["Member_Id"].HeaderText = "Üye ID";
                dataGridView1.Columns["Member_Name"].HeaderText = "Üye Adı";
                dataGridView1.Columns["Member_Surname"].HeaderText = "Üye Soyadı";
                dataGridView1.Columns["Member_Email"].HeaderText = "E-posta";
                dataGridView1.Columns["Member_Phone"].HeaderText = "Telefon";



                dataGridView1.Columns["Member_Id"].Visible = false;

                dataGridView1.Columns["Memberships"].Visible = false;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üyeler listelenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member
                {
                    Member_Name = txt_isim.Text,
                    Member_Surname = txt_soyisim.Text,
                    Member_Email = txt_email.Text,
                    Member_Phone = txt_telefon.Text
                };

                db.Members.Add(newMember);
                db.SaveChanges();

                MessageBox.Show("Yeni üye eklendi!");
                btn_listele.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_isim.Text = dataGridView1.Rows[e.RowIndex].Cells["Member_Name"].Value.ToString();
                txt_soyisim.Text = dataGridView1.Rows[e.RowIndex].Cells["Member_Surname"].Value.ToString();
                txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells["Member_Email"].Value.ToString();
                txt_telefon.Text = dataGridView1.Rows[e.RowIndex].Cells["Member_Phone"].Value.ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Member_Id"].Value);
                    Member member = db.Members.Find(selectedId);
                    if (member != null)
                    {
                        member.Member_Name = txt_isim.Text;
                        member.Member_Surname = txt_soyisim.Text;
                        member.Member_Email = txt_email.Text;
                        member.Member_Phone = txt_telefon.Text;
                        db.SaveChanges();
                        MessageBox.Show("Üye bilgileri güncellendi!");
                        btn_listele.PerformClick();
                    }
                }
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
                    "Bu üyeyi silmek istediğinize emin misiniz?",
                    "Üye Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    if (dataGridView1.CurrentRow != null)
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Member_Id"].Value);
                        Member member = db.Members.Find(selectedId);
                        if (member != null)
                        {
                            db.Members.Remove(member);
                            db.SaveChanges();
                            MessageBox.Show("Üye silindi!");
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

        private void btn_form3_Click(object sender, EventArgs e)
        {
            Form_Membership form3 = new Form_Membership();
            this.Hide();
            form3.ShowDialog();
            this.Close();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_1.Checked)
                {
                    var result = db.Memberships
                        .Include(m => m.Member)
                        .GroupBy(m => new
                        {
                            m.Member.Member_Id,
                            m.Member.Member_Name,
                            m.Member.Member_Surname
                        })
                        .Select(g => new
                        {
                            FullName = g.Key.Member_Name + " " + g.Key.Member_Surname,
                            TotalCount = g.Count()
                        })
                        .OrderByDescending(x => x.TotalCount)
                        .FirstOrDefault();

                    if (result != null)
                        lbl_1.Text = $"{result.FullName} {result.TotalCount} üyelik almış";
                    else
                        lbl_1.Text = "Kayıt bulunamadı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }

        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rd_2.Checked)
                {
                    var result = db.Memberships
                        .Include(m => m.Package)
                        .GroupBy(m => new
                        {
                            m.Package.Package_Name
                        })
                        .Select(g => new
                        {
                            PackageName = g.Key.Package_Name,
                            TotalPrice = g.Sum(m => m.Package.Package_Price)
                        })
                        .OrderByDescending(x => x.TotalPrice)
                        .FirstOrDefault();

                    if (result != null)
                        lbl_2.Text = $"{result.PackageName} toplam {result.TotalPrice} TL";
                    else
                        lbl_2.Text = "Kayıt bulunamadı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata = {ex.Message}");
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    } 
}
