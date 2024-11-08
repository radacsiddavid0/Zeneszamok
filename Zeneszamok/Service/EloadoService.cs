using Zeneszamok.Models;

namespace Zeneszamok.Service
{
    public class EloadoService
    {
        public static List<Eloado> GetEloadok()
        {
            var context = new ZeneszamokContext();
            try
            {
                var response = context.Eloadok.ToList();
                return response;
            }
            catch (Exception ex)
            {
                List<Eloado> hiba = new List<Eloado>()
                {
                    new Eloado()
                    {
                        Id = -1,
                        Nev = ex.Message,
                    }
                };
                return hiba;
            }
        }
    }
}
