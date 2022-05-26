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
    public partial class FrmFaturaKalemleri : Form
    {
        public FrmFaturaKalemleri()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (textıd.Text != "" && textsırano.Text != "" && textserino.Text != "")
            {
                int id = int.Parse(textıd.Text);
                var degerler = (from u in db.TBLFATURADETAY.Where(x => x.FATURAID == id && x.TBLFATURABILGI.SERI == textserino.Text 
                                && x.TBLFATURABILGI.SIRANO == textsırano.Text)
                                select new
                                {
                                    SERİ = u.TBLFATURABILGI.SERI,
                                    SIRA = u.TBLFATURABILGI.SIRANO,
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FIYAT,
                                    u.TUTAR,
                                    u.FATURAID,
                                });
                gridControl1.DataSource = degerler.ToList();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayın!");
            }


        }

        private void FrmFaturaKalemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
