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
    public partial class frmMusteriKayit : Form
    {
        TeknikServisContext db = new TeknikServisContext();
        public frmMusteriKayit()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            var kontrol = db.Musteri.Where(m => m.ad == txtAd.Text && m.soyad == txtSoyad.Text && m.adres==txtAdres.Text && m.telefon==txtTelefon.Text).ToList();
            Musteri uye = new Musteri();

            uye.ad = txtAd.Text;
            uye.soyad = txtSoyad.Text;
            uye.adres = txtAdres.Text;
            uye.telefon =txtTelefon.Text;
            uye.kayitTarihi = DateTime.Now;
            uye.PersonelID = Program.personel.personelID;

            if (uye.ad == "" || uye.soyad == "" || uye.adres == "" || uye.telefon == "" || uye.kayitTarihi == null || uye.PersonelID == null)
            {
                MessageBox.Show("Lütfen Gerekleri Bilgileri doldurun");
            }

            else
            {
                db.Musteri.Add(uye);
                db.SaveChanges();
            }
            
           
        
            Doldur();
        }

        private void frmMusteriKayit_Load(object sender, EventArgs e)
        {

            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string dgr = DGRKayit.CurrentRow.Cells[0].Value.ToString();
            var sil = db.Musteri.Where(w=> w.ad==dgr).FirstOrDefault();
            if (txtAd.Text=="" || txtSoyad.Text=="")
            {
                MessageBox.Show("Abe eyyy Madem Adamı Silecen adını ve soyadını girip silsene bozacan elaleimn şeyini");
            }

            else
            {
                db.Musteri.Remove(sil);
                db.SaveChanges();
            }
           
           
            Doldur();
        }

        private void Doldur ()
        {
            var liste = db.Musteri.Select(x=> new { x.ad,x.soyad,x.adres,x.kayitTarihi,x.PersonelID }).ToList();
            DGRKayit.DataSource = liste;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           var gnc = db.Musteri.Where(m => m.ad == txtAd.Text || m.soyad == txtSoyad.Text ).FirstOrDefault();

            if (gnc == null)
            {
                MessageBox.Show("Lütfen Güncelleme yapmak istediğiniz Kişinin AD'Inı VEYA SOYAD'ını Doğru Giriniz ");
                return;
               
            }

            gnc.ad = txtAd.Text;
            gnc.soyad = txtSoyad.Text;
            gnc.adres = txtAdres.Text;
            gnc.telefon = txtTelefon.Text;
            db.SaveChanges();
            foreach ( Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
                
            }
            Doldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeknikKayit frm = new frmTeknikKayit();
            frm.Show();
            this.Hide();
        }
    }
}
