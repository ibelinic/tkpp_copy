using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public partial class Raspored
    {
        public override string ToString()
        {
            return Datum.ToString() + " " + Pocetak.ToString()  + "-" + Zavrsetak.ToString();
        }
    }
}
