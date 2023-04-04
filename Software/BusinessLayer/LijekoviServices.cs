using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LijekoviServices
    {
        public List<Lijekovi> GetLijekovi(int posjeta) //metoda mora kreirati repozitorij za ljubimce i upotrijebiti metodu GetAll da bi izvršila dohvaćanje ljubimaca
        {
            using (var repo = new LijekoviRepository())
            {
                List<Lijekovi> lijekovi = repo.GetLijekoviByID(posjeta).ToList(); //pokrećemo upit tako da pozivamo metodu ToList
                return lijekovi;
            }
        }

        public bool AddLijek(Lijekovi lijek) //metoda za dohvaćanje knjiga, a vraća je li uspješno dodana ili ne
        {
            bool isSuccessful = false;
            using (var repo = new LijekoviRepository())
            {
                int affectedRows = repo.Add(lijek);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
    }
}
