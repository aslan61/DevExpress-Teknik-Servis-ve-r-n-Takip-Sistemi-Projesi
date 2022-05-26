using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmUrunListesi fr3;
        private void BtnUrunListesiFormu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null || fr3.IsDisposed)
            {
                fr3 = new Formlar.FrmUrunListesi();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        private void BtnYeniUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmYeniUrun fr = new Formlar.FrmYeniUrun();
            fr.Show();
        }
        Formlar.FrmKategori fr2;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null || fr2.IsDisposed)
            {
                fr2 = new Formlar.FrmKategori();
                fr2.MdiParent = this;
                fr2.Show();
            }
        }
        Formlar.FrmYeniKategori fr29;
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr29 == null || fr29.IsDisposed)
            {
                fr29 = new Formlar.FrmYeniKategori();
                fr29.Show();
            }
        }
        Formlar.Frmİstatistik fr4;
        private void Btnİstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)
            {
                fr4 = new Formlar.Frmİstatistik();
                fr4.MdiParent = this;
                fr4.Show();
            }

        }
        Formlar.FrmMarkalar fr5;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)
            {
                fr5 = new Formlar.FrmMarkalar();
                fr5.MdiParent = this;
                fr5.Show();
            }

        }
        Formlar.FrmCariListesi fr9;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr9 == null || fr9.IsDisposed)
            {
                fr9 = new Formlar.FrmCariListesi();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        Formlar.FrmCariİller fr10;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr10 == null || fr10.IsDisposed)
            {
                fr10 = new Formlar.FrmCariİller();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }
        Formlar.FrmCariEkle fr1;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null || fr1.IsDisposed)
            {
                fr1 = new Formlar.FrmCariEkle();
                fr1.Show();
            }
        }
        Formlar.FrmDepartman fr12;
        private void barButtonItem25_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr12 == null || fr12.IsDisposed)
            {
                fr12 = new Formlar.FrmDepartman();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
        Formlar.FrmYeniDepartman frm1;
        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm1 == null || frm1.IsDisposed)
            {
                frm1 = new Formlar.FrmYeniDepartman();
                frm1.Show();
            }
        }
        Formlar.FrmPersonel fr11;
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr11 == null || fr11.IsDisposed)
            {
                fr11 = new Formlar.FrmPersonel();
                fr11.MdiParent = this;
                fr11.Show();
            }
        }
        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmKurlar fr14;
        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new Formlar.FrmKurlar();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
        Formlar.FrmAnaSayfa fr;
        private void Form1_Load(object sender, EventArgs e)
        {

            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }

        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword.Exe");
        }

        private void BtnExel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        Formlar.FrmYoutube frm12;
        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Formlar.FrmYoutube();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }
        Formlar.FrmNotlar fr13;
        private void BtnNotListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new Formlar.FrmNotlar();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }
        private void barButtonItem28_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        Formlar.FrmArizaListesi fr6;
        private void BtnArızalıürün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)
            {
                fr6 = new Formlar.FrmArizaListesi();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }
        Formlar.FrmÜrünSatış frm2;
        private void BtnUrunSatış_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.FrmÜrünSatış();
                frm2.Show();
            }
        }
        Formlar.FrmSatışlar fr21;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr21 == null || fr21.IsDisposed)
            {
                fr21 = new Formlar.FrmSatışlar();
                fr21.MdiParent = this;
                fr21.Show();
            }

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizalıürünKaydı fr = new Formlar.FrmArizalıürünKaydı();
            fr.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmArizaDetaylar fr = new Formlar.FrmArizaDetaylar();
            fr.Show();
        }
        Formlar.FrmArızalıÜrünDetayListesi fr20;
        private void BtnArızalıÜrünDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null || fr20.IsDisposed)
            {
                fr20 = new Formlar.FrmArızalıÜrünDetayListesi();
                fr20.MdiParent = this;
                fr20.Show();
            }

        }

        private void BtnQRoluştur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmQRCode fr = new Formlar.FrmQRCode();
            fr.Show();
        }
        Formlar.FrmFaturaListesi fr22;
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr22 == null || fr22.IsDisposed)
            {
                fr22 = new Formlar.FrmFaturaListesi();
                fr22.MdiParent = this;
                fr22.Show();
            }
        }
        Formlar.FrmFaturaKalem fr23;
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr23 == null || fr23.IsDisposed)
            {
                fr23 = new Formlar.FrmFaturaKalem();
                fr23.MdiParent = this;
                fr23.Show();
            }

        }
        Formlar.FrmFaturaKalemleri fr24;
        private void BtnFaturaKalemListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr24 == null || fr24.IsDisposed)
            {
                fr24 = new Formlar.FrmFaturaKalemleri();
                fr24.MdiParent = this;
                fr24.Show();
            }

        }
        Formlar.FrmGauge fr16;
        private void BtnHakkımızda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr16 == null || fr16.IsDisposed)
            {
                fr16 = new Formlar.FrmGauge();
                fr16.MdiParent = this;
                fr16.Show();
            }

        }
        Formlar.FrmHarita fr15;
        private void BtnHaritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr15 == null || fr15.IsDisposed)
            {
                fr15 = new Formlar.FrmHarita();
                fr15.MdiParent = this;
                fr15.Show();
            }
        }
        Formlar.FrmRaporlar fr26;
        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr26 == null || fr26.IsDisposed)
            {
                fr26 = new Formlar.FrmRaporlar();
                fr26.Show();
            }
        }
        private void BtnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Formlar.FrmAnaSayfa();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        İletişim.FrmGelenMesajlar fr7;
        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr7 == null || fr7.IsDisposed)
            {
                fr7 = new İletişim.FrmGelenMesajlar();
                fr7.MdiParent = this;
                fr7.Show();
            }
        }
        İletişim.FrmRehber fr17;
        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr17 == null || fr17.IsDisposed)
            {
                fr17 = new İletişim.FrmRehber();
                fr17.MdiParent = this;
                fr17.Show();
            }
        }
        Formlar.FrmAyarlar fr19;
        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr19 == null || fr19.IsDisposed)
            {
                fr19 = new Formlar.FrmAyarlar();
                fr19.Show();
            }
        }
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Environment.Exit(0);
        }
        Formlar.FrmArizaDetaylar fr30;
        private void barButtonItem7_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr30 == null || fr30.IsDisposed)
            {
                fr30 = new Formlar.FrmArizaDetaylar();
                fr30.Show();
            }
        }
    }
}
