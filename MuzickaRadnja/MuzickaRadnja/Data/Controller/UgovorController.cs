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
    class UgovorController
    {
        //CRUD
        private static readonly string INSERT = "insert into Ugovor (Id,IdKlijent,IdZaposeni,DatumSklapanja,PlacanjeNaRate,PeriodIznajmljivanja,Otplaceno,Potpisan,Opis,BrojRata,ProduzavanjeUgovora) values (@Id,@IdKlijent,@IdZaposleni,@DatumSklapanja,@PlacanjeNaRate,@PeriodIznajmljivanja,@Otplaceno,@Potpisan,@Opis,@BrojRata,@ProduzavanjeUgovora);";
        private static readonly string READ = "select * from Ugovor where Id=@Id;";
        private static readonly string READ_ALL = "select * from Ugovor;";
        private static readonly string READ_ALL_FORMATED = "select * from VIEW_LISTA_UGOVORA";
        private static readonly string IZNOS_RATE = "call GET_IZNOS_RATE(@IdUgovor)";



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

                    row+=reader.GetInt32(6) == 0 ? "DA|" : "NE|";
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

        public static string nextId()
        {
            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            String id = "";

            try
            {
                connection = MySqlUtil.GetConnection();
                String query = "select max(Id) as ID from Ugovor;";
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

        public static double GetIznosRate(int idUgovor)
        {
            MySqlConnection connection = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            double rata = 0.0;

            try
            {
                connection = MySqlUtil.GetConnection();
                String query = IZNOS_RATE;
                cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@IdUgovor", idUgovor);
                reader = cmd.ExecuteReader();
                reader.Read();
                rata = reader.GetDouble(0);
            }
            catch (MySqlException e)
            {

            }
            finally
            {
                MySqlUtil.CloseQuietly(connection);
                MySqlUtil.CloseQuietly(reader);
            }

            return rata;
        }

        public static long Insert(Ugovor obj)
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
                cmd.Parameters.AddWithValue("@IdKlijent", obj.IdKlijent);
                cmd.Parameters.AddWithValue("@IdZaposleni", obj.IdZaposleni);
                cmd.Parameters.AddWithValue("@DatumSklapanja", obj.DatumSklapanja);
                cmd.Parameters.AddWithValue("@PlacanjeNaRate", obj.PlacanjeNaRate);
                cmd.Parameters.AddWithValue("@PeriodIznajmljivanja", obj.PeriodIznajmljivanja);
                cmd.Parameters.AddWithValue("@Otplaceno", obj.Otplaceno);
                cmd.Parameters.AddWithValue("@Potpisan", obj.Potpisan);
                cmd.Parameters.AddWithValue("@Opis", obj.Opis);
                cmd.Parameters.AddWithValue("@BrojRata", obj.BrojRata);
                cmd.Parameters.AddWithValue("@ProduzavanjeUgovora", obj.ProduzavanjeUgovora);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in UgovorController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;

        }

        public static List<Ugovor> ReadAll()
        {
            var result = new List<Ugovor>();
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
                    result.Add(new Ugovor()
                    {
                        Id = reader.GetInt32(0),
                        IdKlijent=reader.GetInt32(1),
                        IdZaposleni=reader.GetInt32(2),
                        DatumSklapanja = reader.GetDateTime(3),
                        PlacanjeNaRate = reader.GetBoolean(4),
                        PeriodIznajmljivanja=reader.GetInt32(5),
                        Otplaceno=reader.GetBoolean(6),
                        Potpisan=reader.GetBoolean(7),
                        Opis = reader.GetString(8),
                        BrojRata = reader.GetInt32(9),
                        ProduzavanjeUgovora=reader.GetInt32(10)     
                    });
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
