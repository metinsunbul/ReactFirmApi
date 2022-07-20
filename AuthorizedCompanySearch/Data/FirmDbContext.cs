using Microsoft.EntityFrameworkCore;
using AuthorizedCompanySearch.Models;

namespace AuthorizedCompanySearch.Data
{
    public class FirmDbContext : DbContext
    {
        public FirmDbContext(DbContextOptions<FirmDbContext> options) : base(options)
        {

        }

        public DbSet<FirmModel> FirmModels { get; set; }
        public DbSet<PersonelModel> PersonelModels { get; set; }

    }
}
