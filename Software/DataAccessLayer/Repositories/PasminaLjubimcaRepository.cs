using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PasminaLjubimcaRepository : Repository<PasminaLjubimca>
    {
        public PasminaLjubimcaRepository() : base(new BazaPodataka())
        {
        }
    }
}
