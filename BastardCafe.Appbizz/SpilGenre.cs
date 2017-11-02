using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    class SpilGenre
    {
        private int genreID;
        private string genreName;
        public SpilGenre()
        {
           
        }

        public SpilGenre(int genreID, string genreName)
        {
            GenreID = genreID;
            GenreName = genreName;
        }

        public int GenreID
        {
            get
            {
                return genreID;
            }
            private set
            {
                genreID = value;
            }
        }

        public string GenreName
        {
            get
            {
                return genreName;
            }
            private set
            {
                genreName = value;
            }
        }
    }
}
