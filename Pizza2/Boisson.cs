using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlType]
    public class Boisson : Produit
    {
        public Boisson()
        {
        }

        public Boisson (string nom, float prix) : base(nom, prix)
        {
        }

        public override string ToString()
        {
            return $"{Nom} / {Prix} €";
        }
    }
}
