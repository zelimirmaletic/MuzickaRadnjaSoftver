using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuzickaRadnja.Data.Model
{
    class Ugovor
    {
        public int Id { get; set; }
        public int IdKlijent { get; set; }
        public int IdZaposleni { get; set; }
        public DateTime DatumSklapanja { get; set; }
        public bool PlacanjeNaRate { get; set; }
        public int PeriodIznajmljivanja { get; set; }
        public bool Otplaceno { get; set; }
        public bool Potpisan { get; set; }
        public string Opis { get; set; }
        public int BrojRata { get; set; }
        public int ProduzavanjeUgovora { get; set; }

        public Ugovor()
        {
        }

        public Ugovor(int id, int idKlijent, int idZaposleni, DateTime datumSklapanja, bool placanjeNaRate, int periodIznajmljivanja, bool otplaceno, bool potpisan, string opis, int brojRata, int produzavanjeUgovora)
        {
            Id = id;
            IdKlijent = idKlijent;
            IdZaposleni = idZaposleni;
            DatumSklapanja = datumSklapanja;
            PlacanjeNaRate = placanjeNaRate;
            PeriodIznajmljivanja = periodIznajmljivanja;
            Otplaceno = otplaceno;
            Potpisan = potpisan;
            Opis = opis;
            BrojRata = brojRata;
            ProduzavanjeUgovora = produzavanjeUgovora;
        }

        public override bool Equals(object obj)
        {
            return obj is Ugovor ugovor &&
                   Id == ugovor.Id &&
                   IdKlijent == ugovor.IdKlijent &&
                   IdZaposleni == ugovor.IdZaposleni;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, IdKlijent, IdZaposleni);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
