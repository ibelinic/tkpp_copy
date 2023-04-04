using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class LijekoviRepository : Repository<Lijekovi>
    {
        public LijekoviRepository() : base(new BazaPodataka())
        {
        }

        public LijekoviRepository(BazaPodataka context) : base(context)
        {
        }

        public IQueryable<Lijekovi> GetLijekoviByID(int posjeta)
        {
            var query = from p in Entities
                        where p.PosjetaLjubimcaID == posjeta
                        select p;
            return query;
        }

        public override int Add(Lijekovi entity, bool saveChanges = true) //ova implementacija gazi implementaciju za Add napisanu u klasi Repository
        {
            using (var context = new BazaPodataka())
            {
                var posjeta = context.PosjetaLjubimcas.SingleOrDefault(c => c.ID == entity.PosjetaLjubimcaID);
                var lijek = new Lijekovi
                {
                    ID = entity.ID,
                    Naziv = entity.Naziv,
                    Opis = entity.Opis,
                    PosjetaLjubimcaID = posjeta.ID
                };
                Entities.Add(lijek);
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
