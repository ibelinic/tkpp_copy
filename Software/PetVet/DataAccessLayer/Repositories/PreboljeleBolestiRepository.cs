using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PreboljeleBolestiRepository : Repository<PreboljeleBolesti>
    {
        public PreboljeleBolestiRepository() : base(new BazaPodataka())
        {
        }

        public IQueryable<PreboljeleBolesti> GetBolestiByID(int posjeta)
        {
            var query = from p in Entities
                        where p.PosjetaLjubimcaID == posjeta
                        select p;
            return query;
        }

        public override int Add(PreboljeleBolesti entity, bool saveChanges = true) //ova implementacija gazi implementaciju za Add napisanu u klasi Repository
        {
            using (var context = new BazaPodataka())
            {
                var posjeta = context.PosjetaLjubimcas.SingleOrDefault(c => c.ID == entity.PosjetaLjubimcaID);
                var bolest = new PreboljeleBolesti
                {
                    ID = entity.ID,
                    Naziv = entity.Naziv,
                    Opis = entity.Opis,
                    DatumBolesti = entity.DatumBolesti,
                    PosjetaLjubimcaID = posjeta.ID
                };
                Entities.Add(bolest);
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
