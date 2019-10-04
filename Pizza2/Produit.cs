using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class Produit
    {
        private string _nom;
        private float _prix;

        public string Nom { get => _nom; set => _nom = value; }
        public float Prix { get => _prix; set => _prix = value; }

        public Produit(string nom, float prix)
        {
            Nom = nom;
            Prix = prix;
        }
    }
}
