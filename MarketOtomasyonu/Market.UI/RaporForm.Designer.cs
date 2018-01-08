namespace Market.UI
{
    partial class RaporForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporForm));
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl = new DevExpress.XtraNavBar.NavBarControl();
            this.islemler = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnSiparişRaporu = new DevExpress.XtraNavBar.NavBarItem();
            this.btnGunlukSiparisRaporu = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAylıkSiparisRaporu = new DevExpress.XtraNavBar.NavBarItem();
            this.btnSiparisCiktiAl = new DevExpress.XtraNavBar.NavBarItem();
            this.btnGunlukSatisCikti = new DevExpress.XtraNavBar.NavBarItem();
            this.btnAylikSatisCikti = new DevExpress.XtraNavBar.NavBarItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.layoutControl2);
            this.layoutControl3.Controls.Add(this.layoutControl1);
            this.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl3.Location = new System.Drawing.Point(0, 0);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup3;
            this.layoutControl3.Size = new System.Drawing.Size(1010, 789);
            this.layoutControl3.TabIndex = 2;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gridControl1);
            this.layoutControl2.Location = new System.Drawing.Point(307, 16);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(687, 757);
            this.layoutControl2.TabIndex = 5;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(16, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(655, 725);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(687, 757);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(661, 731);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.navBarControl);
            this.layoutControl1.Location = new System.Drawing.Point(16, 16);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(285, 757);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl
            // 
            this.navBarControl.ActiveGroup = this.islemler;
            this.navBarControl.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.islemler});
            this.navBarControl.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnSiparişRaporu,
            this.btnGunlukSiparisRaporu,
            this.btnAylıkSiparisRaporu,
            this.btnSiparisCiktiAl,
            this.btnGunlukSatisCikti,
            this.btnAylikSatisCikti});
            this.navBarControl.Location = new System.Drawing.Point(16, 16);
            this.navBarControl.Name = "navBarControl";
            this.navBarControl.OptionsNavPane.ExpandedWidth = 253;
            this.navBarControl.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.ExplorerBar;
            this.navBarControl.Size = new System.Drawing.Size(253, 725);
            this.navBarControl.StoreDefaultPaintStyleName = true;
            this.navBarControl.TabIndex = 7;
            this.navBarControl.Text = "navBarControl1";
            // 
            // islemler
            // 
            this.islemler.Caption = "İşlemler";
            this.islemler.Expanded = true;
            this.islemler.Hint = "Kategori";
            this.islemler.ImageOptions.LargeImageIndex = 0;
            this.islemler.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSiparişRaporu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnGunlukSiparisRaporu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAylıkSiparisRaporu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnSiparisCiktiAl),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnGunlukSatisCikti),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnAylikSatisCikti)});
            this.islemler.Name = "islemler";
            // 
            // btnSiparişRaporu
            // 
            this.btnSiparişRaporu.Caption = "Sipariş Raporu";
            this.btnSiparişRaporu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSiparişRaporu.ImageOptions.SmallImage")));
            this.btnSiparişRaporu.ImageOptions.SmallImageIndex = 0;
            this.btnSiparişRaporu.Name = "btnSiparişRaporu";
            this.btnSiparişRaporu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnSiparişRaporu_LinkClicked);
            // 
            // btnGunlukSiparisRaporu
            // 
            this.btnGunlukSiparisRaporu.Caption = "Günlük Satış Raporu";
            this.btnGunlukSiparisRaporu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGunlukSiparisRaporu.ImageOptions.SmallImage")));
            this.btnGunlukSiparisRaporu.ImageOptions.SmallImageIndex = 1;
            this.btnGunlukSiparisRaporu.Name = "btnGunlukSiparisRaporu";
            this.btnGunlukSiparisRaporu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnGunlukSiparisRaporu_LinkClicked);
            // 
            // btnAylıkSiparisRaporu
            // 
            this.btnAylıkSiparisRaporu.Caption = "Aylık Satış Raporu";
            this.btnAylıkSiparisRaporu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAylıkSiparisRaporu.ImageOptions.SmallImage")));
            this.btnAylıkSiparisRaporu.ImageOptions.SmallImageIndex = 2;
            this.btnAylıkSiparisRaporu.Name = "btnAylıkSiparisRaporu";
            this.btnAylıkSiparisRaporu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAylıkSiparisRaporu_LinkClicked);
            // 
            // btnSiparisCiktiAl
            // 
            this.btnSiparisCiktiAl.Caption = "Sipariş Raporu Çıktı Al";
            this.btnSiparisCiktiAl.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisCiktiAl.ImageOptions.SmallImage")));
            this.btnSiparisCiktiAl.Name = "btnSiparisCiktiAl";
            this.btnSiparisCiktiAl.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnCiktiAl_LinkClicked);
            // 
            // btnGunlukSatisCikti
            // 
            this.btnGunlukSatisCikti.Caption = "Günlük Satış Raporu Çıktı Al";
            this.btnGunlukSatisCikti.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnGunlukSatisCikti.ImageOptions.SmallImage")));
            this.btnGunlukSatisCikti.Name = "btnGunlukSatisCikti";
            this.btnGunlukSatisCikti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnGunlukSatisCikti_LinkClicked);
            // 
            // btnAylikSatisCikti
            // 
            this.btnAylikSatisCikti.Caption = "Aylık Satış Raporu Çıktı Al";
            this.btnAylikSatisCikti.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAylikSatisCikti.ImageOptions.SmallImage")));
            this.btnAylikSatisCikti.Name = "btnAylikSatisCikti";
            this.btnAylikSatisCikti.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnAylikSatisCikti_LinkClicked);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 4;
            this.Root.Size = new System.Drawing.Size(285, 757);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.navBarControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(259, 731);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1010, 789);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(291, 763);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(291, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(693, 763);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 789);
            this.Controls.Add(this.layoutControl3);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl;
        private DevExpress.XtraNavBar.NavBarGroup islemler;
        private DevExpress.XtraNavBar.NavBarItem btnSiparişRaporu;
        private DevExpress.XtraNavBar.NavBarItem btnGunlukSiparisRaporu;
        private DevExpress.XtraNavBar.NavBarItem btnAylıkSiparisRaporu;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraNavBar.NavBarItem btnSiparisCiktiAl;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraNavBar.NavBarItem btnGunlukSatisCikti;
        private DevExpress.XtraNavBar.NavBarItem btnAylikSatisCikti;
    }
}