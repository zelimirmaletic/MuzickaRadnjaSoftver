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
    class RazduzivanjeInstrumentaController
    {
        private static readonly string INSERT = "insert into `razduzivanjeinstrumenta` (Id,IdZaposleni,IdKlijent,IdUgovor,DatumVracanja,OpisOstecenja,NaknadaZaOstecenja) values (@Id,@IdZaposleni,@IdKlijent,@IdUgovor,@DatumVracanja,@OpisOstecenja,@NaknadaZaOstecenja);";
        private static readonly string GET_INSTRUMENTI_RAZDUZIVANJE = "select * from `VIEW_LISTA_UGOVORA_RAZDUZIVANJE`;";

        public static long Insert(RazduzivanjeInstrumenta obj)
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
                cmd.Parameters.AddWithValue("@Id", obj.Id);
                cmd.Parameters.AddWithValue("@IdZaposleni", obj.IdZaposleni);
                cmd.Parameters.AddWithValue("@IdKlijent", obj.IdKlijent);
                cmd.Parameters.AddWithValue("@IdUgovor", obj.IdUgovor);
                cmd.Parameters.AddWithValue("@DatumVracanja", obj.DatumVracanja);
                cmd.Parameters.AddWithValue("@OpisOstecenja", obj.DatumVracanja);
                cmd.Parameters.AddWithValue("@NaknadaZaOstecenja", obj.DatumVracanja);

                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Razduzivanje", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;

        }


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
                cmd.CommandText = GET_INSTRUMENTI_RAZDUZIVANJE;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string row = "";
                    row += reader.GetInt32(0).ToString() + "|";
                    row += reader.GetInt32(1).ToString() + "|";

                    row += reader.GetString(2) + "|";
                    row += reader.GetString(3) + "|";

                    row += reader.GetString(4) + "|";
                    row += reader.GetDateTime(5).ToString() + "|"; ;
                    row += reader.GetInt32(6).ToString();

                    result.Add(row);
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Razduzivanje.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }



    }
}
