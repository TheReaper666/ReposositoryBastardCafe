using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.BizzEntities
{
    public class SpilNavn
    {
        private string name;
        private int nameid;

        public SpilNavn()
        {

        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public int NameID
        {
            get
            {
                return nameid;
            }
            private set
            {
                nameid = value;
            }
        }

        public SpilNavn(string Name, int Nameid)
        {
            name = Name;
            nameid = Nameid;
        }
    }
}
