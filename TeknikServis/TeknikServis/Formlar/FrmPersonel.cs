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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void listele()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               DEPARTMAN = u.TBLDEPARTMAN.AD,
                               u.MAİL,
                               u.TELEFON
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();

            lookUpEdit1.Properties.DataSource = (from x in db.TBLDEPARTMAN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();
            String ad1, soyad1, ad2, soyad2, ad3, soyad3, ad4, soyad4;

            //1.Personel
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            labelControl3.Text = ad1 + " " + soyad1;
            labelControl4.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            labelControl6.Text = db.TBLPERSONEL.First(x => x.ID == 1).MAİL;

            //2.Personel
            ad2 = db.TBLPERSONEL.First(x => x.ID == 2).AD;
            soyad2 = db.TBLPERSONEL.First(x => x.ID == 2).SOYAD;
            labelControl14.Text = ad2 + " " + soyad2;
            labelControl11.Text = db.TBLPERSONEL.First(x => x.ID == 2).TBLDEPARTMAN.AD;
            labelControl9.Text = db.TBLPERSONEL.First(x => x.ID == 2).MAİL;

            //3.Personel
            ad3 = db.TBLPERSONEL.First(x => x.ID == 3).AD;
            soyad3 = db.TBLPERSONEL.First(x => x.ID == 3).SOYAD;
            labelControl20.Text = ad3 + " " + soyad3;
            labelControl18.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl16.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAİL;

            //4.Personel
            ad4 = db.TBLPERSONEL.First(x => x.ID == 4).AD;
            soyad4 = db.TBLPERSONEL.First(x => x.ID == 4).SOYAD;
            labelControl26.Text = ad4 + " " + soyad4;
            labelControl24.Text = db.TBLPERSONEL.First(x => x.ID == 3).TBLDEPARTMAN.AD;
            labelControl22.Text = db.TBLPERSONEL.First(x => x.ID == 3).MAİL;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            var degerler = db.TBLPERSONEL.Find(id);
            db.TBLPERSONEL.Remove(degerler);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtSoyad.Text != "" && lookUpEdit1.EditValue != null 
                && txtmail.Text != "" && txttelefon.Text != "")
            {
                TBLPERSONEL t = new TBLPERSONEL();
                t.AD = txtad.Text;
                t.SOYAD = txtSoyad.Text;
                t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                t.MAİL = txtmail.Text;
                t.TELEFON = txttelefon.Text;
                db.TBLPERSONEL.Add(t);
                db.SaveChanges();
                MessageBox.Show("Personel Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtSoyad.Text != "" && txtSoyad.Text != "" && lookUpEdit1.EditValue != null 
                && txtmail.Text != "" && txttelefon.Text != "")
            {
                int id = int.Parse(txtID.Text);
                var deger = db.TBLPERSONEL.Find(id);
                deger.AD = txtad.Text;
                deger.SOYAD = txtSoyad.Text;
                deger.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
                deger.MAİL = txtmail.Text;
                deger.TELEFON = txttelefon.Text;
                db.SaveChanges();
                MessageBox.Show("Personel Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("DEPARTMAN").ToString();
            txtmail.Text = gridView1.GetFocusedRowCellValue("MAİL").ToString();
            txttelefon.Text = gridView1.GetFocusedRowCellValue("TELEFON").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtad.Text = "";
            txtSoyad.Text = "";
            lookUpEdit1.Text = "";
            txtmail.Text = "";
            txttelefon.Text = "";
        }
    }
}
