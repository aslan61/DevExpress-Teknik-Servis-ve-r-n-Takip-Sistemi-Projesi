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
    public partial class FrmCariİller : Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HGJJB4D;Initial Catalog=DBTeknikServis;Integrated Security=True");
        private void FrmCariİller_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { İL = z.Key, TOPLAM = z.Count() }).ToList();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select IL,Count(*) from TBLCARI group by IL",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }
    }
}
