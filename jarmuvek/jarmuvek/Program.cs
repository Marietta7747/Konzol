using System;
using System.Collections.Generic;
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
        public static double Haszondij { get; set; }

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
            return (int)(AlapDij + AktualisKoltseg + AktualisKoltseg * Haszondij / 100);
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
    }
}
