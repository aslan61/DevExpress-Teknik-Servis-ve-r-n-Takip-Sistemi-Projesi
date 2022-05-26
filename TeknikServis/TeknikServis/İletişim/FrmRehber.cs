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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =(from x in db.TBLCARI
                                      select new
                                      {
                                          x.AD,
                                          x.SOYAD,
                                          x.IL,
                                          x.ILCE,
                                          x.TELEFON,
                                          x.MAIL,
                                          x.ADRES
                                      }).ToList();

        }
    }
}
