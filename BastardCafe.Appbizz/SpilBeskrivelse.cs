using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class SpilBeskrivelse
    {
        #region Fields
        private string beskrivelse;
        private int beskrivelseId;
        #endregion

        #region Constructors
        public SpilBeskrivelse()
        {

        }

        public SpilBeskrivelse(string beskriv, int beskId)
        {
            beskrivelse = beskriv;
            beskrivelseId = beskId;
        }
        #endregion

        #region Properties
        public int BeskrivelseId { get => beskrivelseId; }
        public string Beskrivelse { get => beskrivelse; }
        #endregion
    }
}
