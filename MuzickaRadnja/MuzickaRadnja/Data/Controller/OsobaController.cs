using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Exception;
using MuzickaRadnja.Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickaRadnja.Data.Controller
{
    class OsobaController
    {
        private static readonly string READ = "select * from Osoba where Id=@Id;";

        public static Osoba Read(int id)
        {
            var result = new Osoba();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                reader.Read();
                result = new Osoba()
                {
                    Id = reader.GetInt32(0),
                    IdMjesto = reader.GetInt32(1),
                    Ime = reader.GetString(2),
                    Prezime = reader.GetString(3),
                    JMB = reader.GetString(4),
                    BrojTelefona = reader.GetString(5),
                    Email = reader.GetString(6),
                    DatumRodjenja=reader.GetDateTime(7),
                    Pol=reader.GetString(8)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Osoba.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
