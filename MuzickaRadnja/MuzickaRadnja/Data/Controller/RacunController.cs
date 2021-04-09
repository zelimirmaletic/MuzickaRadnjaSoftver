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
    class RacunController
    {
        //CRUD
        private static readonly string INSERT = "insert into Racun (IdOsoba,IdVrstaPlacanja,DatumVrijemeIzdavanja,UkupanIznos,Popust) values (@IdOsoba,@IdVrstaPlacanja,@DatumVrijemeIzdavanja,@UkupanIznos,@Popust);";
        private static readonly string READ = "select * from Racun where Id=@Id;";
        private static readonly string READ_ALL = "select * from Racun;";
        private static readonly string READ_ALL_FORMATED = "select * from VIEW_LISTA_RACUNA";

        public static long Insert(Racun obj)
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
                cmd.Parameters.AddWithValue("@IdOsoba", obj.IdOsoba);
                cmd.Parameters.AddWithValue("@IdVrstaPlacanja", obj.IdVrstaPlacanja);
                cmd.Parameters.AddWithValue("@DatumVrijemeIzdavanja", obj.DatumVrijemeIzdavanja);
                cmd.Parameters.AddWithValue("@UkupanIznos", obj.UkupanIznos);
                cmd.Parameters.AddWithValue("@Popust", obj.Popust);
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

        public static Racun Read(int id)
        {
            var result = new Racun();
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
                result = new Racun()
                {
                    Id = reader.GetInt32(0),
                    IdOsoba = reader.GetInt32(1),
                    IdVrstaPlacanja=reader.GetInt32(2),
                    DatumVrijemeIzdavanja = reader.GetDateTime(3),
                    UkupanIznos = reader.GetDouble(4),
                    Popust = reader.GetDouble(5)
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

        public static List<Racun> ReadAll()
        {
            var result = new List<Racun>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ_ALL;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Racun()
                    {
                        Id = reader.GetInt32(0),
                        IdOsoba = reader.GetInt32(1),
                        IdVrstaPlacanja = reader.GetInt32(2),
                        DatumVrijemeIzdavanja = reader.GetDateTime(3),
                        UkupanIznos = reader.GetDouble(4),
                        Popust = reader.GetDouble(5)
                    });
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
                    //R.Id, R.DatumVrijemeIzdavanja,VP.Naziv,R.Popust,O.Ime,O.Prezime,R.UkupanIznos
                    string row = "";
                    row += reader.GetInt32(0).ToString()+"|";
                    row += reader.GetDateTime(1).ToString("dd/MM/yyyy  HH:mm:ss") + "|";
                    row += reader.GetString(2) + "|";
                    row += reader.GetDouble(3).ToString("0.00") + "|";
                    row += reader.GetString(4) + " " + reader.GetString(5) + "|";
                    row += reader.GetDouble(6).ToString("0.00");
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

        public static string nextId()
        {
            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            String id = "";

            try
            {
                connection = MySqlUtil.GetConnection();
                String query = "select max(Id) as ID from Racun;";
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    id = (reader.IsDBNull(0) ? 1 : (reader.GetInt32("ID") + 1)).ToString();
            }
            catch (MySqlException e)
            {

            }
            finally
            {
                MySqlUtil.CloseQuietly(connection);
                MySqlUtil.CloseQuietly(reader);
            }

            return id;
        }


    }
}
