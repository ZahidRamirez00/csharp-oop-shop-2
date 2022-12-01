using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class SacchettoDiFruttaAPezzi : Prodotto
    {

        public SacchettoDiFruttaAPezzi(int Codice, string Nome, string Descrizione, float Prezzo, int Iva) : base(Codice, Nome, Descrizione, Prezzo, Iva)
        {
        }
    }
}
