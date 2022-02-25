using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeknikServisOtomasyonu.Model;

namespace TeknikServisOtomasyonu
{
    public partial class FrmPersonelGiris : Form
    {
        public FrmPersonelGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            TeknikServisContext db = new TeknikServisContext();
            //String sifreli = Program.MD5Sifrele(txtSifre.Text);
            Personel p = db.Personel.Where(x=>x.eposta==txtEposta.Text && x.sifre==txtSifre.Text).SingleOrDefault();

            if (p==null)
            {
                MessageBox.Show("Başarısız Giriş Yaparsın bea, Az dikkatli ol");
            }

            else
            {
                Program.personel = p;
                MessageBox.Show(p.ad+" "+p.soyad+" "+"Oş Gelmişssin Yiğidim");
                FrmAnasayfa frm = new FrmAnasayfa();
                frm.Show();
                this.Hide();
            }

        }
    }
}
