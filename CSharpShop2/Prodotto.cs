using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Prodotto
    {
        // PROPRIETA / ATTRIBUTI
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private float prezzoConIva;
        private int iva;
        // STATO
        // COSTRUTTORI
        // Costuttore che definisco IO e che usa il concetto di OVERLOAD
        public Prodotto(int Codice, string Nome, string Descrizione, float Prezzo, int Iva)
        {
            this.codice = Codice;
            this.nome = Nome;
            this.descrizione = Descrizione;
            this.prezzo = Prezzo;
            this.iva = Iva;
        }
        // GETTERS
        public int GetCodice()
        {
            return this.codice;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetDescrizione()
        {
            return this.descrizione;
        }

        public float GetPrezzo()
        {
            return this.prezzo;
        }

        public int GetIva()
        {
            return this.iva;
        }
        // SETTERS
        public void SetNome(string Nome)
        {
            this.nome = Nome;
        }

        public void SetDescrizione(string Descrizione)
        {
            this.descrizione = Descrizione;
        }

        public void SetPrezzo(int Prezzo)
        {
            this.prezzo = Prezzo;
        }

        public void SetIva(int Iva)
        {
            this.iva = Iva;
        }
        // METODI PUBBLICI
        public virtual void StampaProdotto()
        {
            this.prezzoConIva = this.CalcoloPrezzoConIva(this.prezzo, this.iva);
            string stringaProdotto = "\n\n------------------- Prodotto ---------------------\n" +
                "\nCodice: \t\t" + $"{this.codice:00000000}" +
                "\nNome: \t\t\t" + this.nome +
                "\nDescrizione: \t\t" + this.descrizione +
                "\nPrezzo senza IVA: \t" + $"{this.prezzo:0.##}" + "€" +
                "\nIVA: \t\t\t" + this.iva + "%" +
                "\nPrezzo con IVA: \t" + $"{prezzoConIva:0.##}" + "€";
            Console.WriteLine(stringaProdotto);
        }
        // METODI PRIVATI
        public float CalcoloPrezzoConIva(float prezzo, int iva)
        {
            float prezzoConIva = (prezzo * iva) / 100;
            prezzoConIva += prezzo;

            return prezzoConIva;
        }
    }
}
