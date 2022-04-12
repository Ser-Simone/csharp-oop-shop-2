using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Csharp_Shop_2
{
    internal class Prodotto
    {

        private string nome;
        private string descrizione;
        private double prezzo;



        public Prodotto(string nome, string descrizione, double prezzo)
        {
            
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
           
        }

        public double getCodiceProdotto()
        {
            double codice;
            Random random = new Random();
            codice = random.Next(1000, 100000000);
            return codice;
        }

        public double ivaProdotto()
        {
            double iva;
            iva = prezzo * 1.22;
            return iva;
        }

        public virtual void StampaProdotto()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("Il nome del prodotto è: " + nome);
            Console.WriteLine("Descrizione del prodotto " + descrizione);
            Console.WriteLine("Il prezzo è: " + prezzo + " €");
            Console.WriteLine("Il prezzo compreso di iva è: " + ivaProdotto());
            Console.WriteLine("Il codice del prodotto è: " + nome + getCodiceProdotto());
        }

    }
}
