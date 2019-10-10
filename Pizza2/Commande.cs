using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlRoot]
    public class Commande
    {
        private List<Produit> _contenu;

        public List<Produit> Contenu { get => _contenu; set => _contenu = value; }
        public Client Client { get; set; }
        public int Numero { get; set; }
        //public string commandeDetail = "{0, 5}{1, -15}{2, -15}{3, -20}{4, -20}{5, 10}{6, -10}{7, 10}";
        
        public float PrixCommande { get; set; }

        public Commande(Client client, List<Produit> contenu)
        {
            Client = client;
            Contenu = new List<Produit>(contenu);
            PrixCommande = 0;          
        }

        public Commande()
        {
        }

        public override string ToString()
        {
            return $"Numero : {Numero} - Nom : {Client.NomClient} - Prenom : {Client.PrenomClient} - Adresse 1 : {Client.Adresse1Client} - Adresse 2 : {Client.Adresse2Client} - CP : {Client.CPClient} - Ville : {Client.VilleClient} - Montant :{PrixCommande} €";
         //String.Format(commandeDetail,Numero,Client.NomClient,Client.PrenomClient,Client.Adresse1Client,Client.Adresse2Client,Client.CPClient,Client.VilleClient,PrixCommande);
        }
    }
}
