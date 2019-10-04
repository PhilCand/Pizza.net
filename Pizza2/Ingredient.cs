using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class Ingredient
    {
        private string _nom;
                
        public string Nom { get => _nom; set => _nom = value; }

        public Ingredient(string nom)
        {
            Nom = nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
