using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Pizza2
{
    class DAL
    {
        public static List<Pizza> ListePizzas = new List<Pizza>();
        public static List<Boisson> ListeBoissons = new List<Boisson>();
        public static List<Commande> ListeCommandes = new List<Commande>();

        public static void ImportPizza()
        {
            if (File.Exists("DataPizzas.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Pizza>));
                using (XmlReader reader = XmlReader.Create("DataPizzas.xml"))
                {
                    ListePizzas = (List<Pizza>)ser.Deserialize(reader);
                }
            }                   
        }

        public static void ImportBoisson()
        {
            if (File.Exists("DataBoissons.xml"))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Boisson>));
                using (XmlReader reader = XmlReader.Create("DataBoissons.xml"))
                {
                    ListeBoissons = (List<Boisson>)ser.Deserialize(reader);
                }
            }
           
        }

        public static void ExportPizzasXML()
        {
                FileStream stream = new FileStream("DataPizzas.xml", FileMode.Create);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Pizza>));
                serializer.Serialize(stream, DAL.ListePizzas);
                stream.Close();
                
        }

        public static void ExportBoissonsXML()
        {
            FileStream stream = new FileStream(@"DataBoissons.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Boisson>));
            serializer.Serialize(stream, DAL.ListeBoissons);
            stream.Close();
        }

        public static void ExportCommande(List<Commande> listeCommande)
        {
            XmlAttributeOverrides over = new XmlAttributeOverrides();
            XmlAttributes myAttributes = new XmlAttributes();
            XmlElementAttribute attr = new XmlElementAttribute();
            attr.Type = typeof(PizzaCommandee); myAttributes.XmlElements.Add(attr);
            attr = new XmlElementAttribute();
            attr.Type = typeof(Boisson); myAttributes.XmlElements.Add(attr);
            over.Add(typeof(Commande), "Contenu", myAttributes);

            FileStream stream = new FileStream("DataCommandes.xml", FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Commande>), over);
            serializer.Serialize(stream, listeCommande);
            stream.Close();
        }

        public static void ImportCommande()
        {
            if (File.Exists("DataCommandes.xml"))
            {
                XmlAttributeOverrides over = new XmlAttributeOverrides();
                XmlAttributes myAttributes = new XmlAttributes();
                XmlElementAttribute attr = new XmlElementAttribute();
                attr.Type = typeof(PizzaCommandee); myAttributes.XmlElements.Add(attr);
                attr = new XmlElementAttribute();
                attr.Type = typeof(Boisson); myAttributes.XmlElements.Add(attr);
                over.Add(typeof(Commande), "Contenu", myAttributes);

                XmlSerializer ser = new XmlSerializer(typeof(List<Commande>), over);
                using (XmlReader reader = XmlReader.Create("DataCommandes.xml"))
                {
                    ListeCommandes = (List<Commande>)ser.Deserialize(reader);
                }
            }
        }
    }
}

