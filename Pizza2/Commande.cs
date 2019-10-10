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
            return $"Numero : {Numero} - Nom : {Client.NomClient} - Prenom : {Client.PrenomClient} - Adresse 1 : {Client.Adresse1Client} - Adresse 2 : {Client.Adresse2Client} - CP : {Client.CPClient} - Ville : {Client.VilleClient} - Montant :{PrixCommande} ";
        }
    }
}
