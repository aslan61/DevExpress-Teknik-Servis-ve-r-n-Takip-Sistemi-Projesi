using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        private void pictureEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka=z.Key,
                Toplam=z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = (from x in db.TBLURUN select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN orderby x.SATIŞFİYAT descending select x.MARKA).FirstOrDefault();
            labelControl5.Text = db.maksürünmarka().FirstOrDefault();


            SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-HGJJB4D;Initial Catalog=DBTeknikServis;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            baglantı.Close();

            //2.Chart
            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBLKATEGORİ.AD,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORİ ON TBLKATEGORİ.ID = TBLURUN.KATEGORİ GROUP BY TBLKATEGORİ.AD", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Kategoriler"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglantı.Close();
        }

    }
}
