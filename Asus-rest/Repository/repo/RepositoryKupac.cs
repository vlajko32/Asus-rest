using Asus_rest.Domain;
using Asus_rest.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.repo
{
    public class RepositoryKupac : iRepositoryKupac
    {
        AsusContext context;

        public RepositoryKupac(AsusContext context)
        {
            this.context = context;
        }
        public void Delete(Kupac item)
        {
            throw new NotImplementedException();
        }

        public Kupac FindById(string PiB)
        {
            return context.Kupci.SingleOrDefault(ku => ku.PiB == PiB);
        }

        public Kupac FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Kupac> GetAll()
        {
            return context.Kupci.ToList();
        }

        public void Insert(Kupac item)
        {
            throw new NotImplementedException();
        }

        public void Update(Kupac item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
