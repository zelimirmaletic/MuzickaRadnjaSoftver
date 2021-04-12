using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickaRadnja.Data.Model
{
    class UgovorUplata
    {
        public int Id {get;set;}
        public int IdUgovor { get; set; }
        public int IdVrstaPlacanja { get; set; }
        public int IdZaposleni { get; set; }
        public string Svrha { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public string Komentar { get; set; }

        public UgovorUplata(int id, int idUgovor, int idVrstaPlacanja, int idZaposleni, string svrha, DateTime datum, string komentar)
        {
            Id = id;
            IdUgovor = idUgovor;
            IdVrstaPlacanja = idVrstaPlacanja;
            IdZaposleni = idZaposleni;
            Svrha = svrha;
            DatumVrijeme = datum;
            Komentar = komentar;
        }

        public override bool Equals(object obj)
        {
            return obj is UgovorUplata uplata &&
                   Id == uplata.Id &&
                   IdUgovor == uplata.IdUgovor &&
                   IdVrstaPlacanja == uplata.IdVrstaPlacanja &&
                   IdZaposleni == uplata.IdZaposleni &&
                   Svrha == uplata.Svrha &&
                   DatumVrijeme == uplata.DatumVrijeme &&
                   Komentar == uplata.Komentar;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IdUgovor, IdVrstaPlacanja, IdZaposleni, Svrha, DatumVrijeme, Komentar);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
