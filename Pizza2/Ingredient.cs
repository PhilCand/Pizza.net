using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlType]
    public class Ingredient
    {
        private string _nom;
                
        public string Nom { get => _nom; set => _nom = value; }

        public Ingredient(string nom)
        {
            Nom = nom;
        }

        public Ingredient()
        {
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
