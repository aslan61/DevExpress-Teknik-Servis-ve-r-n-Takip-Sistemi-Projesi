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
    public partial class FrmCariEkle : Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void textkategori_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (textad.Text != "" && textsoyad.Text != "" && texttelefon.Text != "" && textmail.Text != "" &&
                textbanka.Text != "" && textvergidairesi.Text != "" && textvergino.Text != "" 
                && textstatü.Text!="" && textadres.Text != "" && lookUpİl.EditValue != null && lookUpİlçe.EditValue != null)
            {
                TBLCARI t = new TBLCARI();
                t.AD = textad.Text;
                t.SOYAD = textsoyad.Text;
                t.TELEFON = texttelefon.Text;
                t.MAIL = textmail.Text;
                t.BANKA = textbanka.Text;
                t.VERGIDAİRESİ = textvergidairesi.Text;
                t.VERGINO = textvergino.Text;
                t.STATU = textstatü.Text;
                t.ADRES = textadres.Text;
                t.IL = lookUpİl.Text;
                t.ILCE = lookUpİlçe.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Cari Sisteme Başarılı Bir Şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                                }).Where(y => y.sehir == seçilen).ToList();
        }
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpİl.Properties.DataSource = (from x in db.TBLILLER
                                              select new
                                              {
                                                  x.id,
                                                  x.sehir
                                              }).ToList();
        }
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
