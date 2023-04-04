using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class VeterinarskaStanicaServices
    {
        public List<VeterinarskaStanica> GetStanice()
        {
            using (var repozitorij=new VeterinarskaStanicaRepozitorij())
            {
                var stanice = repozitorij.GetAll();
                return stanice.ToList();
            }
        }
    }
}
