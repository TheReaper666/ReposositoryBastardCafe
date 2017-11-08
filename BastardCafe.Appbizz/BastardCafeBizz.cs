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
        public ObservableCollection<Spil> DataSpil = new ObservableCollection<Spil>();
        public BastardDB BastardDB = new BastardDB();
        private Spil spil;
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
            DataTable DTSpil = BastardDB.DTGetSpilData(true);
            spil = new Spil(DTSpil);
            DataSpil.Add(spil);
        }
    }
}
