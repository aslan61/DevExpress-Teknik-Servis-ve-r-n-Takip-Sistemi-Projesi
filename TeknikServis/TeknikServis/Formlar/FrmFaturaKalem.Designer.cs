
namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalem));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textadet = new DevExpress.XtraEditors.TextEdit();
            this.textfiyat = new DevExpress.XtraEditors.TextEdit();
            this.texttutar = new DevExpress.XtraEditors.TextEdit();
            this.textfaturaıd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnlistele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtürün = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textadet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textfaturaıd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtürün.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-1, -2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1012, 544);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Turquoise;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(79, 161);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 29;
            this.labelControl8.Text = "TUTAR:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(58, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(58, 13);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "FATURA ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.textadet);
            this.groupControl1.Controls.Add(this.textfiyat);
            this.groupControl1.Controls.Add(this.texttutar);
            this.groupControl1.Controls.Add(this.textfaturaıd);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.btnlistele);
            this.groupControl1.Controls.Add(this.BtnGüncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.txtürün);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(1009, -2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(362, 544);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // textadet
            // 
            this.textadet.EditValue = "";
            this.textadet.Location = new System.Drawing.Point(121, 106);
            this.textadet.Name = "textadet";
            this.textadet.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textadet.Properties.Appearance.Options.UseForeColor = true;
            this.textadet.Properties.MaxLength = 10000000;
            this.textadet.Size = new System.Drawing.Size(206, 20);
            this.textadet.TabIndex = 3;
            // 
            // textfiyat
            // 
            this.textfiyat.EditValue = "";
            this.textfiyat.Location = new System.Drawing.Point(121, 132);
            this.textfiyat.Name = "textfiyat";
            this.textfiyat.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textfiyat.Properties.Appearance.Options.UseForeColor = true;
            this.textfiyat.Properties.Mask.EditMask = "A";
            this.textfiyat.Size = new System.Drawing.Size(206, 20);
            this.textfiyat.TabIndex = 4;
            // 
            // texttutar
            // 
            this.texttutar.EditValue = "";
            this.texttutar.Location = new System.Drawing.Point(121, 158);
            this.texttutar.Name = "texttutar";
            this.texttutar.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.texttutar.Properties.Appearance.Options.UseForeColor = true;
            this.texttutar.Properties.Mask.EditMask = "A";
            this.texttutar.Size = new System.Drawing.Size(206, 20);
            this.texttutar.TabIndex = 5;
            // 
            // textfaturaıd
            // 
            this.textfaturaıd.EditValue = "";
            this.textfaturaıd.Location = new System.Drawing.Point(121, 184);
            this.textfaturaıd.Name = "textfaturaıd";
            this.textfaturaıd.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textfaturaıd.Properties.Appearance.Options.UseForeColor = true;
            this.textfaturaıd.Properties.Mask.EditMask = "A";
            this.textfaturaıd.Size = new System.Drawing.Size(206, 20);
            this.textfaturaıd.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(83, 135);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "FİYAT:";
            // 
            // textID
            // 
            this.textID.EditValue = "";
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(121, 55);
            this.textID.Name = "textID";
            this.textID.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textID.Properties.Appearance.Options.UseForeColor = true;
            this.textID.Size = new System.Drawing.Size(206, 20);
            this.textID.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(66, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "DETAY ID:";
            // 
            // btnlistele
            // 
            this.btnlistele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlistele.ImageOptions.Image")));
            this.btnlistele.Location = new System.Drawing.Point(121, 349);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(206, 38);
            this.btnlistele.TabIndex = 10;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGüncelle.ImageOptions.Image")));
            this.BtnGüncelle.Location = new System.Drawing.Point(121, 305);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(206, 38);
            this.BtnGüncelle.TabIndex = 9;
            this.BtnGüncelle.Text = "GÜNCELLE";
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(121, 261);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(206, 38);
            this.BtnSil.TabIndex = 8;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(121, 217);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(206, 38);
            this.btnkaydet.TabIndex = 7;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtürün
            // 
            this.txtürün.EditValue = "";
            this.txtürün.Location = new System.Drawing.Point(122, 80);
            this.txtürün.Name = "txtürün";
            this.txtürün.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtürün.Properties.Appearance.Options.UseForeColor = true;
            this.txtürün.Properties.Mask.EditMask = "A";
            this.txtürün.Properties.MaxLength = 50;
            this.txtürün.Size = new System.Drawing.Size(206, 20);
            this.txtürün.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(81, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ÜRÜN: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(86, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ADET:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(122, 393);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(205, 37);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FrmFaturaKalem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 541);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmFaturaKalem";
            this.Text = "Fatura Kalem İşlemleri";
            this.Load += new System.EventHandler(this.FrmFaturaKalem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textadet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.texttutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textfaturaıd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtürün.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnlistele;
        private DevExpress.XtraEditors.SimpleButton BtnGüncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private DevExpress.XtraEditors.TextEdit txtürün;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textadet;
        private DevExpress.XtraEditors.TextEdit textfiyat;
        private DevExpress.XtraEditors.TextEdit texttutar;
        private DevExpress.XtraEditors.TextEdit textfaturaıd;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}