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

        public Spil(DataTable data)
        {
            SetupSpilClass(data);
        }

        private void SetupSpilClass(DataTable ds)
        {
            DataTableReader reader = new DataTableReader(ds);
            while (reader.Read())
            {
                int spilId = Convert.ToInt32(reader["Spilid"]);
                string navn = reader["SpilNavn"].ToString();
                string genre = reader["Genre"].ToString();
                string deltagerAntal = reader["SpilDeltagerAntal"].ToString();
                int spilTid = Convert.ToInt32(reader["SpilTid"]);
                string beskrivelse = reader["SpilBeskrivelse"].ToString();
                SpilID = spilId;
                spilNavn = new SpilNavn(navn, spilId);
                spilGerne = new SpilGenre(spilId, genre);
                spilBeskrivelse = new SpilBeskrivelse(beskrivelse, spilId);
                spilDeltagerAntal = new SpilDeltagerAntal(deltagerAntal,spilId);
                spilNormTid = new SpilNormTid(spilId, spilTid);
            }
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
