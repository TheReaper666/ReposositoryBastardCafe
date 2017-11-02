using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class Bord
    {
        private int bordId;
        private int bordPladser;

        public Bord()
        {

        }

        public int BordId { get => bordId; set => bordId = value; }
        public int BordPladser { get => bordPladser; set => bordPladser = value; }
    }
}
