using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Exception;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickaRadnja.Data.Controller
{
    class UgovorController
    {
        //CRUD
        private static readonly string INSERT = "";
        private static readonly string READ = "select * from Ugovor where Id=@Id;";
        private static readonly string READ_ALL = "select * from Ugovor;";
        private static readonly string READ_ALL_FORMATED = "select * from VIEW_LISTA_UGOVORA";



        public static List<string> ReadAllFormated()
        {
            var result = new List<string>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ_ALL_FORMATED;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string row = "";
                    row += reader.GetInt32(0).ToString() + "|";
                    row += reader.GetString(1) + "|";
                    row += reader.GetDateTime(2).ToString("dd/MM/yyyy  HH:mm:ss") + "|";

                    row += reader.GetString(3) + "|";
                    row += reader.GetInt32(4).ToString() + "|";

                    row+=reader.GetBoolean(5) == true ? "DA|" : "NE|";
                    row += reader.GetInt32(6).ToString();

                    result.Add(row);
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Ugovor.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }


    }
}
