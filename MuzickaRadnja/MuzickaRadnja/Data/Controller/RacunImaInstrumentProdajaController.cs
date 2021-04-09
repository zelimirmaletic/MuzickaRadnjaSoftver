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
    class RacunImaInstrumentProdajaController
    {
        private static readonly string INSERT = "insert into Racun_ima_InstrumentProdaja (IdRacun,IdInstrument,Kolicina) values (@IdRacun,@IdInstrument,@Kolicina);";
        private static readonly string READ_ALL_FORMATED = "select * from VIEW_LISTA_STAVKI where `Sifra racuna`= @Id";


        public static long Insert(Racun_ima_InstrumentProdaja obj)
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
                cmd.Parameters.AddWithValue("@IdRacun", obj.IdRacun);
                cmd.Parameters.AddWithValue("@IdInstrument", obj.IdInstrument);
                cmd.Parameters.AddWithValue("@Kolicina", obj.Kolicina);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in RacunController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;

        }


        public static List<string> ReadAllFormated(int idFaktura)
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
                cmd.Parameters.AddWithValue("@Id", idFaktura);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string row = "";
                    row += reader.GetInt32(0).ToString() + "|";
                    row += reader.GetInt32(1).ToString() + "|";

                    row += reader.GetString(2) + "|";
                    row += reader.GetString(3) + "|";

                    row += reader.GetDouble(4).ToString("0.00") + "|";
                    row += reader.GetDouble(5).ToString("0.00") + "|";

                    row += reader.GetInt32(6).ToString() + "|";
                    row += reader.GetDouble(7).ToString("0.00");
       
                    result.Add(row);
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
            return result;
        }

    }
}
