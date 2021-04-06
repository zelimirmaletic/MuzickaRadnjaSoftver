using System;

namespace MuzickaRadnja.Data.Model
{
    public class InstrumentProdaja : Instrument
    {
        public int IdInstrumentProdaja { get; set; }
        public double MaloprodajnaCijena { get; set; }
        public int DostupnaKolicina { get; set; }
        public int UkupnaNabavnaKolicina { get; set; }

        public InstrumentProdaja()
        {
        }

        public InstrumentProdaja(int idInstrumentProdaja, double maloprodajnaCijena, int dostupnaKolicina, int ukupnaNabavnaKolicina)
        {
            IdInstrumentProdaja = idInstrumentProdaja;
            MaloprodajnaCijena = maloprodajnaCijena;
            DostupnaKolicina = dostupnaKolicina;
            UkupnaNabavnaKolicina = ukupnaNabavnaKolicina;
        }

        public InstrumentProdaja(int id, string naziv, string vrsta, DateTime godinaProizvodnje, double nabavnaCijena, int idInstrumentProdaja, double maloprodajnaCijena, int dostupnaKolicina, int ukupnaNabavnaKolicina) : base(id, naziv, vrsta, godinaProizvodnje, nabavnaCijena)
        {
            IdInstrumentProdaja = idInstrumentProdaja;
            MaloprodajnaCijena = maloprodajnaCijena;
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
            return "InstrumentProdaja" + " | " + Id.ToString() + " | " + Naziv + " | " + Vrsta + " | " + GodinaProizvodnje.ToString() + " | " + NabavnaCijena.ToString()+ " | " + MaloprodajnaCijena.ToString() + " | " + DostupnaKolicina.ToString() + " | " +
                   UkupnaNabavnaKolicina.ToString();
        }
    }
}