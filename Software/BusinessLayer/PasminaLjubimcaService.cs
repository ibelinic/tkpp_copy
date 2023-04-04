using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PasminaLjubimcaService
    {
        public List<PasminaLjubimca> GetTypeAnimal()
        {
            using (var repo = new PasminaLjubimcaRepository())
            {
                List<PasminaLjubimca> pasmina = repo.GetAll().ToList();
                return pasmina;
            }
        }
    }
}
