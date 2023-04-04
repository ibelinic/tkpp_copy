using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class TipKorisnikaRepository : Repository<TipKorisnika>
    {
        public TipKorisnikaRepository() : base(new BazaPodataka())
        {
        }

    }
}
