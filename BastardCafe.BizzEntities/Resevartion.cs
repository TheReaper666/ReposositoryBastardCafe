using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
{
    public class Resevartion
    {
        private int resevartionsID;
        public Bord bord;
        public Kunde kunde;
        public Spil spil;
        private DateTime resavationsDato;
        public Resevartion()
        {
            
        }

        public Resevartion(int bordID, int kundeID, int spilID,DateTime resavationsDato)
        {
            SpilSetup(spilID);
            KundeSetup(kundeID);
            BordSetup(bordID);
            ResavationsDato = resavationsDato;
        }

        public Resevartion(int resevationsID)
        {
            ResevartionsID = resevationsID;
        }
         
        private void SpilSetup(int spilID)
        {
           
        }

        private void KundeSetup(int kundeID)
        {

        }

        private void BordSetup(int bordID)
        {

        }


        public int ResevartionsID
        {
            get
            {
                return resevartionsID;
            }
            private set
            {
                resevartionsID = value;
            }
        }

        public DateTime ResavationsDato
        {
            get
            {
                return resavationsDato;
            }
            private set
            {
                resavationsDato = value;
            }
        }
    }
}
