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
    public partial class Logowanie : DevExpress.XtraEditors.XtraForm
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        //"Zaloguj" button click
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //Database operations
            using (MiejscowosciEntities db = new MiejscowosciEntities())
            {
                //textEdit2 - password input in user inteface
                //making password not obtainable in database, by using cryptographic hash function - md5
                string md5hasla = ZmienneGlobalne.CreateMD5(textEdit2.Text);

                //creating a users list with the same login data as input  
                var pracownik = db.Pracownik.Where(f => f.PracownikLogin == textEdit1.Text && f.PracownikHaslo == md5hasla).ToList(); //textEdit2.Text
                
                //if there is a user in list - log in
                if (pracownik.Count == 1)
                {
                    var uzytkownik = pracownik.First();

                    //counter++;
                    label1.Visible = true;

                    ZmienneGlobalne.GlownaForma = this;
                    ZmienneGlobalne.ZalogowanyPraocnwik = uzytkownik;
                    this.Visible = false;


                    DateTime dateTime = DateTime.Now;

                    //moving to "PS" view (Panel sterowania) 
                    PS ctrl = new PS();
                    PracownikHistoria zdarzenie = new PracownikHistoria();
                    zdarzenie.PracownikHistoriaIdP = uzytkownik.PracownikId;
                    zdarzenie.PracownikHistoriaCzas = dateTime;
                    zdarzenie.PracownikHistoriaOpisZdarzenia = "Zalogowanie uzytkownika";
                    db.PracownikHistoria.Add(zdarzenie);
                    uzytkownik.PracownikAktywny = true;
                    
                    db.Pracownik.Where(f => f.PracownikId == ZmienneGlobalne.ZalogowanyPraocnwik.PracownikId).First().PracownikAktywny = true;
                    db.SaveChanges();
                    //this.Visible = false;
                    label3.Visible = false;
                    textEdit1.Text = null;
                    textEdit2.Text = null;

                    //open "PS" view as a dialog window
                    ctrl.ShowDialog();
                }
                else
                {
                    // niezalgoowany 
                    label3.Visible = true;
                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}