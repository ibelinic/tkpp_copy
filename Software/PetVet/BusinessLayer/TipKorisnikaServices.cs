using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TipKorisnikaServices
    {
        public List<TipKorisnika> GetTipKorisnika()
        {
            using (var repozitorij = new TipKorisnikaRepository())
            {
                var tipovi = repozitorij.GetAll();
                return tipovi.ToList();
            }
        }
    }
}
