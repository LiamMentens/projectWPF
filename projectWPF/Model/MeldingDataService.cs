using Dapper;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectWPF.Model
{
    public class MeldingDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public List<Melding> GetMeldingen()
        {
            string sql = "Select * from Melding";
            List<Melding> meldingen = (List<Melding>)db.Query<Melding>(sql);
            return meldingen;
        }

        public void InsertMelding(Melding melding)
        {
            string sql = "Insert into Melding(beschrijving,datum,gebruikerID) values (@beschrijving, @datum, @gebruikerID)";
            db.Query(sql, melding);
        }
    }
}
