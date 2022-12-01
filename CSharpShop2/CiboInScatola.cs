using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class CiboInScatola : Prodotto
    {
        private int pesoScatola;
        private bool aperto;
        public CiboInScatola(int Codice, string Nome, string Descrizione, float Prezzo, int Iva, int PesoScatola, bool Aperto = false) : base(Codice, Nome, Descrizione, Prezzo, Iva)
        {
            this.pesoScatola = PesoScatola;
            this.aperto = Aperto;
        }

        public int GetPesoScatola()
        {
            return this.pesoScatola;
        }

        public bool GetAperto()
        {
            return this.aperto;
        }

        public void SetPesoScatola(int PesoScatola)
        {
            this.pesoScatola = PesoScatola;
        }

        public void SetAperto(bool Aperto)
        {
            this.aperto = Aperto;
        }

        public override void StampaProdotto()
        {
            string stringaProdotto = "Peso della scatola: \t" + this.pesoScatola + "kg" + 
                "\nAperta: \t\t" + this.ConvertBoolean(this.aperto);
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
