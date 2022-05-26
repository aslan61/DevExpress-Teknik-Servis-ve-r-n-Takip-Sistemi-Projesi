using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : Form
    {
        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void Listele()
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIH,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            gridControl1.DataSource = degerler.ToList();
        }
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            Listele();
            labelControl2.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            labelControl3.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl15.Text = db.TBLURUN.Count().ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekliyor.").ToString();
            labelControl17.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj Bekliyor.").ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekliyor.").ToString();

            SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-HGJJB4D;Initial Catalog=DBTeknikServis;Integrated Security=True");
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglantı.Close();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
                FrmArizaDetaylar fr = new FrmArizaDetaylar();
                
                fr.id = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
                fr.serino = gridView1.GetFocusedRowCellValue("URUNSERINO").ToString();
                fr.Show();
        }  
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
