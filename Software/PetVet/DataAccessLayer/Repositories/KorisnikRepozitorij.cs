using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KorisnikRepozitorij : Repository<Korisnik>
    {
        public KorisnikRepozitorij() : base(new BazaPodataka())
        {
        }

        
        public List<Korisnik> ProvjeriKorisnicko(string upisano)
        {
            using (var context = new BazaPodataka())
            {
                var resultat = from t in context.Korisniks
                              where t.KorisnickoIme.Contains(upisano)
                              select t;
                return resultat.ToList();
            }
        }

        public string ProvjeriLozinku(string korisnicko) 
        {
            using (var context = new BazaPodataka())
            {
                var lozinka = context.Korisniks.SingleOrDefault(k => k.KorisnickoIme == korisnicko);
                return lozinka.Lozinka.ToString();
               
            }
        }
        public string UlogaKorisnika(Korisnik korisnicko)
        {
            using (var context = new BazaPodataka())
            {
                var uloga = context.TipKorisnikas.SingleOrDefault(k => k.ID == korisnicko.TipKorisnikaID);
                return uloga.ToString();
            }
        }

        public string RadnoMjestoKorisnika(Korisnik mjesto)
        {
            using (var context = new BazaPodataka())
            {
                var radno = context.VeterinarskaStanicas.SingleOrDefault(k => k.ID == mjesto.VeterinarskaStanicaID);
                return radno.ToString();
            }
        }

        public override int Update(Korisnik entity, bool saveChanges = true)
        {
            using (var context = new BazaPodataka())
            {
                var stanica = context.VeterinarskaStanicas.SingleOrDefault(s => s.ID == entity.VeterinarskaStanicaID);
                var azurirajKorisnika = Entities.SingleOrDefault(k=>k.ID==entity.ID);

                azurirajKorisnika.VeterinarskaStanicaID = stanica.ID;
                
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

        public override IQueryable<Korisnik> GetAll()
        {
            var query = from e in Context.Korisniks
                        where e.TipKorisnikaID == 1
                        select e;
            return query;
        }

        public override IQueryable<Korisnik> GetAllTwo()
        {
            var query = from e in Entities
                        where e.TipKorisnikaID == 2
                        select e;
            return query;
        }

    }
}
