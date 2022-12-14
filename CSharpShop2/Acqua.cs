using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Acqua : Prodotto
    {
        private float litriAcqua;
        private int livelloPh;
        private string sorgente;
        private float acquaBevuta;
        private float acquaRiempita;

        public Acqua(int Codice, string Nome, string Descrizione, float Prezzo, int Iva, float litriAcqua, int livelloPh, string sorgente, float acquaBevuta, float acquaRiempita) : base(Codice, Nome, Descrizione, Prezzo, Iva)
        {
            this.litriAcqua = litriAcqua;
            this.livelloPh = livelloPh;
            this.sorgente = sorgente;
            this.acquaBevuta = acquaBevuta;
            this.acquaRiempita = acquaRiempita;
        }

        public float GetLitriAcqua()
        {
            return litriAcqua;
        }

        public int GetLivelloPh()
        {
            return livelloPh;
        }

        public string GetSorgente()
        {
            return sorgente;
        }

        public void SetLitriAcqua(float LitriAcqua)
        {
            if(LitriAcqua > 0 && LitriAcqua <= 1.5)
            {
                this.litriAcqua = LitriAcqua;
            }
            else
            {
                Console.WriteLine("Hai inserito un valore non valido!!");
            }
        }

        public override void StampaProdotto()
        {
            string stringaProdotto = "Litri d'acqua: \t" + this.litriAcqua + " l" +
                "\nLivello di PH: \t\t" + this.livelloPh +
                "\nSorgente: " + this.sorgente;
            base.StampaProdotto();
            Console.WriteLine(stringaProdotto);
        }

        public float AcquaBevuta(float )

    }
}
