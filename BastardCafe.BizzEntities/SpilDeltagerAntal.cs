using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
{
    public class SpilDeltagerAntal
    {
        private string deltagerantal;
        private int deltagerantalID;
        public SpilDeltagerAntal()
        {

        }
        public int DeltagerAntal
        {
            get
            {
                return deltagerantal;
            }
            private set
            {
                deltagerantal = value;
            }
        }
        public int DeltagerAntalID
        {
            get
            {
                return deltagerantalID;
            }
            private set
            {
                deltagerantalID = value;
            }
        }
        public SpilDeltagerAntal(int Deltagerantal, int DeltagerantalID)
        {
            deltagerantal = Deltagerantal;
            deltagerantalID = DeltagerantalID;
        }
    }
}
