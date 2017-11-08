using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BastardCafe.BizzEntities;


namespace GeneralDB.IO
{

    public class BastardDB : DatabaseFunktions
    {
        public BastardDB()
        {
            ConnectionString = "Server=10.205.44.39,49172;Database=BastardCafeM2E202017;User Id=Aspit;Password=Server2012;";
        }

        public DataTable DTGetKundeData()
        {
            string SQLquery = $"SELECT Kunder.id, PostBy.ByNavn " +
            $"FROM Kunder INNER JOIN PostBy ON Kunder.PostNr = PostBy.PostNr";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetSpilData(bool ValgSpilStatus)
        {
            string SQLquery = $"SELECT Spil.Spilid, SpilNavn.SpilNavn, SpilGenre.Genre, SpilDeltagerAntal.SpilDeltagerAntal," +
               $" SpilTid.SpilTid, SpilBeskrivelse.SpilBeskrivelse FROM Spil INNER JOIN SpilBeskrivelse" +
               $" ON Spil.Spilid = SpilBeskrivelse.Spilid INNER JOIN SpilDeltagerAntal" +
               $" ON Spil.DeltagerId = SpilDeltagerAntal.Deltagerid INNER JOIN SpilGenre" +
               $" ON Spil.Genreid = SpilGenre.Genreid INNER JOIN SpilNavn" +
               $" ON Spil.NavnId = SpilNavn.Navnid INNER JOIN SpilTid" +
               $" ON Spil.NormalTidId = SpilTid.Tidid WHERE (Spil.SpilStatus = '{ValgSpilStatus}')";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetResevartionData(bool ValgtSpilStatus)
        {
            string SQLquery = $"SELECT Bord.Pladser, BordRes.id, Spil.id AS SpilID, SpilNavn.SpilNavn, SpilTid.SpilTid, " +
                $"SpilDeltagerAntal.SpilDeltagerAntal, SpilGenre.Genre, SpilBeskrivelse.SpilBeskrivelse, BordRes.resDate, " +
                $"Kunder.FuldeNavn, Kunder.Adresse, PostBy.ByNavn, Kunder.Mobil, Kunder.Email, Kunder.GamerNavn, " +
                $"Spil.SpilStatus FROM Bord RIGHT OUTER JOIN BordRes ON Bord.id = BordRes.resBord LEFT OUTER JOIN " +
                $"PostBy RIGHT OUTER JOIN Kunder ON PostBy.PostNr = Kunder.PostNr ON BordRes.resKunde = Kunder.id " +
                $"LEFT OUTER JOIN SpilBeskrivelse RIGHT OUTER JOIN Spil ON SpilBeskrivelse.Spilid = Spil.Spilid " +
                $"LEFT OUTER JOIN SpilGenre ON Spil.Genreid = SpilGenre.Genreid LEFT OUTER JOIN SpilDeltagerAntal ON " +
                $"Spil.DeltagerId = SpilDeltagerAntal.Deltagerid LEFT OUTER JOIN SpilTid ON Spil.NormalTidId = " +
                $"SpilTid.Tidid LEFT OUTER JOIN SpilNavn ON dbo.Spil.NavnId = SpilNavn.Navnid ON dbo.BordRes.resSpil = dbo.Spil.id " +
                $"WHERE (Spil.SpilStatus = '{ValgtSpilStatus}')";
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
