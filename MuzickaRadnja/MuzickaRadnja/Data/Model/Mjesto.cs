namespace MuzickaRadnja.Data.Model
{
    public class Mjesto
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }

        public Mjesto()
        {
        }

        public Mjesto(int id, string naziv, string oznaka)
        {
            Id = id;
            Naziv = naziv;
            Oznaka = oznaka;
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
            return "Mjesto " + " | " + Id.ToString() + " | " + Naziv + " | " + Oznaka;
        }
    }
}