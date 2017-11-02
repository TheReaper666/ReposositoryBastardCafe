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

        public Kunde(int kundeId)
        {
            KundeSetup(kundeId);
        }

        private void KundeSetup(int kundeId)
        {
            
        }

        public string FuldeNavn { get => fuldeNavn; private set => fuldeNavn = value; }
        public string Adresse { get => adresse; private set => adresse = value; }
        public int PostNr { get => postNr; private set => postNr = value; }
        public string ByNavn { get => byNavn; private set => byNavn = value; }
        public int MobilNr { get => mobilNr; private set => mobilNr = value; }
        public string Email { get => email;private set => email = value; }
        public string GamerNavn { get => gamerNavn; private set => gamerNavn = value; }
    }
}
