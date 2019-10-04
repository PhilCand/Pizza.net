using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class DAL
    {
        public static List<Pizza> ImportPizza()
        {
            List<Pizza> PizzasAImporter = new List<Pizza>();

            Pizza regina = new Pizza("Regina", 12.20f);
            Pizza napolitaine = new Pizza("Napolitaine", 13.20f);
            Pizza orientale = new Pizza("Orientale", 15.20f);

            regina.Ingredients.Add(new Ingredient("Jambon"));
            regina.Ingredients.Add(new Ingredient("tomate"));
            regina.Ingredients.Add(new Ingredient("Fromage"));

            napolitaine.Ingredients.Add(new Ingredient("Oeuf"));
            napolitaine.Ingredients.Add(new Ingredient("Parmesan"));
            napolitaine.Ingredients.Add(new Ingredient("Bacon"));

            orientale.Ingredients.Add(new Ingredient("Merguez"));
            orientale.Ingredients.Add(new Ingredient("Viande hachée"));
            orientale.Ingredients.Add(new Ingredient("Tomates"));

            PizzasAImporter.Add(regina);
            PizzasAImporter.Add(napolitaine);
            PizzasAImporter.Add(orientale);

            return PizzasAImporter;

        }

        public static List<Boisson> ImportBoisson()
        {
            List<Boisson> BoissonsAImporter = new List<Boisson>();

            Boisson coca = new Boisson("Coca", 1);
            Boisson sprite = new Boisson("Sprite", 1);
            Boisson fantaOrange = new Boisson("Fanta Orange", 1);
            Boisson fantaCitron = new Boisson("Fanta Citron", 1);
            Boisson fantaGrenadine = new Boisson("Fanta Grenadine", 1);
            Boisson Eau = new Boisson("Eau", 1);

            BoissonsAImporter.Add(coca);
            BoissonsAImporter.Add(sprite);
            BoissonsAImporter.Add(fantaOrange);
            BoissonsAImporter.Add(fantaCitron);
            BoissonsAImporter.Add(fantaGrenadine);
            BoissonsAImporter.Add(Eau);

            return BoissonsAImporter;

        }

    }
}
