using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class PizzaCommandee : Pizza
    {
        private string _taille;
        private bool _capres = false;
        private bool _olives = false;
        private bool _anchois = false;
        private bool _oeuf = false;
        private string _supplement;

        public string Taille { get => _taille; set => _taille = value; }
        public bool Capres { get => _capres; set => _capres = value; }
        public bool Olives { get => _olives; set => _olives = value; }
        public bool Anchois { get => _anchois; set => _anchois = value; }
        public bool Oeuf { get => _oeuf; set => _oeuf = value; }
        public string Supplement { get => _supplement; set => _supplement = value; }

        public PizzaCommandee(string nom, float prix) : base(nom, prix)
        {
            Supplement = "";
        }


        public override string ToString()
        {
            return $"{Nom} - {Taille} {Supplement} - {Prix}";
        }


    }
}
