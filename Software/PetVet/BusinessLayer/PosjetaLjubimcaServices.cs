using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PosjetaLjubimcaServices
    {
        public List<PosjetaLjubimca> GetPosjetaLjubimcas(Ljubimac ljubimac) //metoda mora kreirati repozitorij za ljubimce i upotrijebiti metodu GetAll da bi izvršila dohvaćanje ljubimaca
        {
            using (var repo = new PosjetaRepository())
            {
                List<PosjetaLjubimca> visits = repo.GetPosjetaByLjubimacID(ljubimac).ToList(); //pokrećemo upit tako da pozivamo metodu ToList
                return visits;
            }
        }

        public List<PosjetaLjubimca> GetOdabranaPosjeta(PosjetaLjubimca odabranaPosjeta, int ljubimac)
        {
            using (var repo=new PosjetaRepository())
            {
                List<PosjetaLjubimca> posjeta = repo.GetOdabranaPosjetaLjubimca(odabranaPosjeta, ljubimac);
                return posjeta;
            }
        }

        public bool AddPosjeta(PosjetaLjubimca posjeta) //metoda za dohvaćanje knjiga, a vraća je li uspješno dodana ili ne
        {
            bool isSuccessful = false;
            using (var repo = new PosjetaRepository())
            {
                int affectedRows = repo.Add(posjeta);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public int GetLastInsertedPosjeta()
        {
            using (var repo = new PosjetaRepository())
            {
                var lastInsertedPosjeta = repo.GetLastID();
                if (lastInsertedPosjeta.Count > 0)
                    return lastInsertedPosjeta[0].ID;
                else
                    return -1;
            }
        }
    }
}

