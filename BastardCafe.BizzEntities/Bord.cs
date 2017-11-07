using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
{
    public class Bord
    {
        private int bordId;
        private int bordPladser;

        public Bord()
        {

        }

        public Bord(int bordId)
        {
            BordSetup(bordId);
        }

        private void BordSetup(int bordId)
        {
            
        }

        public int BordId { get => bordId; private set => bordId = value; }
        public int BordPladser { get => bordPladser; private set => bordPladser = value; }
    }
}
