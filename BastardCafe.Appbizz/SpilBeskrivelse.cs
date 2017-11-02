using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class SpilBeskrivelse
    {
        private int spilBeskrivelseId;
        private string spilBeskrivelse;

        public SpilBeskrivelse()
        {

        }

        public int SpilBeskrivelseId { get => spilBeskrivelseId; set => spilBeskrivelseId = value; }
        public string SpilBeskrivelse { get => spilBeskrivelse; set => spilBeskrivelse = value; }
    }
}
