using System;

namespace MuzickaRadnja.Data.Model
{
    public class Klijent : Osoba
    {
        public  int IdKlijent { get; set; }
        public DateTime DatumUclanjivanja { get; set; }

        public Klijent()
        {
        }

        public Klijent(int idKlijent, DateTime datumUclanjivanja)
        {
            IdKlijent = idKlijent;
            DatumUclanjivanja = datumUclanjivanja;
        }

        public Klijent(int id, int idMjesto, string ime, string prezime, string jbm, string brojTelefona, string email, DateTime datumRodjenja, string pol, int idKlijent, DateTime datumUclanjivanja) : base(id, idMjesto, ime, prezime, jbm, brojTelefona, email, datumRodjenja, pol)
        {
            IdKlijent = idKlijent;
            DatumUclanjivanja = datumUclanjivanja;
        }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Osoba" + " | " + Id.ToString() + " | " + IdMjesto.ToString() + " | " + Ime + " | " + Prezime + " | " + JMB + " | " + BrojTelefona + " | " + Email + " | " + DatumRodjenja.ToString() + " | " + Pol + " | " + DatumUclanjivanja;
        }
    }
}