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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TBLKATEGORİ.AD,
                               u.STOK,
                               u.ALISFİYAT,
                               u.SATIŞFİYAT
                           };
            gridControl1.DataSource = degerler.ToList();


        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = (from x in db.TBLKATEGORİ
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
            Listele();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (textad.Text != "" && textmarka.Text != "" && textal.Text != "" && 
                textsatışfiyat.Text != "" && textstok.Text != "" && lookUpEdit1.EditValue != null)
            {
                TBLURUN t = new TBLURUN();
                t.AD = textad.Text;
                t.MARKA = textmarka.Text;
                t.ALISFİYAT = decimal.Parse(textal.Text);
                t.SATIŞFİYAT = decimal.Parse(textsatışfiyat.Text);
                t.STOK = short.Parse(textstok.Text);
                t.DURUM = false;
                t.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
                db.TBLURUN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

                textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                textad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
                textmarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
                textal.Text = gridView1.GetFocusedRowCellValue("ALISFİYAT").ToString();
                textsatışfiyat.Text = gridView1.GetFocusedRowCellValue("SATIŞFİYAT").ToString();
                textstok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int İD = int.Parse(textID.Text);
            var deger = db.TBLURUN.Find(İD);
            db.TBLURUN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (textad.Text!="" && textmarka.Text!="" && textal.Text!="" && textsatışfiyat.Text!="" 
                && textstok.Text!="" && lookUpEdit1.EditValue!=null )
            {
                int id = int.Parse(textID.Text);
                var deger = db.TBLURUN.Find(id);
                deger.AD = textad.Text;
                deger.MARKA = textmarka.Text;
                deger.ALISFİYAT = decimal.Parse(textal.Text);
                deger.SATIŞFİYAT = decimal.Parse(textsatışfiyat.Text);
                deger.KATEGORİ = byte.Parse(lookUpEdit1.EditValue.ToString());
                deger.STOK = short.Parse(textstok.Text);
                db.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textad.Text = "";
            textmarka.Text = "";
            textal.Text = "";
            textsatışfiyat.Text = "";
            textsatışfiyat.Text = "";
            textstok.Text = "";
            lookUpEdit1.Text = "";
        }
    }
}
