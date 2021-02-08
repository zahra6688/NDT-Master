using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NDT.Domain.Models;

namespace NDT.Infra.Data.Context
{
    public class NdtDbContext:DbContext
    {
        public NdtDbContext(DbContextOptions<NdtDbContext> options) : base(options)
        {
        }
        
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            #region Seed Data Client
            modelBuilder.Entity<Client>().HasData(
                new Client { Id=Guid.NewGuid(), Address= "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", ClientName= " صنایع  پتروشیمی رامپکو", CeoName="احمد محمدی"},
                new Client { Id = Guid.NewGuid(), Address = "اراک-کوی صنعتی ,خیابان پامچال ", ClientName = "ماشین سازی اراک", CeoName = "علی حمیدی" },
                new Client { Id = Guid.NewGuid(), Address = "قشم-مجتمع خلیج فارس -واحد 84", ClientName = "فراپتروسازان انرژی قشم", CeoName = "حسین نوابی" }
                );
            #endregion
            modelBuilder.Entity<Client>().ToTable("Clients");
            base.OnModelCreating(modelBuilder);
        }
    }
}
