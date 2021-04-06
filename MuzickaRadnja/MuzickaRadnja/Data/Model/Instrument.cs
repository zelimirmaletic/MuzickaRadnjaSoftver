using System;
namespace MuzickaRadnja.Data.Model
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set; }
        public DateTime GodinaProizvodnje { get; set; }
        public double NabavnaCijena { get; set; }

        public Instrument()
        {
        }

        public Instrument(int id, string naziv, string vrsta, DateTime godinaProizvodnje, double nabavnaCijena)
        {
            Id = id;
            Naziv = naziv;
            Vrsta = vrsta;
            GodinaProizvodnje = godinaProizvodnje;
            NabavnaCijena = nabavnaCijena;
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
            return "Instrument" + "|" + Id.ToString() + "|" + Naziv + "|" + Vrsta + "|" + GodinaProizvodnje.ToString() + "|" +
                   NabavnaCijena.ToString();
        }
    }
}