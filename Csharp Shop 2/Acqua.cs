using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_Shop_2
{
    internal class Acqua : Prodotto
    {
        private double litri;
        public double ph;
        public string sorgente;

        public Acqua(string nomeAcqua, string descrizioneAcqua, double prezzoAcqua, double litri, double ph, string sorgente) : base (nomeAcqua, descrizioneAcqua, prezzoAcqua)
            {
            this.litri = litri;
            this.ph = ph;
            this.sorgente = sorgente;
            }
        public void Bevi(double litriDaBere)
        {
            if (this.litri - litriDaBere > 0)
            {
                this.litri = this.litri - litriDaBere;
                Console.WriteLine("glu glu glu, ho bevuto" + litriDaBere);
            }
            else
            {
                Console.WriteLine("glu glu glu, mi dispiace hai finito la bottiglia");
                this.litri = 0;
            }
        }

        public void Riempi(double litriDaRiempire)
        {
            if (litriDaRiempire > this.litri)
            {
                
                Console.WriteLine("La bottiglia è piena" + litriDaRiempire);
            }
            else
            {
                Console.WriteLine("glu glu glu, hai riempito la bottiglia");
                this.litri = this.litri + litriDaRiempire;
            }
        }
            public void Svuota(double litriDaSvuotare)
            {
                if (litriDaSvuotare < this.litri)
                {
                    Console.WriteLine("hai svuotato la bottiglia, hai tolto" + litriDaSvuotare);
                    this.litri = this.litri - litriDaSvuotare;
                }
                else
                {
                    Console.WriteLine("La bottiglia è vuolta" + this.litri);
                }

            }

        public static void Conversione(double litri)
        {
            double gallone = 3.785;
            double litrig = 0;

            if (litri > 0)
            {
                litrig = gallone * litri;
                Console.WriteLine("i tuoi litri sono: " +litrig);
            }
            else
            {
                litrig = litrig / litri;
                Console.WriteLine("i tuoi litri sono: " +litrig);
            }
            
        }
        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("I litri sono: " + litri);
            Console.WriteLine("Il ph  è: " + ph);
            Console.WriteLine("la sorgente è: " + sorgente);
        }

    }
}
