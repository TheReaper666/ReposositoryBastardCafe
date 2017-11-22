using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeneralDB.IO
{

    public class BastardDB : DatabaseFunktions
    {
        public BastardDB()
        {
            ConnectionString = "Server=10.205.44.39,49172;Database=LoginSystemDB;User Id=Aspit;Password=Server2012;";
        }

        public DataTable DTGetUserData()
        {
            string SQLquery = $"SELECT Kunder.id, PostBy.ByNavn " +
            $"FROM Kunder INNER JOIN PostBy ON Kunder.PostNr = PostBy.PostNr";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetLoginData()
        {
            string SQLquery = $"SELECT Spil.Spilid, SpilNavn.SpilNavn, SpilGenre.Genre, SpilDeltagerAntal.SpilDeltagerAntal,";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetResevartionData(bool ValgtSpilStatus)
        {
            string SQLquery = $"SELECT Bord.Pladser, BordRes.id, Spil.id AS SpilID, SpilNavn.SpilNavn, SpilTid.SpilTid,";
            return DbReturnDataTable(SQLquery);
        }

        public void DTUpdateKundeData() // VALIDERING FØR I KALDER DENNE METODE! NÆ
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
