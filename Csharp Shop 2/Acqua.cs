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
        private readonly double ph;
        private readonly string sorgente;
        public static readonly double maxCapienza = 1.5;

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
            if (litriDaRiempire + this.litri > maxCapienza)
            {
                
                Console.WriteLine("La bottiglia è piena" + litriDaRiempire);
                this.litri = maxCapienza;
                
            } else if (litriDaRiempire< 0)
            {
                Console.WriteLine("non puoi riempire la bottiglia con un valore negativo");
            }
            else
            {
                Console.WriteLine("hai riempito la bottiglia");
                this.litri = this.litri + litriDaRiempire;
            }
        }
            public void Svuota()
            {
            this.litri = 0;
            }

        public static void ConversioneLitriGallone(double litri)
        {
           const double gallone = 3.785;
            double litriInGallone = 0;

            if (litri > 0)
            {
                litriInGallone = gallone * litri;
                Console.WriteLine("i tuoi Galloni sono: " +litriInGallone);
            }
            else 
            {
                 Console.WriteLine("Nonn puoi convertire una quantità negativa");
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
