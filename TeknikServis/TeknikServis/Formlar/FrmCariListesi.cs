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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db =new DBTeknikServisEntities();
        void listele()
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.MAIL,
                               u.TELEFON,
                               u.IL,
                               u.ILCE,
                               u.BANKA,
                               u.VERGIDAİRESİ,
                               u.VERGINO,
                               u.STATU,
                               u.ADRES
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            listele();
            labelControl11.Text = db.TBLCARI.Count().ToString();
            labelControl17.Text =db.TBLCARI.Select(x=>x.IL).Distinct().Count().ToString();
            labelControl15.Text =db.TBLCARI.Select(x=>x.ILCE).Distinct().Count().ToString();
            labelControl13.Text =db.makscariil().FirstOrDefault();
            lookUpİl.Properties.DataSource=(from x in db.TBLILLER
                                           select new
                                           {
                                               x.id,
                                               x.sehir
                                           }).ToList();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (textad.Text!="" && textsoyad.Text!="" && texttelefon.Text!="" && textMail.Text!="" 
                && textBanka.Text != "" && textVergiDairesi.Text != "" && textvno.Text != ""
                && textStatü.Text!="" && textAdres.Text != "" 
                && lookUpİl.EditValue != null && lookUpİlçe.EditValue != null) 
            {
                TBLCARI t = new TBLCARI();
                t.AD = textad.Text;
                t.SOYAD = textsoyad.Text;
                t.TELEFON = texttelefon.Text;
                t.MAIL = textMail.Text;
                t.IL = lookUpİl.Text;
                t.ILCE = lookUpİlçe.Text;
                t.BANKA = textBanka.Text;
                t.VERGIDAİRESİ = textVergiDairesi.Text;
                t.VERGINO = textvno.Text;
                t.STATU = textStatü.Text;
                t.ADRES = textAdres.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!");
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (textad.Text != "" && textsoyad.Text != "" && texttelefon.Text != "" 
                && textMail.Text != "" && textBanka.Text != "" && textVergiDairesi.Text!="" 
                && textvno.Text!="" && textStatü.Text!="" && textAdres.Text!="")
            {
                int id = int.Parse(textID.Text);
                var deger = db.TBLCARI.Find(id);
                deger.AD = textad.Text;
                deger.SOYAD = textsoyad.Text;
                deger.TELEFON = texttelefon.Text;
                deger.MAIL = textMail.Text;
                deger.IL = lookUpİl.Text;
                deger.ILCE = lookUpİlçe.Text;
                deger.BANKA = textBanka.Text;
                deger.VERGIDAİRESİ = textVergiDairesi.Text;
                deger.VERGINO = textvno.Text;
                deger.STATU = textStatü.Text;
                deger.ADRES = textAdres.Text;
                db.SaveChanges();
                MessageBox.Show("Cari Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int seçilen;
        private void lookUpİl_EditValueChanged(object sender, EventArgs e)
        {
            seçilen = int.Parse(lookUpİl.EditValue.ToString());
            lookUpİlçe.Properties.DataSource = (from y in db.TBLILÇELER
                                                select new
                                                {
                                                    y.id,
                                                    y.ilce,
                                                    y.sehir
                                                }).Where(y=>y.sehir==seçilen).ToList();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            textad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            textsoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            texttelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
            textMail.Text = gridView1.GetFocusedRowCellValue("MAIL").ToString();
            lookUpİl.Text = gridView1.GetFocusedRowCellValue("IL").ToString();
            lookUpİlçe.Text = gridView1.GetFocusedRowCellValue("ILCE").ToString();
            textBanka.Text = gridView1.GetFocusedRowCellValue("BANKA").ToString();
            textVergiDairesi.Text = gridView1.GetFocusedRowCellValue("VERGIDAİRESİ").ToString();
            textvno.Text = gridView1.GetFocusedRowCellValue("VERGINO").ToString();
            textStatü.Text = gridView1.GetFocusedRowCellValue("STATU").ToString();
            textAdres.Text = gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }
        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            textad.Text = "";
            textsoyad.Text = "";
            texttelefon.Text = "";
            textMail.Text = "";
            lookUpİl.Text = "";
            lookUpİlçe.Text = "";
            textBanka.Text = "";
            textVergiDairesi.Text = "";
            textvno.Text = "";
            textStatü.Text = "";
            textAdres.Text = "";
        }
    }
}
