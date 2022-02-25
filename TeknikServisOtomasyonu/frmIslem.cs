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
    public partial class frmIslem : Form
    {
        TeknikServisContext db = new TeknikServisContext();
        public frmIslem()
        {
            InitializeComponent();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            Islem islemTBL = new Islem();
            islemTBL.kayitID = Convert.ToInt32(dataGridViewTeknikKayit.CurrentRow.Cells["kayitID"].Value);
        
            if (islemTBL.kayitID == null)
            {
             MessageBox.Show("LÜTFEN DOĞRU ID SEC");
            }

           
                islemTBL.personelID = Program.personel.personelID;
                islemTBL.islemTurID = Convert.ToInt32(comboBoxIslemTürü.SelectedValue);
                islemTBL.aciklama = txtAciklama.Text;
                islemTBL.islemTarihi = DateTime.Now;
                islemTBL.ucret = Convert.ToDecimal(txtMoney.Text);

            if (islemTBL.personelID==null || islemTBL.islemTurID==null || islemTBL.aciklama==""||islemTBL.islemTarihi==null ||islemTBL.ucret==null)
            {
                MessageBox.Show("LÜTFEN tüm Yerleri Doldurun");
            }
            else
            {
                db.Islem.Add(islemTBL);
                db.SaveChanges();
                MessageBox.Show("İşlem Başarı ile Gerçekleşti");
            }
          
          
           
          
        }

        private void frmIslem_Load(object sender, EventArgs e)
        {
            IslemTur istür = new IslemTur();

            Doldur(); // Datagride e verileri getirme 
            var listeMarka = db.IslemTur.ToList();
            comboBoxIslemTürü.DataSource = listeMarka;
            comboBoxIslemTürü.DisplayMember = "ad";
            comboBoxIslemTürü.ValueMember = "islemTurId";
            int dgr = Convert.ToInt32(comboBoxIslemTürü.SelectedValue);//islem türünün İD sine uşatık
        }

        private void Doldur()
        {
            var liste = db.Kayit.Select(x => new { x.kayitID, x.tutar, x.ad, x.garantiliMi, x.alisTarihi, x.teslimTarihi, x.problem, x.aciklama, x.durum }).ToList();
            dataGridViewTeknikKayit.DataSource = liste;
        }

        private void comboBoxIslemTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            IslemTur islem = (IslemTur)comboBoxIslemTürü.SelectedItem;
            txtMoney.Text = islem.ucret.ToString(); ;
        }

        private void btnKayitDNS_Click(object sender, EventArgs e)
        {
            frmTeknikKayit frm = new frmTeknikKayit();
             frm.Show();
            this.Hide();
        }

        private void btnMusteriKYT_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
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


