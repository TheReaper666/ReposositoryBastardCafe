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
    public class BastardCafeBizz : Spil
    {
        private Kunde kunde;
        public ObservableCollection<Kunde> DataKunder;
        public ObservableCollection<Resevartion> DataResevartion;
        public ObservableCollection<Spil> DataSpil = new ObservableCollection<Spil>();
        public BastardDB BastardDB = new BastardDB();
        public Spil spil;
        public BastardCafeBizz()
        {

        }

        public void FillReservationData()
        {
            DataTable DTReservation;
        }
        public void FillKundeData()
        {
            DataTable DTDataKunder = BastardDB.DTGetKundeData();
            
        }
        public void FillSpilData()
        {
            DataTable DTSpil = BastardDB.DTGetSpilData(true);
            spil = new Spil(DTSpil);
            DataSpil.Add(spil);
        }

        public void UpdateReservationData(DateTime ResDato)
        {
            
        }
        public void UpdateKundeData()
        {
            kunde = new Kunde();
        }
        public void UpdateSpilData()
        {

        }

        public void CreateReservationData()
        {

        }
        public void CreateKundeData()
        {

        }
        public void CreateSpilData(string spilNavn, string spilGenre, string spilDeltagere, string spilBeskivelse, int SpilleTid, bool spilActiveret)
        {

        }
    }
}
