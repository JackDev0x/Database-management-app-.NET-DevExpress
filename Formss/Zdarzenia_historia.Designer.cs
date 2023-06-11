namespace p2.Formss
{
    partial class Zdarzenia_historia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zdarzenia_historia));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vZdarzeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.miejscowosciDataSet = new p2.MiejscowosciDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPracownikHistoriaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPracownikHistoriaIdP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPracownikHistoriaCzas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPracownikHistoriaOpisZdarzenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPracownikPelnaNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.v_ZdarzeniaTableAdapter = new p2.MiejscowosciDataSetTableAdapters.v_ZdarzeniaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZdarzeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.barButtonItem1);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(1682, 86);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Drukuj/eksportuj";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vZdarzeniaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 86);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1682, 769);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vZdarzeniaBindingSource
            // 
            this.vZdarzeniaBindingSource.DataMember = "v_Zdarzenia";
            this.vZdarzeniaBindingSource.DataSource = this.miejscowosciDataSet;
            // 
            // miejscowosciDataSet
            // 
            this.miejscowosciDataSet.DataSetName = "MiejscowosciDataSet";
            this.miejscowosciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPracownikHistoriaId,
            this.colPracownikHistoriaIdP,
            this.colPracownikHistoriaCzas,
            this.colPracownikHistoriaOpisZdarzenia,
            this.colPracownikPelnaNazwa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colPracownikHistoriaId
            // 
            this.colPracownikHistoriaId.Caption = "ID zdarzenia";
            this.colPracownikHistoriaId.FieldName = "PracownikHistoriaId";
            this.colPracownikHistoriaId.MinWidth = 30;
            this.colPracownikHistoriaId.Name = "colPracownikHistoriaId";
            this.colPracownikHistoriaId.Visible = true;
            this.colPracownikHistoriaId.VisibleIndex = 0;
            this.colPracownikHistoriaId.Width = 146;
            // 
            // colPracownikHistoriaIdP
            // 
            this.colPracownikHistoriaIdP.Caption = "ID pracownika";
            this.colPracownikHistoriaIdP.FieldName = "PracownikHistoriaIdP";
            this.colPracownikHistoriaIdP.MinWidth = 30;
            this.colPracownikHistoriaIdP.Name = "colPracownikHistoriaIdP";
            this.colPracownikHistoriaIdP.Visible = true;
            this.colPracownikHistoriaIdP.VisibleIndex = 2;
            this.colPracownikHistoriaIdP.Width = 171;
            // 
            // colPracownikHistoriaCzas
            // 
            this.colPracownikHistoriaCzas.Caption = "Czas";
            this.colPracownikHistoriaCzas.FieldName = "PracownikHistoriaCzas";
            this.colPracownikHistoriaCzas.MinWidth = 30;
            this.colPracownikHistoriaCzas.Name = "colPracownikHistoriaCzas";
            this.colPracownikHistoriaCzas.Visible = true;
            this.colPracownikHistoriaCzas.VisibleIndex = 3;
            this.colPracownikHistoriaCzas.Width = 135;
            // 
            // colPracownikHistoriaOpisZdarzenia
            // 
            this.colPracownikHistoriaOpisZdarzenia.Caption = "Opis zdarzenia";
            this.colPracownikHistoriaOpisZdarzenia.FieldName = "PracownikHistoriaOpisZdarzenia";
            this.colPracownikHistoriaOpisZdarzenia.MinWidth = 30;
            this.colPracownikHistoriaOpisZdarzenia.Name = "colPracownikHistoriaOpisZdarzenia";
            this.colPracownikHistoriaOpisZdarzenia.Visible = true;
            this.colPracownikHistoriaOpisZdarzenia.VisibleIndex = 4;
            this.colPracownikHistoriaOpisZdarzenia.Width = 950;
            // 
            // colPracownikPelnaNazwa
            // 
            this.colPracownikPelnaNazwa.Caption = "Pracownik";
            this.colPracownikPelnaNazwa.FieldName = "PracownikPelnaNazwa";
            this.colPracownikPelnaNazwa.MinWidth = 30;
            this.colPracownikPelnaNazwa.Name = "colPracownikPelnaNazwa";
            this.colPracownikPelnaNazwa.Visible = true;
            this.colPracownikPelnaNazwa.VisibleIndex = 1;
            this.colPracownikPelnaNazwa.Width = 244;
            // 
            // v_ZdarzeniaTableAdapter
            // 
            this.v_ZdarzeniaTableAdapter.ClearBeforeFill = true;
            // 
            // Zdarzenia_historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 855);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "Zdarzenia_historia";
            this.Ribbon = this.ribbon;
            this.Text = "Zdarzenia_historia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zdarzenia_historia_FormClosing);
            this.Load += new System.EventHandler(this.Zdarzenia_historia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vZdarzeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miejscowosciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MiejscowosciDataSet miejscowosciDataSet;
        private System.Windows.Forms.BindingSource vZdarzeniaBindingSource;
        private MiejscowosciDataSetTableAdapters.v_ZdarzeniaTableAdapter v_ZdarzeniaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikHistoriaId;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikHistoriaIdP;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikHistoriaCzas;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikHistoriaOpisZdarzenia;
        private DevExpress.XtraGrid.Columns.GridColumn colPracownikPelnaNazwa;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}