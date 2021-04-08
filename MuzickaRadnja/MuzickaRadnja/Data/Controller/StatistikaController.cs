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
    class StatistikaController
    {
        private static readonly string STATISTIKA = "select sum(UkupnaNabavnaKolicina) from instrumentiznajmljivanje union all select sum(UkupnaNabavnaKolicina) from instrumentprodaja union all select count(Id) from racun union all select count(Id) from ugovor union all select sum(I.MaloprodajnaCijena*T.Kolicina+(I.MaloprodajnaCijena*T.Kolicina*0.17)) from racun_ima_instrumentprodaja T inner join instrumentprodaja I on I.Id=T.IdInstrument union all select count(Id) from klijent;";

        public static string GetStatistika()
        {
            string statistika = "";
            var result = new List<Instrument>();
            MySqlConnection conn = null;
            MySqlCommand cmd;
            MySqlDataReader reader = null;

            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandText = STATISTIKA;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                    statistika += reader.GetDouble(0).ToString()+"|";
            }
            catch (System.Exception ex)
            {
                throw new DataAccessException("Exception in ArtikalUtil -> GetAllArtikal().", ex);
            }
            finally
            {
                MySqlUtil.CloseQuietly(reader, conn);
            }
            return statistika;
        }
    }
}
