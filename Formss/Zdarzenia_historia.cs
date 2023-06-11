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
    public partial class Zdarzenia_historia : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Zdarzenia_historia()
        {
            InitializeComponent();

            if (ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaHistoria != null)
            {

                string stanGrida = ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaHistoria;

                byte[] bufor = Convert.FromBase64String(stanGrida);
                MemoryStream ms = new MemoryStream(bufor);
                ms.Seek(0, SeekOrigin.Begin);

                gridView1.RestoreLayoutFromStream(ms);
                Application.DoEvents();
            }
        }

        private void Zdarzenia_historia_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'miejscowosciDataSet.v_Zdarzenia' . Możesz go przenieść lub usunąć.
            this.v_ZdarzeniaTableAdapter.Fill(this.miejscowosciDataSet.v_Zdarzenia);

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void Zdarzenia_historia_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.MemoryStream ms = new MemoryStream();
            gridView1.SaveLayoutToStream(ms);
            byte[] bufor = ms.ToArray();
            string ustawieniaTabelki = Convert.ToBase64String(bufor);
            Console.WriteLine(ustawieniaTabelki);
            ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaHistoria = ustawieniaTabelki;
            using (MiejscowosciEntities db = new MiejscowosciEntities())
            {
                db.Pracownik.Where(f => f.PracownikId == ZmienneGlobalne.ZalogowanyPraocnwik.PracownikId).First().StanGridaHistoria = ZmienneGlobalne.ZalogowanyPraocnwik.StanGridaHistoria;
                db.SaveChanges();
            }
        }
    }
}