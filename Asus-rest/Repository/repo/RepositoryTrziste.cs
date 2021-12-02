using Asus_rest.Domain;
using Asus_rest.Repository.iRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.repo
{
    public class RepositoryTrziste : iRepositoryTrziste
    {

        AsusContext context;

        public RepositoryTrziste(AsusContext context)
        {
            this.context = context;
        }


        public void Delete(Trziste item)
        {
            throw new NotImplementedException();
        }

        public Trziste FindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Trziste> GetAll()
        {
            List<Trziste> trzista = context.Trzista.ToList();
            return trzista;
        }

        public void Insert(Trziste item)
        {
            throw new NotImplementedException();
        }

        public void Update(Trziste item, int id)
        {
            throw new NotImplementedException();
        }
    }
}
