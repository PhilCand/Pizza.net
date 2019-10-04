using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class Boisson : Produit
    {

        public Boisson (string nom, float prix) : base(nom, prix)
        {
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
