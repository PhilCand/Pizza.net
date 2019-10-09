using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class Commande
    {
        private Client _client;
        private List<Produit> _contenu;
        private int _numero;
        private float _prixCommande;
        private static int compteur = 1;


        public List<Produit> Contenu { get => _contenu; set => _contenu = value; }
        internal Client Client { get => _client; set => _client = value; }
        public int Numero { get => _numero; set => _numero = value; }
        public float PrixCommande { get => _prixCommande; set => _prixCommande = value; }

        public Commande(Client client, List<Produit> contenu)
        {
            Client = client;
            Contenu = new List<Produit>(contenu);
            Numero = compteur;
            PrixCommande = 0;
            compteur++;
        }

        public override string ToString()
        {
            return $"Numero : {Numero} - Nom : {Client.NomClient} - Prenom : {Client.PrenomClient} - Adresse 1 : {Client.Adresse1Client} - Adresse 2 : {Client.Adresse2Client} - CP : {Client.CPClient} - Ville : {Client.VilleClient} - Montant :{PrixCommande} ";
        }
    }
}
