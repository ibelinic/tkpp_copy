using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RasporedRepository : Repository<Raspored>
    {
        public RasporedRepository() : base(new BazaPodataka())
        {
        } 
        
        public List<Raspored> GetRaspored(Korisnik korisnik)
        {
            using (var context=new BazaPodataka())
            {
                var raspored = from r in Entities
                               where r.KorisnikID==korisnik.ID && r.Datum >= DateTime.Now
                               select r;
                return raspored.ToList();
            }
        }

        public List<Raspored> GetRasporedPast(int korisnik)
        {
            using (var context = new BazaPodataka())
            {
                var raspored = from r in Entities
                               where r.KorisnikID == korisnik && r.Datum < DateTime.Now
                               select r;
                return raspored.ToList();
            }
        }


        public override int Add(Raspored entity, bool saveChanges = true)
        {
            using (var context=new BazaPodataka())
            {
                var korisnik=context.Korisniks.FirstOrDefault(k=>k.ID==entity.KorisnikID);
                var novaAktivnost = new Raspored
                {
                    Datum=entity.Datum,
                    Pocetak=entity.Pocetak,
                    Zavrsetak=entity.Zavrsetak,
                    OpisZauzetosti=entity.OpisZauzetosti,
                    KorisnikID=korisnik.ID,
                    LjubimacID=entity.LjubimacID
                };
                Entities.Add(novaAktivnost);
                if (saveChanges)
                {
                    return SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }

        public override int Update(Raspored entity, bool saveChanges = true)
        {
            using (var context = new BazaPodataka())
            {
                var azurirajAktivnost = Entities.SingleOrDefault(a=>a.ID==entity.ID);

                azurirajAktivnost.Datum = entity.Datum;
                azurirajAktivnost.Pocetak = entity.Pocetak;
                azurirajAktivnost.Zavrsetak = entity.Zavrsetak;
                azurirajAktivnost.OpisZauzetosti = entity.OpisZauzetosti;
               
                if (saveChanges)
                {
                    return SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
        }

        public IEnumerable<Raspored> GetEntities()
        {
            using (var context = new BazaPodataka())
            {
                return context.Rasporeds.ToList();
            }
        }
    }
}
