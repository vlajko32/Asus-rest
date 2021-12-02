using Asus_rest.Domain;
using Asus_rest.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.repo
{
    public class RepositoryProizvod : iRepositoryProizvod
    {
        AsusContext context;
        public RepositoryProizvod(AsusContext context)
        {
            this.context = context;
        }
        public void Delete(Proizvod item)
        {
            throw new NotImplementedException();
        }

        public Proizvod FindById(int id)
        {
            return context.Proizvodi.SingleOrDefault(pr => pr.SifraProizvoda == id);
        }

        public List<Proizvod> GetAll()
        {
            return context.Proizvodi.ToList();
        }

        public void Insert(Proizvod item)
        {
            throw new NotImplementedException();
        }

        public void Update(Proizvod item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
