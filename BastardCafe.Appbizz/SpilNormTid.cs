using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    class SpilNormTid
    {
        private int spilID;
        private int spilTid;
        public SpilNormTid()
        {

        }

        public SpilNormTid(int spilID, int spilTid)
        {
            SpilID = spilID;
            SpilTid = spilTid;
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

        public int SpilTid
        {
            get
            {
                return spilTid;
            }
            private set
            {
                spilTid = value;
            }
        }
    }
}
