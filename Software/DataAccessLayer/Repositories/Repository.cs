using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public abstract class Repository<T>:IDisposable where T : class
    {
        protected BazaPodataka Context { get; set; }

        protected DbSet<T> Entities { get; set; }

        public Repository(BazaPodataka context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }

        //-------------F01----------------
        public virtual int Registriraj(T entity, bool saveChanges = true)
        {
            Entities.Add(entity);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
      

        public void Dispose()
        {
            Context.Dispose();
        }

        //-------------F02----------------

        public virtual IQueryable<T> GetAll() //dopustiti podklasama da ju nadjačaju pa stavljamo virtual, vraća upit IQueryable koji će se izvršiti onda kada ga želimo konzumirati
        {
            var query = from e in Entities //vraća sve entitete u kolekciji entiteta
                        select e;
            return query;
        }

        public virtual IQueryable<T> GetAllTwo() //dopustiti podklasama da ju nadjačaju pa stavljamo virtual, vraća upit IQueryable koji će se izvršiti onda kada ga želimo konzumirati
        {
            var query = from e in Entities //vraća sve entitete u kolekciji entiteta
                        select e;
            return query;
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public virtual int Add(T entity, bool saveChanges = true)
        {
            Entities.Add(entity);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public virtual int Remove(T entity, bool saveChanges = true)
        {
            Entities.Attach(entity); //prvo registrirati T entity u kolekciji pomocu Attach kako bi ga mogli iz baze i obrisati
            Entities.Remove(entity);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        //F04
        public virtual int Update(T entity, bool saveChanges = true)
        {
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
