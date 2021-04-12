using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickaRadnja.Data.Model
{
    class UgovorImaInstrumentIznajmljivanje
    {
        public int Id { get; set; }
        public int IdUgovor { get; set; }
        public int IdInstrument { get; set; }
        public int Kolicina { get; set; }

        public UgovorImaInstrumentIznajmljivanje(int id, int idUgovor, int idInstrument, int kolicina)
        {
            Id = id;
            IdUgovor = idUgovor;
            IdInstrument = idInstrument;
            Kolicina = kolicina;
        }
        public override bool Equals(object obj)
        {
            return obj is UgovorImaInstrumentIznajmljivanje iznajmljivanje &&
                   IdUgovor == iznajmljivanje.IdUgovor &&
                   IdInstrument == iznajmljivanje.IdInstrument &&
                   Kolicina == iznajmljivanje.Kolicina;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(IdUgovor, IdInstrument, Kolicina);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
