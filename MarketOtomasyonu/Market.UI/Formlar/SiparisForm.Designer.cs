namespace Market.UI.Formlar
{
    partial class SiparisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.islemler = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnEkle = new DevExpress.XtraNavBar.NavBarItem();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.txtIndirimMiktari = new DevExpress.XtraEditors.SpinEdit();
            this.txtAdet = new DevExpress.XtraEditors.SpinEdit();
            this.cmbUrun = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbTedarikci = new DevExpress.XtraEditors.LookUpEdit();
            this.txtToplamTutar = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.siparisViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvSiparis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedarikciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTedarikciID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnUrunuCikar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButtonLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.SiparisiTamamla = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndirimMiktari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUrun.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTedarikci.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButtonLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navBarControl);
            this.layoutControl1.Controls.Add(this.layoutControl3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(944, 227);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.islemler;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.islemler});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnEkle,
            this.SiparisiTamamla});
            this.navBarControl.Location = new System.Drawing.Point(736, 16);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 192;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(192, 195);
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 1;
            this.navBarControl.Text = "navBarControl1";
            // 
            // islemler
            // 
            this.islemler.Caption = "İşlemler";
            this.islemler.Expanded = true;
            this.islemler.Hint = "Kategori";
            this.islemler.ImageOptions.LargeImageIndex = 0;
            this.islemler.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnEkle),
            new DevExpress.XtraNavBar.NavBarItemLink(this.SiparisiTamamla)});
            this.islemler.Name = "islemler";
            // 
            // btnEkle
            // 
            this.btnEkle.Caption = "Ekle";
            this.btnEkle.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.ImageOptions.SmallImage")));
            this.btnEkle.ImageOptions.SmallImageIndex = 0;
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnEkle_LinkClicked);
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.txtIndirimMiktari);
            this.layoutControl3.Controls.Add(this.txtAdet);
            this.layoutControl3.Controls.Add(this.cmbUrun);
            this.layoutControl3.Controls.Add(this.cmbTedarikci);
            this.layoutControl3.Controls.Add(this.txtToplamTutar);
            this.layoutControl3.Location = new System.Drawing.Point(16, 16);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(859, 201, 812, 500);
            this.layoutControl3.Root = this.Root;
            this.layoutControl3.Size = new System.Drawing.Size(714, 195);
            this.layoutControl3.TabIndex = 0;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // txtIndirimMiktari
            // 
            this.txtIndirimMiktari.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtIndirimMiktari.Location = new System.Drawing.Point(106, 99);
            this.txtIndirimMiktari.Name = "txtIndirimMiktari";
            this.txtIndirimMiktari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIndirimMiktari.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtIndirimMiktari.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtIndirimMiktari.Size = new System.Drawing.Size(593, 26);
            this.txtIndirimMiktari.StyleController = this.layoutControl3;
            this.txtIndirimMiktari.TabIndex = 4;
            // 
            // txtAdet
            // 
            this.txtAdet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAdet.Location = new System.Drawing.Point(106, 69);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAdet.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtAdet.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtAdet.Size = new System.Drawing.Size(593, 26);
            this.txtAdet.StyleController = this.layoutControl3;
            this.txtAdet.TabIndex = 10;
            // 
            // cmbUrun
            // 
            this.cmbUrun.Location = new System.Drawing.Point(106, 42);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUrun.Properties.NullText = "";
            this.cmbUrun.Size = new System.Drawing.Size(593, 23);
            this.cmbUrun.StyleController = this.layoutControl3;
            this.cmbUrun.TabIndex = 7;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.Location = new System.Drawing.Point(106, 15);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTedarikci.Properties.NullText = "";
            this.cmbTedarikci.Size = new System.Drawing.Size(593, 23);
            this.cmbTedarikci.StyleController = this.layoutControl3;
            this.cmbTedarikci.TabIndex = 4;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Location = new System.Drawing.Point(450, 129);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(249, 23);
            this.txtToplamTutar.StyleController = this.layoutControl3;
            this.txtToplamTutar.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem9,
            this.layoutControlItem12,
            this.layoutControlItem7,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 4;
            this.Root.Size = new System.Drawing.Size(714, 195);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmbTedarikci;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem3.Size = new System.Drawing.Size(688, 27);
            this.layoutControlItem3.Text = "Tedarikçi:";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(87, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbUrun;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 27);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem6.Size = new System.Drawing.Size(688, 27);
            this.layoutControlItem6.Text = "Ürün:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(87, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtAdet;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem9.Size = new System.Drawing.Size(688, 30);
            this.layoutControlItem9.Text = "Adet:";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(87, 16);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.txtIndirimMiktari;
            this.layoutControlItem12.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem12.Size = new System.Drawing.Size(688, 30);
            this.layoutControlItem12.Text = "İndirim Miktarı:";
            this.layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem12.TextSize = new System.Drawing.Size(87, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtToplamTutar;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem7.Location = new System.Drawing.Point(344, 114);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlItem7.Size = new System.Drawing.Size(344, 55);
            this.layoutControlItem7.Text = "Toplam Tutar:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(87, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(344, 55);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(944, 227);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(720, 201);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navBarControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(720, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(198, 201);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControl1);
            this.layoutControl2.Controls.Add(this.btnUrunuCikar);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutControl2.Location = new System.Drawing.Point(0, 278);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1064, 240, 812, 500);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(944, 362);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.siparisViewModelBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(16, 16);
            this.gridControl1.MainView = this.gvSiparis;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(912, 286);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSiparis});
            // 
            // siparisViewModelBindingSource
            // 
            // 
            // gvSiparis
            // 
            this.gvSiparis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod,
            this.colUrunAdi,
            this.colUrunID,
            this.colTedarikciAdi,
            this.colTedarikciID,
            this.colFiyat,
            this.colAdet,
            this.colToplamFiyat});
            this.gvSiparis.GridControl = this.gridControl1;
            this.gvSiparis.Name = "gvSiparis";
            this.gvSiparis.OptionsBehavior.Editable = false;
            this.gvSiparis.OptionsFind.AlwaysVisible = true;
            this.gvSiparis.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            // 
            // colBarkod
            // 
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colUrunID
            // 
            this.colUrunID.FieldName = "UrunID";
            this.colUrunID.Name = "colUrunID";
            this.colUrunID.Visible = true;
            this.colUrunID.VisibleIndex = 2;
            // 
            // colTedarikciAdi
            // 
            this.colTedarikciAdi.FieldName = "TedarikciAdi";
            this.colTedarikciAdi.Name = "colTedarikciAdi";
            this.colTedarikciAdi.Visible = true;
            this.colTedarikciAdi.VisibleIndex = 3;
            // 
            // colTedarikciID
            // 
            this.colTedarikciID.FieldName = "TedarikciID";
            this.colTedarikciID.Name = "colTedarikciID";
            this.colTedarikciID.Visible = true;
            this.colTedarikciID.VisibleIndex = 4;
            // 
            // colFiyat
            // 
            this.colFiyat.FieldName = "Fiyat";
            this.colFiyat.Name = "colFiyat";
            this.colFiyat.Visible = true;
            this.colFiyat.VisibleIndex = 5;
            // 
            // colAdet
            // 
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 6;
            // 
            // colToplamFiyat
            // 
            this.colToplamFiyat.FieldName = "ToplamFiyat";
            this.colToplamFiyat.Name = "colToplamFiyat";
            this.colToplamFiyat.OptionsColumn.ReadOnly = true;
            this.colToplamFiyat.Visible = true;
            this.colToplamFiyat.VisibleIndex = 7;
            // 
            // btnUrunuCikar
            // 
            this.btnUrunuCikar.AutoWidthInLayoutControl = true;
            this.btnUrunuCikar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunuCikar.ImageOptions.Image")));
            this.btnUrunuCikar.Location = new System.Drawing.Point(816, 307);
            this.btnUrunuCikar.Name = "btnUrunuCikar";
            this.btnUrunuCikar.Size = new System.Drawing.Size(113, 40);
            this.btnUrunuCikar.StyleController = this.layoutControl2;
            this.btnUrunuCikar.TabIndex = 4;
            this.btnUrunuCikar.Text = "Ürünü Çıkar";
            this.btnUrunuCikar.Click += new System.EventHandler(this.btnUrunuCikar_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.simpleButtonLCI,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup2.Size = new System.Drawing.Size(944, 362);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(918, 292);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleButtonLCI
            // 
            this.simpleButtonLCI.Control = this.btnUrunuCikar;
            this.simpleButtonLCI.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.simpleButtonLCI.CustomizationFormText = "simpleButtonLCI";
            this.simpleButtonLCI.Location = new System.Drawing.Point(801, 292);
            this.simpleButtonLCI.Name = "simpleButtonLCI";
            this.simpleButtonLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.simpleButtonLCI.Size = new System.Drawing.Size(117, 44);
            this.simpleButtonLCI.TextLocation = DevExpress.Utils.Locations.Left;
            this.simpleButtonLCI.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButtonLCI.TextVisible = false;
            this.simpleButtonLCI.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 292);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(801, 44);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // SiparisiTamamla
            // 
            this.SiparisiTamamla.Caption = "Siparişi Tamamla";
            this.SiparisiTamamla.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.SmallImage")));
            this.SiparisiTamamla.Name = "SiparisiTamamla";
            this.SiparisiTamamla.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.SiparisiTamamla_LinkClicked);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 640);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SiparisForm";
            this.ShowIcon = false;
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtIndirimMiktari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUrun.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTedarikci.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButtonLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup islemler;
        private DevExpress.XtraNavBar.NavBarItem btnEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SpinEdit txtIndirimMiktari;
        private DevExpress.XtraEditors.SpinEdit txtAdet;
        private DevExpress.XtraEditors.LookUpEdit cmbUrun;
        private DevExpress.XtraEditors.LookUpEdit cmbTedarikci;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSiparis;
        private DevExpress.XtraEditors.TextEdit txtToplamTutar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource siparisViewModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunID;
        private DevExpress.XtraGrid.Columns.GridColumn colTedarikciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTedarikciID;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamFiyat;
        private DevExpress.XtraEditors.SimpleButton btnUrunuCikar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem simpleButtonLCI;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraNavBar.NavBarItem SiparisiTamamla;
    }
}