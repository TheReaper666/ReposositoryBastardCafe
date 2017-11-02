using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class SpilNavn
    {
        private string name;
        private int nameid;

        public SpilNavn()
        {

        }
        public string Name { get; private set; }
        public int NameID { get; private set; }

        public SpilNavn(string name, int nameid)
        {
            this.name = name;
            this.nameid = nameid;
        }
    }
}
