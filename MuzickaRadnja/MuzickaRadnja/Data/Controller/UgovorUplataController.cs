using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Exception;
using MuzickaRadnja.Data.Model;
using MySql.Data.MySqlClient;

namespace MuzickaRadnja.Data.Controller
{
    class UgovorUplataController
    {
        //CRUD
        private static readonly string INSERT = "insert into ugovor_uplata (IdUgovor,IdVrstaPlacanja,IdZaposleni,Svrha,DatumVrijeme,Komentar) values (@IdUgovor,@IdVrstaPlacanja,@IdZaposleni,@Svrha,@DatumVrijeme,@Komentar);";
        public static long Insert(UgovorUplata obj)
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
                cmd.Parameters.AddWithValue("@IdVrstaPlacanja", obj.IdVrstaPlacanja);
                cmd.Parameters.AddWithValue("@IdZaposleni", obj.IdZaposleni);
                cmd.Parameters.AddWithValue("@Svrha", obj.Svrha);
                cmd.Parameters.AddWithValue("@DatumVrijeme", obj.DatumVrijeme);
                cmd.Parameters.AddWithValue("@Komentar", obj.Komentar);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in UgovorUplataController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;

        }

    }
}
