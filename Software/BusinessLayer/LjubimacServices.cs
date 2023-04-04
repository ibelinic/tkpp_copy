using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LjubimacServices
    {
        public List<Ljubimac> GetPets() //metoda mora kreirati repozitorij za ljubimce i upotrijebiti metodu GetAll da bi izvršila dohvaćanje ljubimaca
        {
            using (var repo = new LjubimacRepository())
            {
                List<Ljubimac> pets = repo.GetAll().ToList(); //pokrećemo upit tako da pozivamo metodu ToList
                return pets;
            }
        }

        public List<Ljubimac> GetPetsByKorisnik(int userID) //metoda mora kreirati repozitorij za ljubimce i upotrijebiti metodu GetAll da bi izvršila dohvaćanje ljubimaca
        {
            using (var repo = new LjubimacRepository())
            {
                List<Ljubimac> pets = repo.GetAllByCriterion(userID).ToList(); //pokrećemo upit tako da pozivamo metodu ToList
                return pets;
            }
        }

        public List<Ljubimac> GetPetsByName(string imeLjubimca)
        {
            using (var repo = new LjubimacRepository())
            {
                List<Ljubimac> pets = repo.GetPetsByName(imeLjubimca).ToList();
                return pets;
            }
        }

        public List<Ljubimac> GetLjubimac(Ljubimac ljubimac)
        {
            using (var repo=new LjubimacRepository())
            {
                List<Ljubimac> pet = repo.GetLjubimac(ljubimac).ToList(); 
                return pet;
            }
        }
     

        public bool AddPet(Ljubimac ljubimac) //metoda za dohvaćanje knjiga, a vraća je li uspješno dodana ili ne
        {
            bool isSuccessful = false;
            using (var repo = new LjubimacRepository())
            {
                int affectedRows = repo.Add(ljubimac);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public bool RemovePet(Ljubimac ljubimac) //metoda za brisanje knjiga, a vraća je li uspješno brisanje ili ne
        {
            bool isSuccessful = false;
            //ako postoje uvjeti za brisanje (primjer onih kojih nema na stanju, oni koji su u tijeku naručivanja itd) -->
            // bool canRemove = CheckIfLjubimacCanBeRemoved (book);
            // kreira se metoda private bool CheckIfLjubimacCanBeRemoved (Ljubimac ljubimac) { if (ljubimac == null) return false; else return true;}
            using (var repo = new LjubimacRepository())
            {
                int affectedRows = repo.Remove(ljubimac);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public bool UpdateLjubimac(Ljubimac ljubimac)
        {
            bool isSuccessful = false;
            using (var repo = new LjubimacRepository())
            {
                int affectedRows = repo.Update(ljubimac);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }

        public int GetKorisnikIDByPetID(int selectedPetID)
        {
            int korisnikID = 0;
            using (var repo = new LjubimacRepository())
            {
                Ljubimac ljubimac = repo.GetById(selectedPetID);
                if (ljubimac != null)
                {
                    korisnikID = ljubimac.KorisnikID;
                }
            }
            return korisnikID;
        }


      
    }
}
