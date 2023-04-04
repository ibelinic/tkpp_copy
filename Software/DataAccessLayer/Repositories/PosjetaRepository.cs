using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PosjetaRepository : Repository<PosjetaLjubimca>
    {

        public PosjetaRepository() : base(new BazaPodataka())
        {
        }

        public IQueryable<PosjetaLjubimca> GetPosjetaByLjubimacID(Ljubimac ljubimac)
        {
            var query = from p in Entities
                        where p.LjubimacID == ljubimac.ID
                        select p;
            return query;
        }

        public List<PosjetaLjubimca> GetLastID()
        {
            var query = (from p in Entities
                         orderby p.ID descending
                         select p).Take(1);
            return query.ToList();
        }

        public List<PosjetaLjubimca> GetOdabranaPosjetaLjubimca(PosjetaLjubimca posjeta, int ljubimac)
        {
            using (var context=new BazaPodataka())
            {
                var upit = from u in context.PosjetaLjubimcas
                           where u.ID.Equals(posjeta.ID) && u.LjubimacID.Equals(ljubimac)
                           select u;
                return upit.ToList();
            }
                
        }

        public override int Add(PosjetaLjubimca entity, bool saveChanges = true) //ova implementacija gazi implementaciju za Add napisanu u klasi Repository
        {
            using (var context = new BazaPodataka())
            {
                var pet = context.Ljubimacs.SingleOrDefault(c => c.ID == entity.LjubimacID);
                var user = context.Korisniks.SingleOrDefault(c => c.ID == entity.KorisnikID);

                var posjeta = new PosjetaLjubimca
                {
                    ID = entity.ID,
                    DatumPosjete = entity.DatumPosjete,
                    RazlogPosjete = entity.RazlogPosjete,
                    KorisnikID = user.ID,
                    LjubimacID = pet.ID
                };
                Entities.Add(posjeta);
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
    }
}