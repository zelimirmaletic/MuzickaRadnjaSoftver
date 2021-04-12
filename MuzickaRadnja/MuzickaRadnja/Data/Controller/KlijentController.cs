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
    class KlijentController
    {
        private static readonly string READ = "select * from Klijent;";

        public static List<Klijent> ReadAll()
        {
            var listaKlijenata = new List<Klijent>();
            var result = new Klijent();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = READ;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    var osoba = OsobaController.Read(id);

                    result = new Klijent()
                    {
                        Id = id,
                        IdMjesto = osoba.IdMjesto,
                        Ime = osoba.Ime,
                        Prezime = osoba.Prezime,
                        JMB =osoba.JMB,
                        BrojTelefona = osoba.BrojTelefona,
                        Email = osoba.Email,
                        DatumRodjenja = osoba.DatumRodjenja,
                        Pol = osoba.Pol
                    };
                    listaKlijenata.Add(result);
                }
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in Klijent.", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return listaKlijenata;
        }

    }
}
