using System;

namespace MuzickaRadnja.Data.Model
{
    public class Zaposleni : Osoba
    {
        public int IdZaposleni { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumZaposlenja { get; set; }

        public Zaposleni()
        {
        }

        public Zaposleni(int idZaposleni, string korisnickoIme, string lozinka, DateTime datumZaposlenja)
        {
            IdZaposleni = idZaposleni;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            DatumZaposlenja = datumZaposlenja;
        }

        public Zaposleni(int id, int idMjesto, string ime, string prezime, string jbm, string brojTelefona, string email, DateTime datumRodjenja, string pol, int idZaposleni, string korisnickoIme, string lozinka, DateTime datumZaposlenja) : base(id, idMjesto, ime, prezime, jbm, brojTelefona, email, datumRodjenja, pol)
        {
            IdZaposleni = idZaposleni;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
            DatumZaposlenja = datumZaposlenja;
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
            return "Osoba" + " | " + Id.ToString() + " | " + IdMjesto.ToString() + " | " + Ime + " | " + Prezime + " | " + JBM + " | " + BrojTelefona + " | " + Email + " | " + DatumRodjenja.ToString() + " | " + Pol + " | " + KorisnickoIme + " | " + DatumZaposlenja;
        }
    }
}