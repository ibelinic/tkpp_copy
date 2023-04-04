using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PreboljeleBolestiServices
    {
        public List<PreboljeleBolesti> GetBolesti(int posjeta) //metoda mora kreirati repozitorij za ljubimce i upotrijebiti metodu GetAll da bi izvršila dohvaćanje ljubimaca
        {
            using (var repo = new PreboljeleBolestiRepository())
            {
                List<PreboljeleBolesti> bolesti = repo.GetBolestiByID(posjeta).ToList(); //pokrećemo upit tako da pozivamo metodu ToList
                return bolesti;
            }
        }

        public bool AddBolest(PreboljeleBolesti bolest) //metoda za dohvaćanje knjiga, a vraća je li uspješno dodana ili ne
        {
            bool isSuccessful = false;
            using (var repo = new PreboljeleBolestiRepository())
            {
                int affectedRows = repo.Add(bolest);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
