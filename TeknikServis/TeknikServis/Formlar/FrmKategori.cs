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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void Listele()
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "")
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = txtad.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
                Listele();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Uzun Olamaz");
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            DialogResult sil = new DialogResult();
            sil = MessageBox.Show(txtad.Text + " isimli kategoriyi silmek istediğinize emin misiniz?", "Kategori Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sil == DialogResult.Yes)
            {
                int İD = int.Parse(textID.Text);
                var deger = db.TBLKATEGORİ.Find(İD);
                db.TBLKATEGORİ.Remove(deger);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Onayınız olmadığı için kategori silinemedi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "")
            {
                int id = int.Parse(textID.Text);
                var deger = db.TBLKATEGORİ.Find(id);
                deger.AD = txtad.Text;
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez ve Kategori Adı 30 Karakterden Uzun Olamaz");
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            textID.Text = "";
        }
    }
}
