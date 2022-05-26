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
    public partial class FrmArizalıürünKaydı : Form
    {
        public FrmArizalıürünKaydı()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (texttarih.Text!="" && textserino.Text!="" && lookUpEdit1.EditValue != null && lookUpEdit2.EditValue!=null)
            {
                TBLURUNKABUL t = new TBLURUNKABUL();
                t.CARI = int.Parse(lookUpEdit1.EditValue.ToString());
                t.GELISTARIH = DateTime.Parse(texttarih.Text);
                t.URUNSERINO = textserino.Text;
                t.PERSONEL = short.Parse(lookUpEdit2.EditValue.ToString());
                t.URUNDURUMDETAY = "Ürün Kaydoldu";
                db.TBLURUNKABUL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Arıza Girişi Yapıldı.");
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArizalıürünKaydı_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEdit1.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD=x.AD+" "+x.SOYAD
                                                 }).ToList();

            //Personel
            lookUpEdit2.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void texttarih_Properties_Click(object sender, EventArgs e)
        {
            texttarih.Text = DateTime.Now.ToString();
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textserino_Click(object sender, EventArgs e)
        {
            textserino.Text = "";
        }
    }
}
