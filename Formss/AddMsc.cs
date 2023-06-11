using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsServiceXGlobals;

namespace p2.Formss
{
    public partial class AddMsc : DevExpress.XtraEditors.XtraForm
    {
        public AddMsc()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton1.Enabled = false;
            Application.DoEvents();

            if (XtraMessageBox.Show("Dodac rekord: " + textEdit1.Text + " -- " + textEdit2.Text + " -- " + textEdit3.Text + " -- " + textEdit4.Text + " do bazy?", "Czy na pewno ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MiejscowosciEntities db = new MiejscowosciEntities())
                {
                    miejscowosciCSV mscc = new miejscowosciCSV();
                    mscc.kod_poczta = textEdit1.Text;
                    mscc.kraj = textEdit2.Text;
                    mscc.miejscowosc_Isotis = textEdit3.Text;
                    mscc.Miejscowosc_Poprawna = textEdit4.Text;
                    mscc.Szerokosc_geograficzna = textEdit5.Text;
                    mscc.Dlugosc_geograficzna = textEdit6.Text;
                    
                    db.miejscowosciCSV.Add(mscc);

                    DateTime dateTime = DateTime.Now;

                    PracownikHistoria zdarzenie = new PracownikHistoria();
                    zdarzenie.PracownikHistoriaIdP = ZmienneGlobalne.ZalogowanyPraocnwik.PracownikId;
                    zdarzenie.PracownikHistoriaCzas = dateTime;
                    zdarzenie.PracownikHistoriaOpisZdarzenia = "Dodanie rekordu " + textEdit1.Text + " -- " + textEdit2.Text + " -- " + textEdit3.Text + " -- " + textEdit4.Text + " do bazy";
                    db.PracownikHistoria.Add(zdarzenie);
                    db.SaveChanges();

                    if (ZmienneGlobalne.ListaMiejscowosci != null)
                    {
                        ZmienneGlobalne.ListaMiejscowosci.Odswiez();
                    }
                }
            }



            simpleButton1.Enabled = true;
            Application.DoEvents();

            this.Close();
        }
    }
}