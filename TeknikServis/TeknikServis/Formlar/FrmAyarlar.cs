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
    public partial class FrmAyarlar : Form
    {
        public FrmAyarlar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void listele()
        {
            var degerler = from x in db.TBLADMIN
                           select new
                           {
                               x.ID,
                               x.KULLANICIAD,
                               x.SIFRE
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            if (textkad.Text != "" && textsifre.Text != "")
            {
                TBLADMIN t = new TBLADMIN();
                t.KULLANICIAD = textkad.Text;
                t.SIFRE = textsifre.Text;
                db.TBLADMIN.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Admin Sisteme Kayıt Edildi.");
                listele();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakılamaz");
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try 
            {
                textkad.Text = gridView1.GetFocusedRowCellValue("KULLANICIAD").ToString();
                textsifre.Text = gridView1.GetFocusedRowCellValue("SIFRE").ToString();
   
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
