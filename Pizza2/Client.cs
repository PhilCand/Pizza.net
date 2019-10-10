using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizza2
{
    [XmlType]
    public class Client
    {

        public string NomClient { get; set; }

        public string PrenomClient { get; set; }

        public string Adresse1Client { get; set; }

        public string Adresse2Client { get; set; }

        public string CPClient { get; set; }

        public string VilleClient { get; set; }

        public string TelClient { get; set; }

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
