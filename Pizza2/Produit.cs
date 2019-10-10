using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlType]
    public class Produit
    {
        public string Nom { get; set; }

        public float Prix { get; set; }

        public Produit(string nom, float prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public Produit()
        {
        }
    }
}
