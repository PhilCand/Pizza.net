using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza2
{
    class Client
    {
        private string _nomClient;
        private string _prenomClient;
        private string _adresse1Client;
        private string _adresse2Client;
        private string _CPClient;
        private string _villeClient;
        private string _telClient;

        public string NomClient { get => _nomClient; set => _nomClient = value; }
        public string PrenomClient { get => _prenomClient; set => _prenomClient = value; }
        public string Adresse1Client { get => _adresse1Client; set => _adresse1Client = value; }
        public string Adresse2Client { get => _adresse2Client; set => _adresse2Client = value; }
        public string CPClient { get => _CPClient; set => _CPClient = value; }
        public string VilleClient { get => _villeClient; set => _villeClient = value; }
        public string TelClient { get => _telClient; set => _telClient = value; }

        public Client()
        {
            NomClient = "";
            PrenomClient = "";
            Adresse1Client = "";
            Adresse2Client = "";
            CPClient = "";
            VilleClient = "";
            TelClient = "";
        }
    }
}
