using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
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

        public SpilBeskrivelse(string beskriv, int beskrivId)
        {
            Beskrivelse = beskriv;
            BeskrivelseId = beskrivId;
        }

        #endregion

        #region Properties
        public string Beskrivelse { get => beskrivelse; private set => beskrivelse = value; }
        public int BeskrivelseId { get => beskrivelseId; private set => beskrivelseId = value; }
        #endregion
    }
}
