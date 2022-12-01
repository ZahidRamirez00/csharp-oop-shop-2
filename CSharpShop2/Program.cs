// See https://aka.ms/new-console-template for more information
using CSharpShop2;

Prodotto prodotto;
string myString = "";
int codice;
string nome;
string descrizione = "";
float prezzo = 0;
int iva;
float prezzoConIva;
bool controllo;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Random codiceRandom = new Random();
codice = codiceRandom.Next(1, 99999999);

Console.Write("Inserisci il nome del prodotto: ");
nome = Console.ReadLine();

Console.Write("Inserisci una descrizione del prodotto: ");
descrizione = Console.ReadLine();

Console.Write("Inserisci il prezzo del prodotto: ");
do
{
    myString = Console.ReadLine();
    //LimitDecimalPlace(myString, 2);

    if (float.TryParse(myString, out prezzo))
    {
        controllo = true;
        //Console.WriteLine("Il prezzo è: " + $"{prezzo:0.##}" + "\n");
    }
    else
    {
        Console.WriteLine("\nHai inserito un valore errato!!!");
        controllo = false;
        Console.Write("\nInserisci UN NUMERO per define il prezzo del prodotto: ");
    }
} while (!controllo);

Console.Write("Inserisci la percentuale dell'IVA: ");
do
{
    myString = Console.ReadLine();
    if (int.TryParse(myString, out iva))
        if (iva > 0 && iva <= 100)
        {
            controllo = true;
        }
        else
        {
            Console.WriteLine("\nHai inserito un valore errato!!!");
            controllo = false;
            Console.Write("\nInserisci UN NUMERO 0 a 100 per definire la percentuale dell'IVA: ");
        }
} while (!controllo);

prodotto = new Prodotto(codice, nome, descrizione, prezzo, iva);

Console.WriteLine( prodotto.StampaProdotto() );

/*
Console.WriteLine("\n------------------- Prodotto ---------------------\n");
Console.WriteLine("Codice: \t\t" + $"{prodotto.GetCodice():00000000}");
Console.WriteLine("Nome: \t\t\t" + prodotto.GetNome());
Console.WriteLine("Descrizione: \t\t" + prodotto.GetDescrizione());
Console.WriteLine("Prezzo senza IVA: \t" + $"{prodotto.GetPrezzo():0.##}" + "€");
Console.WriteLine("IVA: \t\t\t" + prodotto.GetIva() + "%");
prezzoConIva = prodotto.CalcoloPrezzoConIva(prezzo, iva);
Console.WriteLine("Prezzo con IVA: \t" + $"{prezzoConIva:0.##}" + "€");
Console.WriteLine("\n--------------------------------------------------");
*/






void LimitDecimalPlace(string number, int limitPlace)
{
    float result = 0;
    string sNumber = number;
    int decimalIndex = sNumber.IndexOf(".");
    Console.WriteLine(decimalIndex);
    if (decimalIndex != -1)
    {
        sNumber = sNumber.Remove(decimalIndex + limitPlace + 1);
    }

    result = float.Parse(sNumber);
    result = float.Parse(number);
    Console.WriteLine(result);

}
