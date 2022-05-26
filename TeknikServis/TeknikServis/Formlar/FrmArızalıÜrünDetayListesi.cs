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
    public partial class FrmArızalıÜrünDetayListesi : Form
    {
        public FrmArızalıÜrünDetayListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            DBTeknikServisEntities db = new DBTeknikServisEntities();
            gridControl1.DataSource = (from x in db.TBLURUNTAKIP
                                       select new
                                       {
                                           x.TAKIPID,
                                           x.SERINO,
                                           x.TARIH,
                                           x.AÇIKLAMA
                                       }).ToList();
        }
        private void FrmArızalıÜrünDetayListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
