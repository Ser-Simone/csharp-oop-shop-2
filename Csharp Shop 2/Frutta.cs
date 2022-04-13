using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_2
{
    internal class Frutta : Prodotto
    {
        private protected string[] listaFrutta = { "Fragole", "Mango", "Banana", "Kiwi", "Pesca", "Anguria", "Melone"};
        private string[] sacchetto = new string[5];
        
        public Frutta (string nome, string descrizione, double prezzo) : base (nome, descrizione, prezzo)
        {
           // this.listaFrutta = listaFrutta;
          //  this.sacchetto = sacchetto;

        }
        public void componiSacchetto()
        {
            Console.WriteLine("Ecco la tua frutta a scelta");
            for (int i = 0; i < listaFrutta.Length; i++)
            {
                Console.WriteLine(listaFrutta[i]);
            }
            Console.WriteLine("Scegli di quanti frutti deve essere composto il sacchetto");
            int numFrutto = int.Parse(Console.ReadLine());

            while (numFrutto > 5)
            {
                Console.WriteLine("Non puoi selezionare più di 5 frutti");
                Console.WriteLine("Scegli di quanti frutti deve essere composto il sacchetto MAX 5 Pezzi");
                numFrutto = int.Parse(Console.ReadLine());

            }
                Console.WriteLine("Scegli il frutto");
                for (int i = 0; i < numFrutto; i++)
                {
                    sacchetto[i] = Console.ReadLine();
                }

                Console.WriteLine("Il tuo sacchetto è composto da: ");
                for (int i = 0; i < sacchetto.Length; i++)
                {
                    Console.Write(sacchetto[i]);
                }
        }
       
    }
}
