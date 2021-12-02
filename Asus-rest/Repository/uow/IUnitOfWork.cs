using Asus_rest.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.uow
{
    public interface IUnitOfWork
    {

        public iRepositoryRadnik Radnici { get; set; }
        public iRepositoryTrziste Trzista { get; set; }

        public iRepositoryKupac Kupci { get; set; }

        public iRepositoryProizvod Proizvodi { get; set; }

        public iRepositoryPorudzbenica Porudzbenice { get; set; }

        void Commit();

        void Dispose();

    }
}
