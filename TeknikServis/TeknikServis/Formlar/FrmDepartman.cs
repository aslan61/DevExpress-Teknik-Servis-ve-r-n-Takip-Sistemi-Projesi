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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void Listele()
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            Listele();
            labelControl11.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl13.Text = db.TBLPERSONEL.Count().ToString();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Length <= 50 && txtad.Text != "" && richTextBox1.Text.Length > 1)
            {
                TBLDEPARTMAN t = new TBLDEPARTMAN();
                t.AD = txtad.Text;
                t.ACIKLAMA = richTextBox1.Text;
                db.TBLDEPARTMAN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Departman Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                MessageBox.Show("Kayıt Yapılamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int İD = int.Parse(textID.Text);
            var deger = db.TBLDEPARTMAN.Find(İD);
            db.TBLDEPARTMAN.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Length <= 50 && txtad.Text != "" && richTextBox1.Text.Length > 1)
            {
                int id = int.Parse(textID.Text);
                var deger = db.TBLDEPARTMAN.Find(id);
                deger.AD = txtad.Text;
                db.SaveChanges();
                MessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            textID.Text = "";
            txtad.Text = "";
            richTextBox1.Text = "";
        }
    }
}
