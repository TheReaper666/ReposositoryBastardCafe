using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class Kunde
    {
        private string fuldeNavn;
        private string adresse;
        private int postNr;
        private string byNavn;
        private int mobilNr;
        private string email;
        private string gamerNavn;

        public Kunde()
        {

        }

        public string FuldeNavn { get => fuldeNavn; set => fuldeNavn = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int PostNr { get => postNr; set => postNr = value; }
        public string ByNavn { get => byNavn; set => byNavn = value; }
        public int MobilNr { get => mobilNr; set => mobilNr = value; }
        public string Email { get => email; set => email = value; }
        public string GamerNavn { get => gamerNavn; set => gamerNavn = value; }
    }
}
