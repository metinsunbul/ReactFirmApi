using Microsoft.EntityFrameworkCore;
using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public class FirmDbContext : DbContext
    {
        public FirmDbContext(DbContextOptions<FirmDbContext> options) : base(options)
        {
            

        }
        
        public DbSet<FirmModel> Firms { get; set; }
        public DbSet<PersonelModel> Personels { get; set; }


        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            seedData(builder);

            base.OnModelCreating(builder);
        }

        private void seedData(ModelBuilder builder)
        {
            builder.Entity<PersonelModel>().HasData(
                    new PersonelModel { Name = "mehmet", personelId=-2, FirmId = -1,  Surname = "sunbul", Phone = "0312945" },
                    new PersonelModel { Name = "mehmet2", personelId = -1, FirmId = -1, Surname = "sunbul2", Phone = "03129342" }
                );

            builder.Entity<FirmModel>().HasData(
                        new FirmModel
                        { Name = "Subilgi", FirmId=-2, Address = "ankara", Authority = "mehmet", Title = "Subilgi", FirmPerformansScore = 90, GasOpenningPercentage = 60, HaveAuthority = true, Phone = "0312987454", Email = "mehmet@subilgi.com" },
                        new FirmModel
                        { Name = "Subilgi2", FirmId = -1, Address = "ankara", Authority = "mehmet2", Title = "Subilgi2", FirmPerformansScore = 30, GasOpenningPercentage = 50, HaveAuthority = true, Phone = "0312987454", Email = "mehmet@subilgi.com" }
                    );
        }
    }
}
