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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        { 
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (textürünad.Text!="" && textmarka.Text!="" && textalışf.Text!="" && textsatışf.Text != "" 
                && textStok.Text!="" && lookUpEdit1.EditValue!=null)
            {
                TBLURUN t = new TBLURUN();
                t.AD = textürünad.Text;
                t.MARKA = textmarka.Text;
                t.ALISFİYAT = decimal.Parse(textalışf.Text);
                t.SATIŞFİYAT = decimal.Parse(textsatışf.Text);
                t.STOK = short.Parse(textStok.Text);
                t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürünler Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Alanlardan Herhangi Biri Boş Bırakılamaz");
            }
        }
        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
