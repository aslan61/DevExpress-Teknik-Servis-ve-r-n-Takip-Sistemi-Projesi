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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (textkategori.Text!="")
            {
                DBTeknikServisEntities db = new DBTeknikServisEntities();
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = textkategori.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Lütfen karakter sayısını 0-30 arasında giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
