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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtbas.Text != "" && textiçerik.Text != "" && texttarih.Text != null && textID.Text != "")
            {
                TBLNOTLARIM t = new TBLNOTLARIM();
                t.BASLIK = txtbas.Text;
                t.ICERIK = textiçerik.Text;
                t.DURUM = false;
                t.TARİH = DateTime.Parse(texttarih.Text);
                db.TBLNOTLARIM.Add(t);
                db.SaveChanges();
                MessageBox.Show("Not Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yeniden Deneyin");
            }  
        }
        private void btnlistele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLARIM.Where(x => x.DURUM == false).ToList();
            gridControl2.DataSource = db.TBLNOTLARIM.Where(y => y.DURUM == true).ToList();
        }
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true && txtbas.Text != "" && textiçerik.Text != "" && texttarih.Text != null && textID.Text != "")
            {
                int id = int.Parse(textID.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Değiştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yeniden Deneyin");
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtbas.Text = gridView1.GetFocusedRowCellValue("BASLIK").ToString();
            textiçerik.Text = gridView1.GetFocusedRowCellValue("ICERIK").ToString();
            texttarih.Text = gridView1.GetFocusedRowCellValue("TARİH").ToString();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textID.Text);
            var deger = db.TBLNOTLARIM.Find(id);
            db.TBLNOTLARIM.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
            txtbas.Text = gridView2.GetFocusedRowCellValue("BASLIK").ToString();
            textiçerik.Text = gridView2.GetFocusedRowCellValue("ICERIK").ToString();
            texttarih.Text = gridView2.GetFocusedRowCellValue("TARİH").ToString();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            txtbas.Text = "";
            textiçerik.Text = "";
            texttarih.Text = "";
        }
    }
}
