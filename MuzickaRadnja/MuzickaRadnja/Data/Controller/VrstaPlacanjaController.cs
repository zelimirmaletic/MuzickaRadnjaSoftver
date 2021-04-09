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
    class VrstaPlacanjaController
    {
        private static readonly string READ = "select * from VrstaPlacanja where Id=@Id;";
        private static readonly string READ_ALL = "select * from VrstaPlacanja";

        public static VrstaPlacanja Read(int id)
        {
            var result = new VrstaPlacanja();
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
                result = new VrstaPlacanja()
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Oznaka = reader.GetString(2),
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Racun.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public static List<VrstaPlacanja> ReadAll()
        {
            var lista = new List<VrstaPlacanja>();
            var result = new VrstaPlacanja();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ_ALL;
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    result = new VrstaPlacanja()
                    {
                        Id = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Oznaka = reader.GetString(2),
                    };
                    lista.Add(result);
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Racun.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return lista;
        }



    }
}
