using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BastardCafe.Appbizz
{
    public class BastardCafeBizz
    {
        public ObservableCollection<Kunde> DataKunder;
        public ObservableCollection<Resevartion> DataResevartion;
        public ObservableCollection<Spil> DataSpil;
        public BastardCafeBizz()
        {

        }

        public void FillReservationData()
        {
            DataSet DSReservation;
        }
        public void FillKundeData()
        {
            DataSet DSDataKunder;
        }
        public void FillSpilData()
        {
            DataSet DSSpilData;
        }
    }
}
