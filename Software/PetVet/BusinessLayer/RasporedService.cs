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
    public class RasporedService
    {
        
        public List<Raspored> GetSchedule()
        {
            using (var repo = new RasporedRepository())
            {
                List<Raspored> schedules = repo.GetAll().ToList();
                return schedules;
            }
        }

        public List<Raspored> GetRasporedVeterinar(Korisnik korisnik)
        {
            using (var repozitorij=new RasporedRepository())
            {
                var rasporedVeterinara = repozitorij.GetRaspored(korisnik);
                return rasporedVeterinara;
            }
        }

        public List<Raspored> GetRasporedVeterinarPast(int korisnik)
        {
            using (var repozitorij = new RasporedRepository())
            {
                var rasporedVeterinara = repozitorij.GetRasporedPast(korisnik);
                return rasporedVeterinara;
            }
        }


        public bool DodajNaRaspored(Raspored novaAktivnost)
        {
            bool dodan = false;
            using (var repozitorij = new RasporedRepository())
            {
                int red= repozitorij.Add(novaAktivnost);
                dodan = red > 0;
            }
            return dodan;
        }

        public bool Update(Raspored azurirajAktivnost)
        {
            bool azuriran = false;
            using (var repozitorij=new RasporedRepository())
            {
                int red = repozitorij.Update(azurirajAktivnost);
                azuriran = red > 0;
            }
            return azuriran;
        }

        public bool Remove(Raspored obrisiAktivnost)
        {
            bool obrisan = false;
            using (var repozitorij = new RasporedRepository())
            {
                int red = repozitorij.Remove(obrisiAktivnost);
                obrisan = red > 0;
            }
            return obrisan;
        }



        public bool OdjaviTermin(int selectedID)
        {
            using (var repo = new RasporedRepository())
            {
                var query = from e in repo.GetEntities()
                            where e.ID == selectedID
                            select e;
                var termin = query.SingleOrDefault();
                if (termin != null)
                {
                    repo.Remove(termin);
                    repo.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
