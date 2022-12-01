using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpShop2
{
    public class Elettrodomestico : Prodotto
    {
        private int pesoElettrodomestico;
        private string classeEnergetica;
        public Elettrodomestico(int Codice, string Nome, string Descrizione, float Prezzo, int Iva, int pesoElettrodomestico, string classeEnergetica) : base(Codice, Nome, Descrizione, Prezzo, Iva)
        {
            this.pesoElettrodomestico = pesoElettrodomestico;
            this.classeEnergetica = classeEnergetica;
        }

        public int GetPesoElettrodomestico()
        {
            return pesoElettrodomestico;
        }

        public string GetClasseEnergetica()
        {
            return classeEnergetica;
        }

        public void SetPesoElettrodomestico(int PesoElettrodomestico)
        {
            this.pesoElettrodomestico = PesoElettrodomestico;
        }

        public void SetClasseEnergetica(string ClasseEnergetica)
        {
            this.classeEnergetica = ClasseEnergetica;
        }

        public override void StampaProdotto()
        {
            string stringaProdotto = "Peso dell'elettrodomestico: \t" + this.pesoElettrodomestico + "kg" +
                "\nClasse Energetica: \t\t" + this.classeEnergetica;
            base.StampaProdotto();
            Console.WriteLine(stringaProdotto);
        }

    }
}
