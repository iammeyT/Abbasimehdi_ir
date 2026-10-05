using Abbasimehdi_ir.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Abbasimehdi_ir.Context
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {

        }
        public DbSet<PortfolioCategory> PortfolioCategories { get; set; }
    }
}
