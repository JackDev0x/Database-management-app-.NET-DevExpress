namespace p2.Formss
{
    partial class PS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PS));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.Pracownicy = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.p2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.miejscowosciDataSet1 = new p2.MiejscowosciDataSet();
            this.miejscowosciDataSet = new p2.MiejscowosciDataSet();
            this.miejscowosciDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miejscowosciCSVTableAdapter1 = new p2.MiejscowosciDataSetTableAdapters.miejscowosciCSVTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.Pracownicy,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barListItem1,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barSubItem1,
            this.skinDropDownButtonItem1,
            this.skinPaletteRibbonGalleryBarItem1,
            this.skinDropDownButtonItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.p2});
            this.ribbon.Size = new System.Drawing.Size(1288, 231);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Dodaj miejscowosc do bazy danych";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Usun z rekord z bazy danych";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Wczytaj i wyswietl tabele \"miejscowosci\"";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Historia operacji";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // Pracownicy
            // 
            this.Pracownicy.Caption = "Pracownicy";
            this.Pracownicy.Id = 5;
            this.Pracownicy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Pracownicy.ImageOptions.Image")));
            this.Pracownicy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Pracownicy.ImageOptions.LargeImage")));
            this.Pracownicy.Name = "Pracownicy";
            this.Pracownicy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Pracownicy_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 7;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem1_ItemClick);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 8;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barStaticItem2_ItemClick);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 9;
            this.barListItem1.Name = "barListItem1";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Wyloguj";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem7.Caption = "Wyloguj";
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 13;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 14;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "barButtonItem10";
            this.barButtonItem10.Id = 15;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 16;
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.SmallWithTextWidth = 300;
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 17;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 19;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Id = 20;
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // p2
            // 
            this.p2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.p2.Name = "p2";
            this.p2.Text = "Operacje bazodanowe";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Baza danych";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.Pracownicy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Info";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.skinDropDownButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Motywy";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem7);
            this.ribbonStatusBar.ItemLinks.Add(this.barSubItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 773);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1288, 36);
            this.ribbonStatusBar.Click += new System.EventHandler(this.ribbonStatusBar_Click);
            // 
            // miejscowosciDataSet1
            // 
            this.miejscowosciDataSet1.DataSetName = "MiejscowosciDataSet";
            this.miejscowosciDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miejscowosciDataSet
            // 
            this.miejscowosciDataSet.DataSetName = "MiejscowosciDataSet";
            this.miejscowosciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // miejscowosciDataSetBindingSource
            // 
            this.miejscowosciDataSetBindingSource.DataSource = this.miejscowosciDataSet;
            this.miejscowosciDataSetBindingSource.Position = 0;
            // 
            // miejscowosciCSVTableAdapter1
            // 
            this.miejscowosciCSVTableAdapter1.ClearBeforeFill = true;
            // 
            // PS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 809);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "PS";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Panel sterowania";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PS_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PS_FormClosed);
            this.Load += new System.EventHandler(this.PS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage p2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem Pracownicy;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private System.Windows.Forms.BindingSource miejscowosciDataSetBindingSource;
        private MiejscowosciDataSet miejscowosciDataSet;
        private MiejscowosciDataSet miejscowosciDataSet1;
        private MiejscowosciDataSetTableAdapters.miejscowosciCSVTableAdapter miejscowosciCSVTableAdapter1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}