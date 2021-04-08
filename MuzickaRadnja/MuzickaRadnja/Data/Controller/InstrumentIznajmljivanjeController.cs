using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Exception;
using MuzickaRadnja.Data.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MuzickaRadnja.Data.Controller
{
    class InstrumentIznajmljivanjeController
    {
        //CRUD
        private static readonly string INSERT = "insert into InstrumentIznajmljivanje (Id,CijenaIznajmljivanja, DostupnaKolicina, UkupnaNabavnaKolicina) values(@Id,@CijenaIznajmljivanja,@DostupnaKolicina,@UkupnaNabavnaKolicina)";
        private static readonly string DELETE = "delete from InstrumentIznajmljivanje where Id=@Id; ";
        private static readonly string UPDATE = "update InstrumentIznajmljivanje set CijenaIznajmljivanja=@CijenaIznajmljivanja, DostupnaKolicina=@DostupnaKolicina, UkupnaNabavnaKolicina=@UkupnaNabavnaKolicina where Id=@Id;";
        private static readonly string READ = "select * from InstrumentIznajmljivanje where Id=@Id;";
        private static readonly string READ_ALL = "select * from InstrumentIznajmljivanje;";

        public static void Insert(InstrumentIznajmljivanje obj)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                //Insert superclass data
                long id = InstrumentController.Insert(new Instrument(0, obj.Naziv, obj.Vrsta, obj.GodinaProizvodnje, obj.NabavnaCijena));
                ///Insert subclass data
                cmd = conn.CreateCommand();
                cmd.CommandText = INSERT;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@CijenaIznajmljivanja", obj.CijenaIznajmljivanja);
                cmd.Parameters.AddWithValue("@DostupnaKolicina", obj.DostupnaKolicina);
                cmd.Parameters.AddWithValue("@UkupnaNabavnaKolicina", obj.UkupnaNabavnaKolicina);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in InstrumentIznajmljivanjeController", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
        }

        public static void Delete(int id)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                //Delete subclass data
                cmd = conn.CreateCommand();
                cmd.CommandText = DELETE;
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                //Delete superclass data
                InstrumentController.Delete(id);
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

        public static void Update(InstrumentIznajmljivanje obj)
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                //Update subclass data
                cmd = conn.CreateCommand();
                cmd.CommandText = UPDATE;
                cmd.Parameters.AddWithValue("@Id", obj.Id);
                cmd.Parameters.AddWithValue("@CijenaIznajmljivanja", obj.CijenaIznajmljivanja);
                cmd.Parameters.AddWithValue("@DostupnaKolicina", obj.DostupnaKolicina);
                cmd.Parameters.AddWithValue("@UkupnaNabavnaKolicina", obj.UkupnaNabavnaKolicina);
                cmd.ExecuteNonQuery();
                //Update superclass data
                InstrumentController.Update(new Instrument(obj.Id, obj.Naziv, obj.Vrsta, obj.GodinaProizvodnje, obj.NabavnaCijena));
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

        public static InstrumentIznajmljivanje Read(int id)
        {
            var result = new InstrumentIznajmljivanje();
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
                //Read superclass data
                result = (InstrumentIznajmljivanje)InstrumentController.Read(id);
                //Read subclass data
                result.CijenaIznajmljivanja = reader.GetDouble(1);
                result.DostupnaKolicina = reader.GetInt32(2);
                result.UkupnaNabavnaKolicina = reader.GetInt32(3);
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in InstrumentIznajmljivanjeController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return result;
        }

        public static List<InstrumentIznajmljivanje> ReadAll()
        {
            var list = new List<InstrumentIznajmljivanje>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ_ALL;
                reader = cmd.ExecuteReader();
                //Read superclass data
                var superList = InstrumentController.ReadAll();
                int i = 0;
                while (reader.Read())
                {
                    var result = new InstrumentIznajmljivanje();
                    var parentClass = superList[i++];
                    result.Id = parentClass.Id;
                    result.Naziv = parentClass.Naziv;
                    result.Vrsta = parentClass.Vrsta;
                    result.GodinaProizvodnje = parentClass.GodinaProizvodnje;
                    result.NabavnaCijena = parentClass.NabavnaCijena;
                    //Read subclass data
                    result.CijenaIznajmljivanja = reader.GetDouble(1);
                    result.DostupnaKolicina = reader.GetInt32(2);
                    result.UkupnaNabavnaKolicina = reader.GetInt32(3);
                    list.Add(result);
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in InstrumentIznajmljivanjeController.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return list;
        }
    }
}
