namespace p2.Formss
{
    partial class Pracownicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pracownicy));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pracownikBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.miejscowosciDataSet = new p2.MiejscowosciDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPracownikId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPracownikPelnaNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPracownikAktywny = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownikTableAdapter = new p2.MiejscowosciDataSetTableAdapters.PracownikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.barButtonItem4);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem2,
            this.barButtonItem1,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(1704, 86);
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem3.Caption = "Drukuj/eksportuj";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pracownikBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1704, 903);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // pracownikBindingSource1
            // 
            this.pracownikBindingSource1.DataMember = "Pracownik";
            this.pracownikBindingSource1.DataSource = this.miejscowosciDataSet;
            // 
            // miejscowosciDataSet
            // 
            this.miejscowosciDataSet.DataSetName = "MiejscowosciDataSet";
            this.miejscowosciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPracownikId,
            this.colPracownikPelnaNazwa,
            this.colPracownikAktywny});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colPracownikId
            // 
            this.colPracownikId.FieldName = "PracownikId";
            this.colPracownikId.MinWidth = 30;
            this.colPracownikId.Name = "colPracownikId";
            this.colPracownikId.Visible = true;
            this.colPracownikId.VisibleIndex = 0;
            this.colPracownikId.Width = 112;
            // 
            // colPracownikPelnaNazwa
            // 
            this.colPracownikPelnaNazwa.FieldName = "PracownikPelnaNazwa";
            this.colPracownikPelnaNazwa.MinWidth = 30;
            this.colPracownikPelnaNazwa.Name = "colPracownikPelnaNazwa";
            this.colPracownikPelnaNazwa.Visible = true;
            this.colPracownikPelnaNazwa.VisibleIndex = 1;
            this.colPracownikPelnaNazwa.Width = 112;
            // 
            // colPracownikAktywny
            // 
            this.colPracownikAktywny.FieldName = "PracownikAktywny";
            this.colPracownikAktywny.MinWidth = 30;
            this.colPracownikAktywny.Name = "colPracownikAktywny";
            this.colPracownikAktywny.Visible = true;
            this.colPracownikAktywny.VisibleIndex = 2;
            this.colPracownikAktywny.Width = 112;
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.miejscowosciDataSet;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // Pracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1704, 989);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Pracownicy";
            this.Ribbon = this.ribbon;
            this.Text = "Pracownicy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pracownicy_FormClosing);
            this.Load += new System.EventHandler(this.Pracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MiejscowosciDataSet miejscowosciDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private MiejscowosciDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikId;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikPelnaNazwa;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikAktywny;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private System.Windows.Forms.BindingSource pracownikBindingSource1;
    }
}