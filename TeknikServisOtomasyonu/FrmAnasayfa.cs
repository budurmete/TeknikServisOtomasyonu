using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServisOtomasyonu
{
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            frmMusteriKayit frm = new frmMusteriKayit();
            frm.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmTeknikKayit frm = new frmTeknikKayit();
            frm.Show();
            this.Hide();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            frmIslem frm = new frmIslem();
            frm.Show();
            this.Hide();
        }
    }
}
