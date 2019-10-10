using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlType]
    public class PizzaCommandee : Pizza
    {
        
        public string Taille { get; set; }        
        public bool Capres { get; set; }        
        public bool Olives { get; set; }   
        public bool Anchois { get; set; }
        public bool Oeuf { get; set; }

        public string Supplement { get; set; }

        public PizzaCommandee(string nom, float prix) : base(nom, prix)
        {
            Supplement = "";
        }

        public PizzaCommandee()
        {
        }

        public override string ToString()
        {
            return $"{Nom} {Taille} {Supplement} / {Prix} €";
        }


    }
}
