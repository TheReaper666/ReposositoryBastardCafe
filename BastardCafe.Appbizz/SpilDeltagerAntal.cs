using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
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
        public SpilDeltagerAntal(int deltagerantal, int deltagerantalID)
        {
            this.deltagerantal = deltagerantal;
            this.deltagerantalID = deltagerantalID;
        }
    }
}
