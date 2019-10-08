using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizza2
{
    class DAL
    {
        public static List<Pizza> PizzasAImporter = new List<Pizza>();
        public static List<Boisson> BoissonsAImporter = new List<Boisson>();

        public static void ImportPizza()
        {
            XDocument docPizza = XDocument.Load(@"..\..\PizzasData.xml");
            DAL.PizzasAImporter.Clear();
            foreach (XElement pizza in docPizza.Element("MENU").Elements("PIZZA"))
            {
                List<Ingredient> ingredientsXML = new List<Ingredient>();

                foreach (XElement ingredient in pizza.Element("INGREDIENTS").Elements("INGREDIENT"))
                {
                    Ingredient ingredientXML = new Ingredient(ingredient.Value);
                    ingredientsXML.Add(ingredientXML);
                }

                Pizza pizzaXML = new Pizza(pizza.Attribute("Nom").Value, float.Parse(pizza.Attribute("Prix").Value));
                pizzaXML.Ingredients = ingredientsXML;

                DAL.PizzasAImporter.Add(pizzaXML);
            }
        }
        
        public static void ImportBoisson()
        {
            XDocument docBoisson = XDocument.Load(@"..\..\PizzasData.xml");
            DAL.BoissonsAImporter.Clear();
            foreach (XElement boisson in docBoisson.Element("MENU").Elements("BOISSON"))
            {
                Boisson boissonXML = new Boisson(boisson.Attribute("Nom").Value, float.Parse(boisson.Attribute("Prix").Value));
                DAL.BoissonsAImporter.Add(boissonXML);
            }


        }

    }
}
