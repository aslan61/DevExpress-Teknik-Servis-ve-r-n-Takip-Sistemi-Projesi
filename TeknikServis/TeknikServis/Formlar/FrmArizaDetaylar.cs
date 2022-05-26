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
    public partial class FrmArizaDetaylar : Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (textserino.Text != "" && richTextBox1.Text != "" && datetarih.Text!="" && comboBox1.Text!="")
            {
                DBTeknikServisEntities db = new DBTeknikServisEntities();
                TBLURUNTAKIP t = new TBLURUNTAKIP();
                t.AÇIKLAMA = richTextBox1.Text;
                t.SERINO = textserino.Text;
                t.TARIH = DateTime.Parse(datetarih.Text);
                db.TBLURUNTAKIP.Add(t);
                //2.Güncelleme
                TBLURUNKABUL tb = new TBLURUNKABUL();
                int urunid = int.Parse(id.ToString());
                var deger = db.TBLURUNKABUL.Find(urunid);
                deger.URUNDURUMDETAY = comboBox1.Text.ToString();             
                db.SaveChanges();
                MessageBox.Show("Ürün arıza detayları güncellendi");
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datetarih_Click(object sender, EventArgs e)
        {
            datetarih.Text =DateTime.Now.ToString();
        }


        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string id, serino;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            textserino.Text= serino;
        }
    }
}
