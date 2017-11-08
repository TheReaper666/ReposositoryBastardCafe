using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
{
    public class SpilDeltagerAntal
    {
        private int deltagerantal;
        private int deltagerantalID;
        public SpilDeltagerAntal()
        {

        }
        public int DeltagerAntal { get; private set; }
        public int DeltagerAntalID { get; private set; }
        public SpilDeltagerAntal(int Deltagerantal, int DeltagerantalID)
        {
            deltagerantal = Deltagerantal;
            deltagerantalID = DeltagerantalID;
        }
    }
}
