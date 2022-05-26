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
    public partial class FrmFaturaListesi : Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRE,
                               CARİ = u.TBLCARI.AD + " " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD + " " + u.TBLPERSONEL.SOYAD,
                           };
            gridControl1.DataSource = degerler.ToList();
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();

            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtseri.Text != "" && textsırano.Text != "" &&
                texttarih.Text != "" && textsaat.Text != "" && 
                textvergi.Text != "" && lookUpEdit1.EditValue != null && lookUpEdit2.EditValue != null)
            {
                TBLFATURABILGI t = new TBLFATURABILGI();
                t.SERI = txtseri.Text;
                t.SIRANO = textsırano.Text;
                t.TARIH = Convert.ToDateTime(texttarih.Text);
                t.SAAT = textsaat.Text;
                t.VERGIDAIRE = textvergi.Text;
                t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
                t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
                db.TBLFATURABILGI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Fatura Sisteme Kaydedilmiştir, Kalem Girişi Yapabilirsiniz.");
                Listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtseri.Text != "" && textsırano.Text != "" && texttarih.Text != "" && 
                textsaat.Text != "" && textvergi.Text != "" &&
                lookUpEdit1.EditValue != null && lookUpEdit2.EditValue != null)
            {
                int id = int.Parse(textID.Text);
                var deger = db.TBLFATURABILGI.Find(id);
                deger.SERI = txtseri.Text;
                deger.SIRANO = textsırano.Text;
                deger.TARIH = DateTime.Parse(texttarih.Text);
                deger.SAAT = textsaat.Text;
                deger.VERGIDAIRE = textvergi.Text;
                deger.CARI = byte.Parse(lookUpEdit1.EditValue.ToString());
                deger.PERSONEL = byte.Parse(lookUpEdit2.EditValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Fatura Bilgileri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }
        }
        public string id;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            txtseri.Text = "";
            textsırano.Text = "";
            texttarih.Text = "";
            textsaat.Text = "";
            textvergi.Text = "";
        }
    }
}
