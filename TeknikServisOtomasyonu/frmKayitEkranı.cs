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
    public partial class frmKayitEkranı : Form
    {
        TeknikServisContext db = new TeknikServisContext();
        public frmKayitEkranı()
        {
            InitializeComponent();
        }

        private void frmKayitEkranı_Load(object sender, EventArgs e)
        {
            Doldur();
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int dgr = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var sil = db.Kayit.Where(w => w.kayitID == dgr).FirstOrDefault();
            db.Kayit.Remove(sil);
            db.SaveChanges();

            Doldur();
        }
        private void Doldur()
        {
            var liste = db.Kayit.Select(x => new {x.kayitID, x.musteriID, x.personelID, x.ad, x.problem, x.alisTarihi, x.teslimTarihi, x.garantiliMi, x.tutar, x.aciklama, x.durum }).ToList();
            dataGridView1.DataSource = liste;
        }

        private void btnKYTgit_Click(object sender, EventArgs e)
        {
            frmKayitEkranı frm = new frmKayitEkranı();
            frm.Show();
            this.Hide();
        }

        private void btnISLEMgit_Click(object sender, EventArgs e)
        {
            frmIslem frm = new frmIslem();
            frm.Show();
            this.Hide();
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            FrmAnasayfa frm = new FrmAnasayfa();
            frm.Show();
            this.Hide();

        }
    }
}
