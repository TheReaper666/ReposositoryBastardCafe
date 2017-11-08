using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BastardCafe.BizzEntities;
using GeneralDB.IO;

namespace BastardCafe.Appbizz
{
    public class BastardCafeBizz
    {
        public ObservableCollection<Kunde> DataKunder;
        public ObservableCollection<Resevartion> DataResevartion;
        public ObservableCollection<Spil> DataSpil;
        //public BastardDB BastardDB = new BastardDB();
        public BastardCafeBizz()
        {

        }

        public void FillReservationData()
        {
            DataTable DSReservation;
        }
        public void FillKundeData()
        {
            DataTable DSDataKunder;
        }
        public void FillSpilData()
        {
            DataTable DTSpil;
        }
    }
}
