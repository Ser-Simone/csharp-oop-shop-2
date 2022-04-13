using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class CiboInScatola : Prodotto
    {
        private double grammi;
        private double carboidrati;
        private string materiale;
        public static readonly int MaxCapienza = 300;

    
    public CiboInScatola(string nome, string descrizione, double prezzo, double grammi, double carboidrati, string materiale) : base(nome, descrizione, prezzo)
    {
        this.grammi = grammi;
        this.carboidrati = carboidrati;
        this.materiale = materiale;
    }

        public void Mangia(double mangiaG)
        {
            if (this.grammi - mangiaG > 0)
            {
                this.grammi = this.grammi - mangiaG;
                Console.WriteLine("Gnam Gnam, hai mangiato" + mangiaG);
            }
            else
            {
                Console.WriteLine("gnam gnam, mi dispiace hai finito il cibo");
                this.grammi = 0;
            }
        }
        public void Butta(string risposta)
        {
            
            Console.WriteLine("Vuoi buttare il barattolo?");


            if (risposta == "si" && grammi>0)
            {
                
                Console.WriteLine("Attenzione, il barattolo non è vuoto, hai ancora;" + this.grammi);
            }
            else
            {
                Console.WriteLine("Hai buttato il barattolo");
                this.grammi = 0;
            }
        }
    }
}
