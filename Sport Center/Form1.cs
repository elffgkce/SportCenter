using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Center
{
    public partial class Form1 : Form
    {
        SportCenterDbContext db = new SportCenterDbContext();
        public Form1()
        {

            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var kullanici = db.Staffs.Where(s => s.Staff_Username == txt_kullaniciAdi.Text
            && s.Staff_Password == txt_sifre.Text).FirstOrDefault();

            if (kullanici != null)
            {
                MessageBox.Show("Giriş başarılı!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }
    }
}
