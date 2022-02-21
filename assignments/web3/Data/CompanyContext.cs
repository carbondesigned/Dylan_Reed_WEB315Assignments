using Microsoft.EntityFrameworkCore;
using web3.Models;

namespace web3.Data
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Company { get; set; }
    }
}