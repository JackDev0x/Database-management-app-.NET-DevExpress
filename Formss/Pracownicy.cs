using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsServiceXGlobals;

namespace p2.Formss
{
    public partial class Pracownicy : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Pracownicy()
        {
            InitializeComponent();

            if (ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaPracownicy != null)
            {

                string stanGrida = ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaPracownicy;

                byte[] bufor = Convert.FromBase64String(stanGrida);
                MemoryStream ms = new MemoryStream(bufor);
                ms.Seek(0, SeekOrigin.Begin);

                gridView1.RestoreLayoutFromStream(ms);
                Application.DoEvents();
            }
        }

        private void Pracownicy_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'miejscowosciDataSet.Pracownik' . Możesz go przenieść lub usunąć.
            this.pracownikTableAdapter.Fill(this.miejscowosciDataSet.Pracownik);

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void Pracownicy_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.MemoryStream ms = new MemoryStream();
            gridView1.SaveLayoutToStream(ms);
            byte[] bufor = ms.ToArray();
            string ustawieniaTabelki = Convert.ToBase64String(bufor);
            Console.WriteLine(ustawieniaTabelki);
            ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaPracownicy = ustawieniaTabelki;
            using (MiejscowosciEntities db = new MiejscowosciEntities())
            {
                db.Pracownik.Where(f => f.PracownikId == ZmienneGlobalne.ZalogowanyPraocnwik.PracownikId).First().StanGridaPracownicy = ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaPracownicy;
                db.SaveChanges();
            }
        }
    }
}