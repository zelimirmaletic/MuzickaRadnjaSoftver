using System;

namespace MuzickaRadnja.Data.Model
{
    public class InstrumentIznajmljivanje : Instrument
    {
        public int IdInstrumentIznajmljivanje { get; set; }
        public double CijenaIznajmljivanja { get; set; }
        public int DostupnaKolicina { get; set; }
        public int UkupnaNabavnaKolicina { get; set; }

        public InstrumentIznajmljivanje()
        {
        }

        public InstrumentIznajmljivanje(int idInstrumentIznajmljivanje, double cijenaIznajmljivanja, int dostupnaKolicina, int ukupnaNabavnaKolicina)
        {
            IdInstrumentIznajmljivanje = idInstrumentIznajmljivanje;
            CijenaIznajmljivanja = cijenaIznajmljivanja;
            DostupnaKolicina = dostupnaKolicina;
            UkupnaNabavnaKolicina = ukupnaNabavnaKolicina;
        }

        public InstrumentIznajmljivanje(int id, string naziv, string vrsta, DateTime godinaProizvodnje, double nabavnaCijena, int idInstrumentIznajmljivanje, double cijenaIznajmljivanja, int dostupnaKolicina, int ukupnaNabavnaKolicina) : base(id, naziv, vrsta, godinaProizvodnje, nabavnaCijena)
        {
            IdInstrumentIznajmljivanje = idInstrumentIznajmljivanje;
            CijenaIznajmljivanja = cijenaIznajmljivanja;
            DostupnaKolicina = dostupnaKolicina;
            UkupnaNabavnaKolicina = ukupnaNabavnaKolicina;
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
            return "InstrumentIznajmljivanje" + " | " + Id.ToString() + " | " + Naziv + " | " + Vrsta + " | " + GodinaProizvodnje.ToString() + " | " + NabavnaCijena.ToString()+ " | " + CijenaIznajmljivanja.ToString() + " | " + DostupnaKolicina.ToString() + " | " +
                   UkupnaNabavnaKolicina.ToString();
        }
    }
}