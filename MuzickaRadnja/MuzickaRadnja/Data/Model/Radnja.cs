namespace MuzickaRadnja.Data.Model
{
    public class Radnja
    {
        public int Id { get; set; }
        public int IdMjesto { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string ZiroRacun { get; set; }
        public string Banka { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public Radnja()
        {
        }

        public Radnja(int id, int idMjesto, string naziv, string adresa, string ziroRacun, string banka, string email, string telefon)
        {
            Id = id;
            IdMjesto = idMjesto;
            Naziv = naziv;
            Adresa = adresa;
            ZiroRacun = ziroRacun;
            Banka = banka;
            Email = email;
            Telefon = telefon;
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
            return "Radnja" + " | " + Id.ToString() + " | " + IdMjesto.ToString() + " | " + Naziv + " | " + Adresa + " | " +
                   ZiroRacun + " | " + Banka + " | " + Email + " | " + Telefon;
        }
    }
}