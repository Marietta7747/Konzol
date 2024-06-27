using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvek
{
    abstract class Jarmu
    {
        public string Azonosito {  get; private set; }
        public string Rendszam { get; private set; }
        public int GyartasiEv { get; private set; }
        public double Fogyasztas { get; private set; }

        public double FutottKm { get; private set; }
        public int AktualisKoltseg { get; private set; }
        public bool Szabad {  get; private set; }

        public static int AktualisEv { get; set; }
        public static int AlapDij {  get; set; }
        public static double HaszonKulcs { get; set; }

        public Jarmu(string azonosito, string rendszam, int gyartasiEv, double fogyasztas)
        {
            Azonosito = azonosito;
            Rendszam = rendszam;
            GyartasiEv = gyartasiEv;
            Fogyasztas = fogyasztas;
            this.Szabad = true;
        }

        protected Jarmu(string azonosito, string rendszam, int gyartasiEv)
        {
            Azonosito = azonosito;
            Rendszam = rendszam;
            GyartasiEv = gyartasiEv;
            this.Szabad = true;
        }

        public int Kor()
        {
            return AktualisEv - GyartasiEv;
        }

        public bool Fuvaroz(double ut, int benzinAr)
        {
            if (Szabad)
            {
                FutottKm += ut;
                AktualisKoltseg = (int)(benzinAr * ut * Fogyasztas / 100);
                Szabad = false;
                return true;
            }
            return false;
        }

        public virtual int BerletiDij()
        {
            return (int)(AlapDij + AktualisKoltseg + AktualisKoltseg * HaszonKulcs / 100);
        }

        public void Vegzett()
        {
            Szabad = true;
        }

        public override string ToString()
        {
            return "\nA" + this.GetType().Name.ToLower() +
                " azonosítója: " + Azonosito +
                "\nrendszáma: " + Rendszam +
                "\n      kora: " + Kor() + "év" +
                "\n      fogyasztás: " + Fogyasztas + "l/100 km" +
                "\n      a km-óra állása: " + FutottKm + " km";

        }
    }

    class Busz : Jarmu
    {
        public int Ferohely {  get; private set; }
        public static double Szorzo {  get; set; }

        public Busz(string azonosito, string rendszam, int gyartasiEv, double fogyasztas, int ferohely) : base(azonosito, rendszam, gyartasiEv, fogyasztas){
            this.Ferohely = ferohely;
        }

        public Busz(string azonosito, string rendszam, int gyartasiEv, int ferohely) : base(azonosito, rendszam, gyartasiEv)
        {
            this.Ferohely = ferohely;
        }

        public override int BerletiDij()
        {
            return (int)(base.BerletiDij() + Ferohely * Szorzo);
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tférőhelyek száma: " + Ferohely;
        }
    } 

    class TeherAuto : Jarmu
    {
        public TeherAuto(string azonosito, string rendszam, int gyartasiEv, double fogyasztas, double teherBiras)
            : base(azonosito, rendszam, gyartasiEv, fogyasztas)
        {
            this.TeherBiras = teherBiras;
        }

        public TeherAuto(string azonosito, string rendszam, int gyartasiEv, double teherBiras)
            : base(azonosito, rendszam, gyartasiEv)
        {
            this.TeherBiras = teherBiras;
        }

        public double TeherBiras { get; private set; }
        public static double Szorzo { get; set; }

        public override int BerletiDij()
        {
            return (int)(base.BerletiDij() + TeherBiras * Szorzo);
        }

        public override string ToString()
        {
            return base.ToString() + "\n\tteherbírás: " + TeherBiras + " tonna";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }

        class Vezerles
        {
            private List<Jarmu> jarmuvek = new List<Jarmu>();
            private string BUSZ = "busz";
            private string TEHER_AUTO = "teherautó";

            public void Indit()
            {
                StatikusBeallitas();
                AdatBevitel();
                Kiir("A regisztrált jármüvek: ");
                Mukodtet();
                Kiir("A regisztrált jármüvek: ");
                Atlagkor();
                LegtobbKilometer();
                Rendez();

            }

            private void StatikusBeallitas()
            {
                Jarmu.AktualisEv = 2015;
                Jarmu.AlapDij = 1000;
                Jarmu.HaszonKulcs = 10;

                Busz.Szorzo = 15;
                TeherAuto.Szorzo = 8.5;
            }

            private void AdatBevitel()
            {
                string tipus, rendszam, azonosito;
                int gyartEv, ferohely;
                double fogyasztas, teherbiras;

                StreamReader sr = new StreamReader("jarmuvek.txt");

                int sorszam = 1;

                while (!sr.EndOfStream)
                {
                    tipus = sr.ReadLine();
                    Console.WriteLine(tipus);
                    rendszam = sr.ReadLine();
                    gyartEv = int.Parse(sr.ReadLine());
                    fogyasztas = double.Parse(sr.ReadLine());  
                    azonosito = tipus.Substring(0,1).ToUpper() + sorszam;

                    if (tipus == BUSZ)
                    {
                        ferohely =  int.Parse(sr.ReadLine());
                        jarmuvek.Add(new Busz (azonosito, rendszam, gyartEv, fogyasztas , ferohely));
                    } else if (tipus == TEHER_AUTO){
                        teherbiras = double.Parse(sr.ReadLine());
                        jarmuvek.Add(new TeherAuto (azonosito , rendszam, gyartEv , fogyasztas , teherbiras));
                    }
                    sorszam++;
                }

                sr.Close();
            }

            private void Kiir(string cim)
            {
                Console.WriteLine(cim);
                foreach (Jarmu jarmu in jarmuvek)
                {
                    Console.WriteLine(jarmu);
                }
            }

            private void Mukodtet()
            {

            }

            private void Atlagkor()
            {

            }

            private void LegtobbKilometer()
            {

            }

            private void Rendez()
            {

            }
                        
        }
    }
}
