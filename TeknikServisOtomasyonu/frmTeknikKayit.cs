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
    public partial class frmTeknikKayit : Form
    {
        TeknikServisContext db = new TeknikServisContext();
        public frmTeknikKayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
          
            Kayit kyt = new Kayit();

            kyt.musteriID = Convert.ToInt32(dataGridViewMusteri.CurrentRow.Cells["musteriID"].Value);
            if (kyt.musteriID == null)
            {
                MessageBox.Show("LÜTFEN DOĞRU ID SEC");
            }

            kyt.personelID = Program.personel.personelID;
            kyt.markaID = (int)comboBoxMarka.SelectedValue;
            kyt.ad = comboBoxMarka.Text;
            kyt.problem = txtProblem.Text;
            kyt.teslimTarihi = dateTimePickerTSLM.Value;
            kyt.alisTarihi = DateTime.Now;
            if (evet.Checked)
            {
                kyt.garantiliMi = true;
            }
            else if (hayir.Checked)
            {
                kyt.garantiliMi = false;
            }
            kyt.tutar = Convert.ToDecimal(txtmoney.Text);
            kyt.aciklama = txtAciklama.Text;
            kyt.durum = txtDurum.Text;


            if (kyt.personelID==null || kyt.markaID==null || kyt.ad==null ||kyt.problem==null||kyt.teslimTarihi==null||kyt.alisTarihi==null||kyt.garantiliMi==evet.Checked||kyt.garantiliMi==hayir.Checked || kyt.tutar==null ||kyt.aciklama==null || kyt.durum==null)
            {
                MessageBox.Show("Lütfen Gerekli Yerlere DOLDURUN");
            }
            else 
            {

                db.Kayit.Add(kyt);
                db.SaveChanges(); 
            }
        }

        private void frmTeknikKayit_Load(object sender, EventArgs e)
        {
            Doldur();
             
            var listeMarka = db.Marka.ToList();
            comboBoxMarka.DataSource = listeMarka;
            comboBoxMarka.DisplayMember = "ad";
            comboBoxMarka.ValueMember = "markaID";
            Marka marka = new Marka();
            marka.markaID = (int)comboBoxMarka.SelectedValue;

        }

        private void Doldur()
        {
            var liste = db.Musteri.Select(x => new { x.musteriID,x.ad, x.soyad,x.PersonelID }).ToList();
           dataGridViewMusteri.DataSource = liste;
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.Show();
            this.Hide();
        }

        private void btnISLEMgit_Click(object sender, EventArgs e)
        {
            frmIslem frm = new frmIslem();
            frm.Show();
            this.Hide();
        }

        private void btnTeknikKayıt_Click(object sender, EventArgs e)
        {
            frmKayitEkranı frm = new frmKayitEkranı();
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
