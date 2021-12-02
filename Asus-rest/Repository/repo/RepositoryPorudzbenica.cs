using Asus_rest.Domain;
using Asus_rest.Repository.iRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Repository.repo
{
    public class RepositoryPorudzbenica : iRepositoryPorudzbenica
    {

        AsusContext context;

        public RepositoryPorudzbenica(AsusContext context)
        {
            this.context = context;
        }

        public void Delete(Porudzbenicca item)
        {
            context.Porudzbenicce.Remove(item);
        }

    

        public Porudzbenicca FindById(int id)
        {
            return context.Porudzbenicce.Include(pr => pr.Kupac).Include(pr => pr.StavkePorudzbenice).ThenInclude(spr => spr.Proizvod).SingleOrDefault(pr => pr.PorudzbeniccaID == id);
        }

        public List<Porudzbenicca> GetAll()
        {
            return context.Porudzbenicce.Include(pr=>pr.OdgovornoLice).Include(pr => pr.Kupac).Include(pr=>pr.StavkePorudzbenice).ThenInclude(spr=>spr.Proizvod).ToList();
        }

        public void Insert(Porudzbenicca item)
        {
            context.Porudzbenicce.Add(item);
        }

     

        public void Update(Porudzbenicca item, int id)
        {
            Porudzbenicca updated = context.Porudzbenicce.Include(pr => pr.Kupac).Include(pr => pr.StavkePorudzbenice).ThenInclude(spr => spr.Proizvod).SingleOrDefault(pr => pr.PorudzbeniccaID == id);
            updated.PiB = item.PiB;
            updated.SifraRadnika = item.SifraRadnika;
            updated.StavkePorudzbenice = item.StavkePorudzbenice;
            context.Porudzbenicce.Update(item);


        }

     
    }
}
