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
    class RadnjaController
    {
        private static readonly string READ_FORMATED = "SELECT R.Id,M.Naziv,R.Naziv,R.Adresa,R.ZiroRacun,R.Banka,R.Email,R.Telefon FROM radnja R inner join mjesto M on M.Id=R.IdMjesto where R.Id=@Id;";

        public static string Read(int id)
        {
            var result = "";
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ_FORMATED;
                cmd.Parameters.AddWithValue("@Id", id);
                reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    result += reader.GetInt32(0).ToString() + "|";
                    result += reader.GetString(1) + "|";
                    result += reader.GetString(2) + "|";
                    result += reader.GetString(3) + "|";
                    result += reader.GetString(4) + "|";
                    result += reader.GetString(5) + "|";
                    result += reader.GetString(6) + "|";
                    result += reader.GetString(7);
                }
               
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Radnja.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

    }
}
