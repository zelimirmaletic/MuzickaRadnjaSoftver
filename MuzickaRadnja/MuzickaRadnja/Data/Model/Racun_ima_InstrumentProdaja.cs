namespace MuzickaRadnja.Data.Model
{
    public class Racun_ima_InstrumentProdaja
    {
        public int IdRacun { get; set; }
        public int IdInstrument { get; set; }
        public int Kolicina { get; set; }

        public Racun_ima_InstrumentProdaja()
        {
        }

        public Racun_ima_InstrumentProdaja(int idRacun, int idInstrument, int kolicina)
        {
            IdRacun = idRacun;
            IdInstrument = idInstrument;
            Kolicina = kolicina;
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
            return "Racun_ima_InstrumentProdaja" + " | " + IdRacun.ToString() + " | " + IdInstrument.ToString() +
                   " | " + Kolicina.ToString();
        }
    }
}