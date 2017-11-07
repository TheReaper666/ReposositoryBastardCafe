using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
{
    public class Spil
    {
        public SpilNavn spilNavn;
        public SpilGenre spilGerne;
        public SpilBeskrivelse spilBeskrivelse;
        public SpilDeltagerAntal spilDeltagerAntal;
        public SpilNormTid spilNormTid;
        private int spilID;

        public Spil()
        {

        }

        public Spil(DataSet data)
        {
            SetupSpilClass(data);
        }

        private void SetupSpilClass(DataSet ds)
        {
            
        }


        public int SpilID
        {
            get
            {
                return spilID;
            }
            private set
            {
                spilID = value;
            }
        }

    }
}
