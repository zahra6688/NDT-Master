using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NDT.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NDT.Infra.Data.Context
{
    public class NdtDbContext:IdentityDbContext
    {
        public NdtDbContext(DbContextOptions<NdtDbContext> options) : base(options)
        {
        }
        
        public DbSet<Client> Clients { get; set; }
        public DbSet<MenuModel> menuItems { get; set; }
        public DbSet<Project> projects { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            #region Seed Data Client
            modelBuilder.Entity<Client>().HasData(
                new Client { Id=Guid.NewGuid(), Address= "تهران- خیابان ولی عصر خیابان بهرامی پلاک50", ClientName= " صنایع  پتروشیمی رامپکو", CeoName="احمد محمدی"},
                new Client { Id = Guid.NewGuid(), Address = "اراک-کوی صنعتی ,خیابان پامچال ", ClientName = "ماشین سازی اراک", CeoName = "علی حمیدی" },
                new Client { Id = Guid.NewGuid(), Address = "قشم-مجتمع خلیج فارس -واحد 84", ClientName = "فراپتروسازان انرژی قشم", CeoName = "حسین نوابی" }
                );
            #endregion
            #region Seed Data Menu
            modelBuilder.Entity<MenuModel>().HasData(
                new MenuModel { Id=Guid.NewGuid(), Title="کارفرمایان", ControllerName="Client",ActionName= "ShowClients" },
                new MenuModel { Id = Guid.NewGuid(), Title = "پروژه‌ها", ControllerName = "Project", ActionName = "Details" },
                new MenuModel { Id = Guid.NewGuid(), Title = "تجهیزات", ControllerName = "", ActionName = "" },
                new MenuModel { Id = Guid.NewGuid(), Title = "دستگاه‌ها", ControllerName = "", ActionName = "" }
                );
            #endregion
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<MenuModel>().ToTable("MenuModel");
            modelBuilder.Entity<Project>().ToTable("Project");
            base.OnModelCreating(modelBuilder);
        }
    }
}
