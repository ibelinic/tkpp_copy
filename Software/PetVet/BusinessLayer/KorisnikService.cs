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
    public class KorisnikService
    {
        
        public List<Korisnik> KorisnikPostoji(string upisan)
        {
            using (var repozitorij = new KorisnikRepozitorij())
            {
               return repozitorij.ProvjeriKorisnicko(upisan).ToList();
             
            }
        }

        public bool ProvjeriLozinku(string korisnicko,string lozinka)
        {
            
            using (var repozitorij = new KorisnikRepozitorij())
            {
               string provjera=repozitorij.ProvjeriLozinku(korisnicko);
                if (provjera==lozinka)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Registriraj(Korisnik korisnik)
        { bool isSuccessful = false;
            using (var repozitorij = new KorisnikRepozitorij())
            {
                 int affectedRows = repozitorij.Registriraj(korisnik);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
          
        }
        public bool UpdateKorisnik(Korisnik korisnik)
        {
            bool isSuccessful = false;
            using (var repo = new KorisnikRepozitorij())
            {
                int affectedRows = repo.Update(korisnik);
                isSuccessful = affectedRows > 0;
            }
            return isSuccessful;
        }
        public List<Korisnik> GetUsers()
        {
            using (var repo = new KorisnikRepozitorij())
            {
                List<Korisnik> korisnici = repo.GetAll().ToList();
                return korisnici;
            }
        }

        public string Uloga(Korisnik korisnik)
        {
            using (var repo = new KorisnikRepozitorij())
            {
               var uloga=repo.UlogaKorisnika(korisnik);
                
                return uloga.ToString();
               
            }
        }

        public string RadnoMjesto(Korisnik korisnik)
        {
            using (var repo = new KorisnikRepozitorij())
            {
                var radno = repo.RadnoMjestoKorisnika(korisnik);

                return radno.ToString();

            }
        }

        public List<Korisnik> GetVets() //metoda mora kreirati repozitorij za ljubimce i upotrijebiti metodu GetAll da bi izvršila dohvaćanje ljubimaca
        {
            using (var repo = new KorisnikRepozitorij())
            {
                List<Korisnik> vets = repo.GetAllTwo().ToList(); //pokrećemo upit tako da pozivamo metodu ToList
                return vets;
            }
        }

    }
}
