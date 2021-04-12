using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickaRadnja.Data.Model
{
    class RazduzivanjeInstrumenta
    {
        public int Id { get; set; }
        public int IdZaposleni { get; set; }
        public int IdKlijent { get; set; }
        public int IdUgovor { get; set; }
        public DateTime DatumVracanja { get; set; }
        public double NaknadaZaOstecenja { get; set; }

        public RazduzivanjeInstrumenta(int id, int idZaposleni, int idKlijent, int idUgovor, DateTime datumVracanja, double naknadaZaOstecenja)
        {
            Id = id;
            IdZaposleni = idZaposleni;
            IdKlijent = idKlijent;
            IdUgovor = idUgovor;
            DatumVracanja = datumVracanja;
            NaknadaZaOstecenja = naknadaZaOstecenja;
        }

        public override bool Equals(object obj)
        {
            return obj is RazduzivanjeInstrumenta instrumenta &&
                   Id == instrumenta.Id &&
                   IdZaposleni == instrumenta.IdZaposleni &&
                   IdKlijent == instrumenta.IdKlijent &&
                   IdUgovor == instrumenta.IdUgovor &&
                   DatumVracanja == instrumenta.DatumVracanja &&
                   NaknadaZaOstecenja == instrumenta.NaknadaZaOstecenja;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IdZaposleni, IdKlijent, IdUgovor, DatumVracanja, NaknadaZaOstecenja);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
