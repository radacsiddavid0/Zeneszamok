using System.Reflection.Metadata.Ecma335;

namespace Zeneszamok.Models
{
    public class Zeneszam
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int MegjelenesiEv { get; set; }
        public double Hossz { get; set; }
        public bool Jogdija { get; set; }
        public int EloadoId { get; set; }   
        public int KiadoId { get; set; }
        public virtual Eloado Eloado { get; set; }
        public virtual Kiado Kiado { get; set; }


    }
}
