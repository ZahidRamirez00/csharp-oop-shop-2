using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class SacchettoDiFruttaAPezzi : Prodotto
    {
        private int numeroPezzi;
        private bool secca;
        public SacchettoDiFruttaAPezzi(int Codice, string Nome, string Descrizione, float Prezzo, int Iva, int numeroPezzi, bool secca) : base(Codice, Nome, Descrizione, Prezzo, Iva)
        {
            this.numeroPezzi = numeroPezzi;
            this.secca = secca;
        }

        public int GetNumeroPezzi()
        {
            return this.numeroPezzi;
        }

        public string GetSecca()
        {
            return this.ConvertBoolean(this.secca);
        }

        public void SetNumeroPezzi(int NumeroPezzi)
        {
            if(NumeroPezzi > 0 && NumeroPezzi <= 5)
            {
                this.numeroPezzi = NumeroPezzi;
            }
            else
            {
                Console.WriteLine("Hai inserito un valore non valido!!");
            }
            
        }

        public void SetSecca(bool Secca)
        {
            this.secca = Secca;
        }

        public override void StampaProdotto()
        {
            string stringaProdotto = "Numero pezzi di frutta: \t" + this.numeroPezzi +
                "\nÈ frutta secca: \t\t" + this.ConvertBoolean(this.secca);
            base.StampaProdotto();
            Console.WriteLine(stringaProdotto);
        }

        private string ConvertBoolean(bool b)
        {
            if (b)
            {
                return "Sì";
            }
            else
            {
                return "No";
            }
        }

    }
}
