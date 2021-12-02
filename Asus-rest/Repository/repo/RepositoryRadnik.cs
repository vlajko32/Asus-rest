using Asus_rest.Domain;
using Asus_rest.Repository.iRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.repo
{
    public class RepositoryRadnik : iRepositoryRadnik
    {
        AsusContext context;

        public RepositoryRadnik(AsusContext context)
        {
            this.context = context;
        }
        public void Delete(OdgovornoLice item)
        {
            context.OdgovornaLica.Remove(item);
        }

        public OdgovornoLice FindById(int id)
        {
            return context.OdgovornaLica.Include(ol => ol.Trziste).SingleOrDefault(ol => ol.SifraRadnika == id);
        }

        public List<OdgovornoLice> GetAll()
        {
            return context.OdgovornaLica.Include(ol => ol.Trziste).ToList();
        }

        public void Insert(OdgovornoLice item)
        {
            context.OdgovornaLica.Add(item);
        }

        public void Update(OdgovornoLice item, int id)
        {
            OdgovornoLice updated = context.OdgovornaLica.Find(id);

            updated.ImePrezime = item.ImePrezime;
            updated.Email = item.Email;
            updated.Trziste = item.Trziste;

            context.OdgovornaLica.Update(updated);
        }
    }
}
