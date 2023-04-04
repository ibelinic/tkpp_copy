using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public partial class Korisnik
    {
        public override string ToString()
        {
            return Ime+" "+Prezime;
        }
    }
}
