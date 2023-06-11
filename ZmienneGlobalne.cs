 using p2.Formss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsServiceXGlobals;

namespace p2
{
    public static  class ZmienneGlobalne
    {
        public static bool CzyWylogowanie = false;
        public static Logowanie GlownaForma = null;
        public static Form1 ListaMiejscowosci = null;
        public static Pracownik ZalogowanyPraocnwik = null;


        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (MD5 hash = MD5.Create())
            {
                return String.Join
                (
                    "",
                    from ba in hash.ComputeHash
                    (
                        Encoding.UTF8.GetBytes(input)
                    )
                    select ba.ToString("x2")
                );
            }
        }
    }

  
}
