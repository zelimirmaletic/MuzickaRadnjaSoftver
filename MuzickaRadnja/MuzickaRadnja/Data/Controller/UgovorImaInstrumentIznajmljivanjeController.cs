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
    class UgovorImaInstrumentIznajmljivanjeController
    {
        //CRUD
        private static readonly string INSERT = "insert into `ugovor_ima_instrumentiznajmljivanje` (IdUgovor,IdInstrument,Kolicina) values (@IdUgovor,@IdInstrument,@Kolicina);";

        public static long Insert(UgovorImaInstrumentIznajmljivanje obj)
        {
            long id = 0;
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@IdUgovor", obj.IdUgovor);
                cmd.Parameters.AddWithValue("@IdInstrument", obj.IdInstrument);
                cmd.Parameters.AddWithValue("@Kolicina", obj.Kolicina);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Ugovor", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;

        }


    }
}
