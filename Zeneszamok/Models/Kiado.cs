namespace Zeneszamok.Models
{
    public class Kiado
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public short AlapitasiEv { get; set; }
        public string Cim { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Zeneszam> Zeneszamok { get; set; } = new List<Zeneszam>();
        
    }
}
