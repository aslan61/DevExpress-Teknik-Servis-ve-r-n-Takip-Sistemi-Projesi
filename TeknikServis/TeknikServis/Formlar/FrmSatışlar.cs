using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmSatışlar : Form
    {
        public FrmSatışlar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void Listele()
        {
            var degerler = from x in db.TBLURUNHAREKET
                           select new
                           {
                               x.HAREKETID,
                               x.TBLURUN.AD,
                               MUSTERI = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.TARIH,
                               x.ADET,
                               x.FIYAT,
                               x.URUNSERINO
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmSatışlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
