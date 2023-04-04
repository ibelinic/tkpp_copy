using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class VeterinarskaStanicaRepozitorij : Repository<VeterinarskaStanica>
    {
        public VeterinarskaStanicaRepozitorij() : base(new BazaPodataka())
        {
        }
    }
}
