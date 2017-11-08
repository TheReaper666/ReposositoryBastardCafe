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
        public string DeltagerAntal { get; private set; }
        public int DeltagerAntalID { get; private set; }
        public SpilDeltagerAntal(string deltagerantal, int deltagerantalID)
        {
            this.deltagerantal = deltagerantal;
            this.deltagerantalID = deltagerantalID;
        }
    }
}
