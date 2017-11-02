using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class SpilBeskrivelse
    {
        private int beskrivelseId;
        private string beskrivelse;

        public SpilBeskrivelse()
        {

        }

        public int BeskrivelseId { get => beskrivelseId; set => beskrivelseId = value; }
        public string Beskrivelse { get => beskrivelse; set => beskrivelse = value; }
    }
}
