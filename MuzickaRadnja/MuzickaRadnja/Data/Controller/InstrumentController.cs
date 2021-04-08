using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Exception;
using MuzickaRadnja.Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace MuzickaRadnja.Data.Controller
{
    class InstrumentController
    {
        //CRUD
        private static readonly string INSERT = "insert into Instrument (Naziv,Vrsta,GodinaProizvodnje,NabavnaCijena) values (@Naziv,@Vrsta,@GodinaProizvodnje,@NabavnaCijena);";
        private static readonly string DELETE = "delete form Instrument where Id=@Id;";
        private static readonly string UPDATE = "update Instrument set Naziv=@Naziv, Vrsta=@Vrsta, GodinaProizvodnje=@GodinaProizvodnje, NabavnaCijena=@NabavnaCijena where Id=@Id;";
        private static readonly string READ = "select * from Instrument where Id=@Id;";
        private static readonly string READ_ALL = "select * from `Instrument`;";

        public static long Insert(Instrument obj)
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
                cmd.Parameters.AddWithValue("@Naziv", obj.Naziv);
                cmd.Parameters.AddWithValue("@Vrsta", obj.Vrsta);
                cmd.Parameters.AddWithValue("@GodinaProizvodnje", obj.GodinaProizvodnje);
                cmd.Parameters.AddWithValue("@NabavnaCijena", obj.NabavnaCijena);
                cmd.ExecuteNonQuery();
                id = cmd.LastInsertedId;
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in InstrumentController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return id;
        }
        public static void Delete(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in InstrumentController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }
        public static void Update(Instrument obj)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", obj.Id);
                cmd.Parameters.AddWithValue("@Naziv", obj.Naziv);
                cmd.Parameters.AddWithValue("@Vrsta", obj.Vrsta);
                cmd.Parameters.AddWithValue("@GodinaProizvodnje", obj.GodinaProizvodnje);
                cmd.Parameters.AddWithValue("@NabavnaCijena", obj.NabavnaCijena);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in InstrumentController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }

        }
        public static Instrument Read(int id)
        {
            var result = new Instrument();
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
                result = new Instrument()
                {
                    Id = reader.GetInt32(0),
                    Naziv = reader.GetString(1),
                    Vrsta = reader.GetString(2),
                    GodinaProizvodnje = reader.GetDateTime(3),
                    NabavnaCijena = reader.GetDouble(4)
                };
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in ArtikalUtil -> GetArtikalById().", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
        public static List<Instrument> ReadAll()
        {
            var result = new List<Instrument>();
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
                    result.Add(new Instrument()
                    {
                        Id = reader.GetInt32(0),
                        Naziv = reader.GetString(1),
                        Vrsta = reader.GetString(2),
                        GodinaProizvodnje = reader.GetDateTime(3),
                        NabavnaCijena = reader.GetDouble(4),
                    });
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in ArtikalUtil -> GetAllArtikal().", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }
    }
}
