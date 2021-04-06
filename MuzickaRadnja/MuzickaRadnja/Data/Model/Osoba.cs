using System;

namespace MuzickaRadnja.Data.Model
{
    public class Osoba
    {
        public int Id { get; set; }
        public int IdMjesto { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JBM { get; set; }
        public string BrojTelefona { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Pol { get; set; }

        public Osoba()
        {
        }

        public Osoba(int id, int idMjesto, string ime, string prezime, string jbm, string brojTelefona, string email, DateTime datumRodjenja, string pol)
        {
            Id = id;
            IdMjesto = idMjesto;
            Ime = ime;
            Prezime = prezime;
            JBM = jbm;
            BrojTelefona = brojTelefona;
            Email = email;
            DatumRodjenja = datumRodjenja;
            Pol = pol;
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
            return "Osoba" + " | " + Id.ToString() + " | " + IdMjesto.ToString() + " | " + Ime + " | " + Prezime + " | " + JBM + " | " + BrojTelefona + " | " + Email + " | " + DatumRodjenja.ToString() + " | " + Pol;
        }
    }
}