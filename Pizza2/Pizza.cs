using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlType]
    public class Pizza : Produit
    {       
        private List<Ingredient> ingredients = new List<Ingredient>();
        
        public Pizza(string nom, float prix) : base(nom, prix) 
        {
        }

        public Pizza()
        {
        }

        public List<Ingredient> Ingredients { get => ingredients; set => ingredients = value; }
        
        public override string ToString()
        {
            return Nom;
        }

        public string AfficherIngredients()
        {
            string liste = "";

            foreach (Ingredient ingredient in Ingredients)
            {
                liste += ingredient + Environment.NewLine;
            }

            return liste;
        }
    }
}
