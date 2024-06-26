using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listakezeles
{
    class Versenyzok
    {
        private int rajtSzam;
        private string nev;
        private string szak;

        private int pontSzam;

        public Versenyzok(int rajtSzam, string nev, string szak)
        {
            this.rajtSzam = rajtSzam;
            this.nev = nev;
            this.szak = szak;
        }

        public int RajtSzam
        {
            get { return rajtSzam; }
        }

        public string Nev
        {
            get { return nev; }
        }

        public string Szak
        {
            get { return szak; }
        }

        public int PontSzam
        {
            get { return pontSzam; }
        }

        public void PontotKap(int pont)
        {
            pontSzam += pont;
        }

        public override string ToString()
        {
            return rajtSzam + "\t" + nev + "\t" + szak + "\t" + pontSzam + " pont";
        }
    }

    class VezerloOsztaly
    {
        private List<Versenyzok> versenyzok = new List<Versenyzok>();
        private int zsuriLetszam = 5;
        private int pontHatar = 10;
        public void Start()
        {
            AdatBevitel();

            Kiiratas("\nRésztvevők\n");
            Verseny();
            Kiiratas("\nEredmények\n");

            Eredmenyek();
            Keresesek();
        }

        private void AdatBevitel()
        {
            string nev, szak;
            int sorszam = 1;

            StreamReader sr = new StreamReader("versenyzok.txt");

            while (!sr.EndOfStream)
            {
                nev = sr.ReadLine();
                szak = sr.ReadLine();

                versenyzok.Add(new Versenyzok(sorszam, nev, szak)); 
                sorszam++;
            }

            sr.Close();
        }

        private void Kiiratas(string cim)
        {
            Console.WriteLine(cim);
            foreach(Versenyzok enekes in versenyzok)
            {
                Console.WriteLine(enekes);
            }
        }

        private void Verseny()
        {
            Random rand = new Random();
            int pont;
            foreach(Versenyzok versenyzo in versenyzok)
            {
                for (int i = 0; i < zsuriLetszam; i++)
                {
                    pont = rand.Next(pontHatar);
                    versenyzo.PontotKap(pont);
                }
            }
        }

        private void Eredmenyek()
        {
            Nyertes();
            Sorrend();
        }

        private void Nyertes()
        {
            int max = versenyzok[0].PontSzam;

            foreach(Versenyzok enekes in versenyzok)
            {
                if (enekes.PontSzam > max)
                {
                    max = enekes.PontSzam;
                }
            }

            Console.WriteLine("\nA legjobb(ak)\n");
            foreach(Versenyzok enekes in versenyzok)
            {
                if (enekes.PontSzam == max)
                {
                    Console.WriteLine(enekes);
                }
            }
        }

        private void Sorrend()
        {
            Versenyzok temp;
            for (int i = 0; i < versenyzok.Count-1; i++)
            {
                for(int j = 0; j < versenyzok.Count; j++)
                {
                    if (versenyzok[i].PontSzam < versenyzok[j].PontSzam)
                    {
                        temp = versenyzok[i];
                        versenyzok[i] = versenyzok[j];
                        versenyzok[j] = temp;
                    }
                }
            }

            Kiiratas("\nEredménytábla\n");
        }

        private void Keresesek()
        {
            Console.WriteLine("\nAdott szakhoz tartozó énekesek keresése\n");
            Console.Write("\nKeres valakit? (i/n) ");
            char valasz;
            while(!char.TryParse(Console.ReadLine(), out valasz))
            {
                Console.WriteLine("Egy karaktert írjon. ");
            }

            string szak;
            bool vanIlyen;

            while(valasz == 'i' || valasz == 'I')
            {
                Console.Write("Szak: ");
                szak = Console.ReadLine();
                vanIlyen = false;

                foreach (Versenyzok enekes in versenyzok)
                {
                    if (enekes.Szak == szak)
                    {
                        Console.WriteLine(enekes);
                        vanIlyen=true;
                    }
                }

                if (!vanIlyen)
                {
                    Console.WriteLine("Erről a szakról senki sem indult.");
                }

                Console.Write("\nKeres még valakit? (i/n) ");
                valasz = char.Parse(Console.ReadLine());
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            new VezerloOsztaly().Start();

            

            Console.ReadKey();
        }
    }
}
