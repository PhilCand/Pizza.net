using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class Pizza : Produit
    {

       
        private List<Ingredient> ingredients = new List<Ingredient>();


        public Pizza(string nom, float prix) : base(nom, prix) 
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
