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
    class StatistikaController
    {
        private static readonly string STATISTIKA = "call GET_STATISTIKA(@PDV)";

        public static string GetStatistika()
        {
            string statistika = "";
            var result = new List<Instrument>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = STATISTIKA;
                cmd.Parameters.AddWithValue("@PDV", Main.PDV);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    statistika += reader.GetDouble(0).ToString()+"|";
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Statistika.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return statistika;
        }
    }
}
