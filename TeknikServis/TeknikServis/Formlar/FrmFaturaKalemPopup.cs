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
    public partial class FrmFaturaKalemPopup : Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }
        public int id;
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            DBTeknikServisEntities db = new DBTeknikServisEntities();
            gridControl1.DataSource = (from u in db.TBLFATURABILGI.Where(x => x.ID == id)
                                       select new
                                       {
                                           u.ID,
                                           u.SERI,
                                           u.SIRANO,
                                           u.TARIH,
                                           u.SAAT,
                                           CARİ=u.TBLCARI.AD+" "+ u.TBLCARI.SOYAD,
                                           PERSONEL=u.TBLPERSONEL.AD+" "+ u.TBLPERSONEL.SOYAD
                                       }).ToList();
            gridControl2.DataSource = (from x in db.TBLFATURADETAY.Where(x => x.FATURAID == id)
                                       select new
                                       {
                                           x.FATURADETAYID,
                                           x.URUN,
                                           x.ADET,
                                           x.FIYAT,
                                           x.TUTAR,
                                           x.FATURAID
                                       }).ToList();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            gridControl1.ExportToPdf(path);
        }
        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            string path = "Dosya2.xls";
            gridControl1.ExportToXls(path);
        }
        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
