using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BastardCafe.BizzEntities;


namespace GeneralDB.IO
{

    class BastardDB : DatabaseFunktions
    {
        public BastardDB()
        {
            ConnectionString = "Server=10.205.44.39,49172;Database=BastardCafeM2E202017;User Id=Aspit;Password=Server2012;";
        }

        public DataTable DTGetKundeData()
        {
            string SQLquery = "SELECT * FROM Kunder";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetSpilData()
        {
            string SQLquery = "SELECT Spil.Spilid, SpilNavn.SpilNavn, SpilGenre.Genre, SpilDeltagerAntal.SpilDeltagerAntal, SpilTid.SpilTid, SpilBeskrivelse.SpilBeskrivelse FROM Spil INNER JOIN SpilBeskrivelse ON Spil.Spilid = SpilBeskrivelse.Spilid INNER JOIN SpilDeltagerAntal ON Spil.DeltagerId = SpilDeltagerAntal.Deltagerid INNER JOIN SpilGenre ON Spil.Genreid = SpilGenre.Genreid INNER JOIN SpilNavn ON Spil.NavnId = SpilNavn.Navnid INNER JOIN SpilTid ON Spil.NormalTidId = SpilTid.Tidid WHERE (Spil.SpilStatus = 1)";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetResevartionData()
        {
            string SQLquery = "SELECT * FROM BordRes";
            return DbReturnDataTable(SQLquery);
        }


        public void DTUpdateKundeData(Kunde kunde) // VALIDERING FØR I KALDER DENNE METODE!
        {
            string SQLquery = $"UPDATE Kunder SET FuldeNavn = '{kunde.FuldeNavn}', Adresse = '{kunde.Adresse}', Mobil = '{kunde.MobilNr}', Email = '{kunde.Email}', GamerNavn = '{kunde.GamerNavn}'";
        }

        public void DTUpdateSpilData(Spil spil)// VALIDERING FØR I KALDER DENNE METODE!
        {
            string SQLquery = $"UPDATE Spil SET SpilNavn = '{spil.spilNavn}', SpilGenre = '{spil.spilGerne}', SpilDeltager = {spil.spilDeltagerAntal}, SpilBeskrivelse  = '{spil.spilBeskrivelse}', SpilTid  = '{spil.spilNormTid}'";
        }

        public void DTUpdateResevartionData(Resevartion res)// VALIDERING FØR I KALDER DENNE METODE!
        {
            string SQLquery = $"UPDATE BordRes SET DØDEN! ";
        }


        public void DTCreateKundeData(Kunde kunde)// VALIDERING FØR I KALDER DENNE METODE!
        {
            string SQLqueryKunde = $"INSERT INTO Kunder(FuldeNavn,Adresse,Mobil,Email,GamerNavn) VALUES ('{kunde.FuldeNavn}','{kunde.Adresse}',{kunde.MobilNr},'{kunde.Email}','{kunde.GamerNavn}')";
        }

        public void DTCreateSpilData()// VALIDERING FØR I KALDER DENNE METODE!
        {
            string SQLquery = "";
        }

        public void DTCreateResevartionData()// VALIDERING FØR I KALDER DENNE METODE!
        {
            string SQLquery = "";
        }
    }
}
