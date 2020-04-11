using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace projectWPF.Model
{
    class GebruikerDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public void InsertGebruiker(Gebruiker gebruiker)
        {
            string sql = "Insert into Gebruiker(gebruikersnaam, wachtwoord, email) values (@gebruikersnaam, @wachtwoord, @email)";
            db.Query(sql, gebruiker);
        }

        public List<Gebruiker> GetGebruikers()
        {
            string sql = "Select * from Gebruiker";
            List<Gebruiker> gebruikers = (List<Gebruiker>)db.Query<Gebruiker>(sql);
            return gebruikers;
        }
    }
}
