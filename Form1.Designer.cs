namespace p2
{
    partial class Form1
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkod_poczta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiejscowosc_Isotis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiejscowosc_Poprawna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSzerokosc_geograficzna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDlugosc_geograficzna = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKomunikat_bledu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.miejscowosciDataSet1 = new p2.MiejscowosciDataSet();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.barEditItem4 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.miejscowosciCSVTableAdapter1 = new p2.MiejscowosciDataSetTableAdapters.miejscowosciCSVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkod_poczta,
            this.colkraj,
            this.colmiejscowosc_Isotis,
            this.colMiejscowosc_Poprawna,
            this.colSzerokosc_geograficzna,
            this.colDlugosc_geograficzna,
            this.colID,
            this.colKomunikat_bledu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colkod_poczta
            // 
            this.colkod_poczta.FieldName = "kod_poczta";
            this.colkod_poczta.MinWidth = 30;
            this.colkod_poczta.Name = "colkod_poczta";
            this.colkod_poczta.Visible = true;
            this.colkod_poczta.VisibleIndex = 0;
            this.colkod_poczta.Width = 112;
            // 
            // colkraj
            // 
            this.colkraj.FieldName = "kraj";
            this.colkraj.MinWidth = 30;
            this.colkraj.Name = "colkraj";
            this.colkraj.Visible = true;
            this.colkraj.VisibleIndex = 1;
            this.colkraj.Width = 112;
            // 
            // colmiejscowosc_Isotis
            // 
            this.colmiejscowosc_Isotis.FieldName = "miejscowosc_Isotis";
            this.colmiejscowosc_Isotis.MinWidth = 30;
            this.colmiejscowosc_Isotis.Name = "colmiejscowosc_Isotis";
            this.colmiejscowosc_Isotis.Visible = true;
            this.colmiejscowosc_Isotis.VisibleIndex = 2;
            this.colmiejscowosc_Isotis.Width = 112;
            // 
            // colMiejscowosc_Poprawna
            // 
            this.colMiejscowosc_Poprawna.FieldName = "Miejscowosc_Poprawna";
            this.colMiejscowosc_Poprawna.MinWidth = 30;
            this.colMiejscowosc_Poprawna.Name = "colMiejscowosc_Poprawna";
            this.colMiejscowosc_Poprawna.Visible = true;
            this.colMiejscowosc_Poprawna.VisibleIndex = 3;
            this.colMiejscowosc_Poprawna.Width = 112;
            // 
            // colSzerokosc_geograficzna
            // 
            this.colSzerokosc_geograficzna.FieldName = "Szerokosc_geograficzna";
            this.colSzerokosc_geograficzna.MinWidth = 30;
            this.colSzerokosc_geograficzna.Name = "colSzerokosc_geograficzna";
            this.colSzerokosc_geograficzna.Visible = true;
            this.colSzerokosc_geograficzna.VisibleIndex = 4;
            this.colSzerokosc_geograficzna.Width = 112;
            // 
            // colDlugosc_geograficzna
            // 
            this.colDlugosc_geograficzna.FieldName = "Dlugosc_geograficzna";
            this.colDlugosc_geograficzna.MinWidth = 30;
            this.colDlugosc_geograficzna.Name = "colDlugosc_geograficzna";
            this.colDlugosc_geograficzna.Visible = true;
            this.colDlugosc_geograficzna.VisibleIndex = 5;
            this.colDlugosc_geograficzna.Width = 112;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 30;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 6;
            this.colID.Width = 112;
            // 
            // colKomunikat_bledu
            // 
            this.colKomunikat_bledu.FieldName = "Komunikat_bledu";
            this.colKomunikat_bledu.MinWidth = 30;
            this.colKomunikat_bledu.Name = "colKomunikat_bledu";
            this.colKomunikat_bledu.Visible = true;
            this.colKomunikat_bledu.VisibleIndex = 7;
            this.colKomunikat_bledu.Width = 112;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "miejscowosciCSV";
            this.gridControl1.DataSource = this.miejscowosciDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView1;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "Level2";
            gridLevelNode3.RelationName = "Level3";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1869, 909);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.gridView2,
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // miejscowosciDataSet1
            // 
            this.miejscowosciDataSet1.DataSetName = "MiejscowosciDataSet";
            this.miejscowosciDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "kod_poczta";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 112;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "kraj";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 112;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "miejscowosc_Isotis";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Miejscowosc_Poprawna";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 112;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "Szerokosc_geograficzna";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 112;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Dlugosc_geograficzna";
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 112;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "ID";
            this.gridColumn7.MinWidth = 30;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 112;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "Komunikat_bledu";
            this.gridColumn8.MinWidth = 30;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 112;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.barButtonItem4);
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 44, 45, 44);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barEditItem1,
            this.barEditItem2,
            this.barEditItem3,
            this.barEditItem4,
            this.barButtonItem5,
            this.barCheckItem1,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.PageHeaderItemLinks.Add(this.barButtonItem10);
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemButtonEdit1,
            this.repositoryItemTextEdit3});
            this.ribbonControl1.Size = new System.Drawing.Size(1869, 86);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Usun rekord";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "ID:";
            this.barEditItem1.Edit = this.repositoryItemTextEdit1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "ID:";
            this.barEditItem2.Edit = this.repositoryItemTextEdit2;
            this.barEditItem2.Id = 5;
            this.barEditItem2.Name = "barEditItem2";
            this.barEditItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem2_ItemClick);
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemButtonEdit1;
            this.barEditItem3.Id = 6;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // barEditItem4
            // 
            this.barEditItem4.Caption = "ID:";
            this.barEditItem4.Edit = this.repositoryItemTextEdit3;
            this.barEditItem4.Id = 7;
            this.barEditItem4.Name = "barEditItem4";
            this.barEditItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem4_ItemClick);
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "usun rekord";
            this.barButtonItem5.Id = 9;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "usun rekord";
            this.barCheckItem1.Id = 10;
            this.barCheckItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.ImageOptions.Image")));
            this.barCheckItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barCheckItem1.ImageOptions.LargeImage")));
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "usun rekord";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "barButtonItem8";
            this.barButtonItem8.Id = 13;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "barButtonItem9";
            this.barButtonItem9.Id = 14;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "usun";
            this.barButtonItem10.Id = 15;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // miejscowosciCSVTableAdapter1
            // 
            this.miejscowosciCSVTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 995);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Miejscowosci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MiejscowosciDataSet miejscowosciDataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colkod_poczta;
        private DevExpress.XtraGrid.Columns.GridColumn colkraj;
        private DevExpress.XtraGrid.Columns.GridColumn colmiejscowosc_Isotis;
        private DevExpress.XtraGrid.Columns.GridColumn colMiejscowosc_Poprawna;
        private DevExpress.XtraGrid.Columns.GridColumn colSzerokosc_geograficzna;
        private DevExpress.XtraGrid.Columns.GridColumn colDlugosc_geograficzna;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colKomunikat_bledu;
        private MiejscowosciDataSetTableAdapters.miejscowosciCSVTableAdapter miejscowosciCSVTableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}

