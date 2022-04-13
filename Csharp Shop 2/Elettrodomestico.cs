using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Elettrodomestico : Prodotto
    {
        private string marca;
        private double kw;
        private string colore;
        private bool power;

        public Elettrodomestico (string nome, string descrizione, double prezzo, string marca, double kw, string colore) : base (nome, descrizione, prezzo)
        {
            this.marca = marca;
            this.kw = kw;
            this.colore = colore;
            this.power = false;
        }

        public void accensione()
        {
            power = true;
                Console.WriteLine("Il tuo elettrodomestico è accesso");
          
        }

        public override void StampaProdotto()
        {
            base.StampaProdotto();
            Console.WriteLine("La marca è: " + marca);
            Console.WriteLine("I kw sono: " + kw);
            Console.WriteLine("Il colore è: " + colore);
        }
    }

}
