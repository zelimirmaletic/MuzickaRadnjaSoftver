using System;

namespace MuzickaRadnja.Data.Model
{
    public class Racun
    {
        public int Id { get; set; }
        public int IdOsoba { get; set; }
        public int IdVrstaPlacanja { get; set; }
        public DateTime DatumVrijemeIzdavanja { get; set; }
        public double Popust { get; set; }

        public Racun()
        {
        }

        public Racun(int id, int idOsoba, int idVrstaPlacanja, DateTime datumVrijemeIzdavanja, double popust)
        {
            Id = id;
            IdOsoba = idOsoba;
            IdVrstaPlacanja = idVrstaPlacanja;
            DatumVrijemeIzdavanja = datumVrijemeIzdavanja;
            Popust = popust;
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
            return "Racun" + " | " + Id.ToString() + " | " + IdOsoba.ToString() + " | " + IdVrstaPlacanja.ToString() +
                   " | " + DatumVrijemeIzdavanja.ToString() + " | " + Popust.ToString();
        }
    }
}