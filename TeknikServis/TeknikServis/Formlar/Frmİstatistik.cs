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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORİ.Count().ToString();
            labelControl7.Text = db.TBLDEPARTMAN.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            labelControl19.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();
            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.SATIŞFİYAT descending select x.AD).FirstOrDefault();
            labelControl11.Text= (from x in db.TBLURUN
                                  orderby x.SATIŞFİYAT ascending
                                  select x.AD).FirstOrDefault();
            labelControl9.Text = db.TBLURUNHAREKET.Count().ToString();
            labelControl25.Text = db.TBLURUN.Count(x => x.KATEGORİ==4).ToString();
            labelControl23.Text = db.TBLURUN.Count(x => x.KATEGORİ==1).ToString();
            labelControl21.Text = db.TBLURUN.Count(x => x.KATEGORİ==3).ToString();
            labelControl39.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            labelControl35.Text = db.TBLURUNKABUL.Count().ToString();
            labelControl37.Text = db.MAXKATEGORİURUN().FirstOrDefault();
            labelControl21.Text = db.TBLPERSONEL.Count().ToString();
        }
    }
}
