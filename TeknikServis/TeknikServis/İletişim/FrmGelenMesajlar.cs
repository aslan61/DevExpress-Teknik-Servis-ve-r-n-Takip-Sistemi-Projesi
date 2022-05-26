using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmGelenMesajlar : Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource=(from x in db.TBLİLETİŞİM
                                    select new
                                    {
                                        x.ID,
                                        x.ADSOYAD,
                                        x.KONU,
                                        x.MAIL,
                                        x.MESAJ
                                    }).ToList();
            labelControl1.Text = db.TBLCARI.Count().ToString();
            labelControl11.Text = db.TBLİLETİŞİM.Count().ToString();
            labelControl13.Text = db.TBLİLETİŞİM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            labelControl15.Text = db.TBLİLETİŞİM.Where(x => x.KONU == "Rica").Count().ToString();
            labelControl17.Text = db.TBLİLETİŞİM.Where(x => x.KONU == "Şikayet").Count().ToString();
        }

        private void pictureEdit6_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
