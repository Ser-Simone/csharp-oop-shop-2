using Csharp_Shop_2;


Prodotto shop = new Prodotto("Pasta", "spaghetti", 1);
Console.WriteLine("------- PRODOTTO 1--------");
shop.StampaProdotto();


Prodotto shop2 = new Prodotto("Marmellata", "marmellata di fichi", 3);
Console.WriteLine("------- PRODOTTO 2--------");
shop2.StampaProdotto();

Prodotto shop3 = new Prodotto("Pizza", "Napoli", 4.50);
Console.WriteLine("------- PRODOTTO 3--------");
shop3.StampaProdotto();

Acqua MiaAcqua = new Acqua("Acqua", "Acqua Naturale", 0.80, 1.5, 6.8, "Rebruant");
//Acqua.Conversione(1.5);
Console.ReadKey();


/*Console.WriteLine("Inserisci i litri da convertire");
double litri = double.Parse(Console.ReadLine());
Acqua.ConversioneLitriGallone(litri);*/

Console.ReadKey();
Console.Clear();

//MiaAcqua.Bevi(litri);
//MiaAcqua.Riempi(0.2);

Console.WriteLine("------- PRODOTTO 4--------");
MiaAcqua.StampaProdotto();
CiboInScatola MioCibo = new CiboInScatola("Fagioli", "Fagioli Saclà in barattolo", 1.89, 300, 13, "vetro \n");
MioCibo.Mangia(450);
MioCibo.Butta("no");

Frutta MioSacchetto = new Frutta("Festa", "Sacchetto di frutta", 3.50);
MioSacchetto.componiSacchetto();

Console.WriteLine(" \n ------- PRODOTTO 5--------");
Elettrodomestico MioElettrodomestico = new Elettrodomestico("Frigorigero", "Frigorifero da incasso", 0.5, "Indensit", 18, "Bianco");
MioElettrodomestico.accensione(1);
MioElettrodomestico.StampaProdotto();

