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
    public partial class FrmÜrünSatış : Form
    {
        public FrmÜrünSatış()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (texttarih.Text!=""  && textadet.Text!="" && textsatış.Text!="" && textserino.Text != "" 
                && lookUpürün.EditValue!=null && lookUpCari.EditValue != null && lookUpPersonel.EditValue != null)
            {
                TBLURUNHAREKET t = new TBLURUNHAREKET();
                t.URUN = int.Parse(lookUpürün.EditValue.ToString());
                t.MUSTERI = int.Parse(lookUpCari.EditValue.ToString());
                t.PERSONEL = short.Parse(lookUpPersonel.EditValue.ToString());
                t.TARIH = DateTime.Parse(texttarih.Text);
                t.ADET = short.Parse(textadet.Text);
                t.FIYAT = decimal.Parse(textsatış.Text);
                t.URUNSERINO = textserino.Text;
                db.TBLURUNHAREKET.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Satış Yapıldı");
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmÜrünSatış_Load(object sender, EventArgs e)
        {
            lookUpürün.Properties.DataSource = (from x in db.TBLURUN
                                              select new
                                              {
                                                  x.ID,
                                                  x.AD
                                              }).ToList();
            lookUpCari.Properties.DataSource = (from x in db.TBLCARI
                                                select new
                                                {
                                                    x.ID,
                                                    AD=x.AD+" "+x.SOYAD
                                                }).ToList();
            lookUpPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                select new
                                                {
                                                    x.ID,
                                                    AD = x.AD + " " + x.SOYAD
                                                }).ToList();
        }
        private void textsatış_Click(object sender, EventArgs e)
        {

            int adet = int.Parse(textadet.Text);
            if (textadet.Text!="" && adet!=0 && lookUpürün.EditValue!=null)
            {
                string fiyat = db.TBLURUN.Find(lookUpürün.EditValue).SATIŞFİYAT.ToString();
                textsatış.Text = (decimal.Parse(fiyat) * adet).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Ürün Seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
