using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LjubimacRepository : Repository<Ljubimac>
    {
        public LjubimacRepository() : base(new BazaPodataka())
        {
        }

        public IQueryable<Ljubimac> GetAllByCriterion(int userID)
        {
            var query = from e in Entities
                        where e.KorisnikID == userID
                        select e;
            return query;
        }

        public IQueryable<Ljubimac> GetLjubimac(Ljubimac ljubimac)
        {
            var query = from e in Entities
                        where e.ID == ljubimac.ID
                        select e;
            return query;
        }

        public IQueryable<Ljubimac> GetPetsByName(string imeLjubimca)
        {
            var query = from e in Entities.Include("Korisnik").Include("PasminaLjubimca")
                        where e.Ime.StartsWith(imeLjubimca) 
                        orderby e.Ime
                        select e;
            return query;
        }

        public override int Add(Ljubimac entity, bool saveChanges = true) //ova implementacija gazi implementaciju za Add napisanu u klasi Repository
        {
            using (var context = new BazaPodataka())
            {
                var type = context.PasminaLjubimcas.SingleOrDefault(c => c.ID == entity.PasminaLjubimca.ID);
                var user = context.Korisniks.SingleOrDefault(c => c.ID == entity.KorisnikID);

                var ljubimac = new Ljubimac
                {
                    ID = entity.ID,
                    Ime = entity.Ime,
                    Prezime = entity.Prezime,
                    BrojIskaznice = entity.BrojIskaznice,
                    BrojChipa = entity.BrojChipa,
                    Tezina_Kg = entity.Tezina_Kg,
                    Visina_Cm = entity.Visina_Cm,
                    TipLjubimcaID = type.ID,
                    KorisnikID = user.ID,
                    BrojKartona = entity.BrojKartona,
                    Biljeske = entity.Biljeske
                };
                Entities.Add(ljubimac);
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

        public override int Update(Ljubimac entity, bool saveChanges = true)
        {
            using (var context = new BazaPodataka())
            {
                var type = context.PasminaLjubimcas.SingleOrDefault(c => c.ID == entity.TipLjubimcaID);
                var user = context.Korisniks.SingleOrDefault(c => c.ID == entity.KorisnikID);
                var ljubimac = Entities.SingleOrDefault(p => p.ID == entity.ID);
                ljubimac.ID = entity.ID;
                ljubimac.Ime = entity.Ime;
                ljubimac.Prezime = entity.Prezime;
                ljubimac.BrojIskaznice = entity.BrojIskaznice;
                ljubimac.BrojChipa = entity.BrojChipa;
                ljubimac.Tezina_Kg = entity.Tezina_Kg;
                ljubimac.Visina_Cm = entity.Visina_Cm;
                ljubimac.TipLjubimcaID = type.ID;
                ljubimac.KorisnikID = user.ID;
                ljubimac.BrojKartona = entity.BrojKartona;
                ljubimac.Biljeske = entity.Biljeske;
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

        public Ljubimac GetById(int selectedPetID)
        {
            using (var repo = new LjubimacRepository())
            {
                var query = from e in repo.Entities
                            where e.ID == selectedPetID
                            select e;
                return query.SingleOrDefault();
            }
        }

    }
}