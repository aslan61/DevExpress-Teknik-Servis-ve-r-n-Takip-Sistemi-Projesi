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
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void listele()
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            listele();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtürün.Text!="" && textadet.Text!="" && textfiyat.Text != "" 
                && texttutar.Text!="" && textfaturaıd.Text!="")
            {
                TBLFATURADETAY t = new TBLFATURADETAY();
                t.URUN = txtürün.Text;
                t.ADET = short.Parse(textadet.Text);
                t.FIYAT = decimal.Parse(textfiyat.Text);
                t.TUTAR = decimal.Parse(texttutar.Text);
                t.FATURAID = int.Parse(textfaturaıd.Text);
                db.TBLFATURADETAY.Add(t);
                db.SaveChanges();
                MessageBox.Show("Faturaya ait kalem girişi başarılı bir şekilde yapıldı");
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            db.TBLFATURADETAY.Find(deger);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalemi Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtürün.Text != "" && textadet.Text != "" && texttutar.Text != "" && texttutar.Text != "" && textfaturaıd.Text != "")
            {
            int id = int.Parse(textID.Text);
            var deger = db.TBLFATURADETAY.Find(id);
            deger.URUN = txtürün.Text;
            deger.ADET = short.Parse(textadet.Text);
            deger.FIYAT = decimal.Parse(textfiyat.Text);
            deger.TUTAR = decimal.Parse(texttutar.Text);
            deger.FATURAID = int.Parse(textfaturaıd.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("FATURADETAYID").ToString();
            txtürün.Text = gridView1.GetFocusedRowCellValue("URUN").ToString();
            textadet.Text = gridView1.GetFocusedRowCellValue("ADET").ToString();
            textfiyat.Text = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
            texttutar.Text = gridView1.GetFocusedRowCellValue("TUTAR").ToString();
            textfaturaıd.Text = gridView1.GetFocusedRowCellValue("FATURAID").ToString();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            txtürün.Text = "";
            textadet.Text = "";
            textfiyat.Text = "";
            texttutar.Text = "";
            textfaturaıd.Text = "";
        }
    }
}
