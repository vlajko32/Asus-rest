using Asus_rest.Domain;
using Asus_rest.Repository.iRepo;
using Asus_rest.Repository.repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.uow
{
    public class AsusUnitOfWork : IUnitOfWork
    {
        private AsusContext context; 

        public AsusUnitOfWork(AsusContext context)
        {
            this.context = context;
            Radnici = new RepositoryRadnik(context);
            Trzista = new RepositoryTrziste(context);
            Kupci = new RepositoryKupac(context);
            Proizvodi = new RepositoryProizvod(context);
            Porudzbenice = new RepositoryPorudzbenica(context);
            
        }
        public iRepositoryRadnik Radnici { get; set; }
        public iRepositoryTrziste Trzista { get; set ; }

        public iRepositoryKupac Kupci { get; set; }

        public iRepositoryProizvod Proizvodi { get; set; }
        public iRepositoryPorudzbenica Porudzbenice { get; set; }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
