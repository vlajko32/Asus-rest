using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asus_rest.Domain
{
    public class AsusContext: DbContext
    {
        public DbSet<OdgovornoLice> OdgovornaLica { get; set; }

        public DbSet<Trziste> Trzista { get; set; }

        public DbSet<Kupac> Kupci { get; set; }

        public DbSet<Proizvod> Proizvodi { get; set; }
    

        public DbSet<Porudzbenicca> Porudzbenicce { get; set; }

        public DbSet<StavkaPorudzbenicce> StavkePorudzbenicce { get; set; }



        public int MyProperty { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=asus-rest;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OdgovornoLice>(u =>
            {
                u.HasKey(us => us.SifraRadnika);
            });

            modelBuilder.Entity<Trziste>(t =>
            {
                t.HasKey(tr => tr.SifraTrzista);
            });

            modelBuilder.Entity<Kupac>(ku =>
            {
                ku.HasKey(k => k.PiB);
            });

            modelBuilder.Entity<Proizvod>(p =>
            {
                p.HasKey(pr => pr.SifraProizvoda);
            });

           

        }
    }
}
