using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            string SQLquery = "SELECT * FROM Spil";
            return DbReturnDataTable(SQLquery);
        }
        public DataTable DTGetResevartionData()
        {
            string SQLquery = "SELECT * FROM BordRes";
            return DbReturnDataTable(SQLquery);
        }


        public void DTUpdateKundeData()
        {
            string SQLquery = "";
        }
        public void DTUpdateSpilData()
        {
            string SQLquery = "";
        }
        public void DTUpdateResevartionData()
        {
            string SQLquery = "";
        }


        public void DTCreateKundeData()
        {
            string SQLquery = "";
        }
        public void DTCreateSpilData()
        {
            string SQLquery = "";
        }
        public void DTCreateResevartionData()
        {
            string SQLquery = "";
        }
    }
}
