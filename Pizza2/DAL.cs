using System.Collections.Generic;
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
                string prix = pizza.Attribute("Prix").Value.Replace('.', ',');
                Pizza pizzaXML = new Pizza(pizza.Attribute("Nom").Value, float.Parse(prix));
                pizzaXML.Ingredients = ingredientsXML;

                DAL.PizzasAImporter.Add(pizzaXML);
            }
        }

        public static void ImportBoisson()
        {
            XDocument docBoisson = XDocument.Load(@"..\..\BoissonsData.xml");
            DAL.BoissonsAImporter.Clear();
            foreach (XElement boisson in docBoisson.Element("MENU").Elements("BOISSON"))
            {
                string prix = boisson.Attribute("Prix").Value.Replace('.', ',');
                Boisson boissonXML = new Boisson(boisson.Attribute("Nom").Value, float.Parse(prix));
                DAL.BoissonsAImporter.Add(boissonXML);
            }
        }

        public static void ExportPizzasXML()
        {
            XDocument PizzasData = new XDocument(new XElement("MENU"));

            foreach (Pizza pizza in DAL.PizzasAImporter)
            {
                XElement pizzaXML = (new XElement("PIZZA",
                                     new XAttribute("Nom", pizza.Nom),
                                     new XAttribute("Prix", pizza.Prix),
                                     new XElement("INGREDIENTS")));

                PizzasData.Root.Add(pizzaXML);

                foreach (Ingredient ingredient in pizza.Ingredients)
                {
                    pizzaXML.Element("INGREDIENTS").Add(new XElement("INGREDIENT", ingredient));
                }
            }
            PizzasData.Save(@"..\..\PizzasData.xml");
        }
        public static void ExportBoissonsXML()
        {
            XDocument BoissonsData = new XDocument(new XElement("MENU"));

            foreach (Boisson boisson in DAL.BoissonsAImporter)
            {
                XElement boissonXML = (new XElement("BOISSON",
                                        new XAttribute("Nom", boisson.Nom),
                                        new XAttribute("Prix", boisson.Prix)));

                BoissonsData.Root.Add(boissonXML);
            }
            BoissonsData.Save(@"..\..\BoissonsData.xml");
        }
        
    }
}

