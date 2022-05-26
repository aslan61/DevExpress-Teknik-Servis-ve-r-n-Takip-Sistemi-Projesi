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
    public partial class FrmGauge : Form
    {
        public FrmGauge()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmGauge_Load(object sender, EventArgs e)
        {
            labelComponent2.Text= db.TBLCARI.Count().ToString();
            labelComponent1.Text = db.TBLPERSONEL.Count().ToString();
            digitalGauge1.Text = db.TBLURUN.Count().ToString();
            digitalGauge10.Text = db.TBLDEPARTMAN.Count().ToString();
        }

    }
}
