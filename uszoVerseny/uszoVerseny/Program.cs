using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uszoVerseny
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Versenyzo
    {
        public string Rajtszam { get; private set; }
        public string Nev { get; private set; }
        public DateTime SzulDatum { get; private set; }
        public string Orszag { get; private set; }
        public TimeSpan IdoEredmeny { get; private set; }

        public Versenyzo(string rajtszam, string nev, DateTime szulDatum, string orszag, TimeSpan idoEredmeny)
        {
            this.Rajtszam = rajtszam;
            this.Nev = nev;
            this.SzulDatum = szulDatum;
            this.Orszag = orszag;
            this.IdoEredmeny = idoEredmeny;
        }

        public override string ToString()
        {
            return Nev;
        }
    }

}
