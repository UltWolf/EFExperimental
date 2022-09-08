using EFExperimental.TestData;
using Microsoft.EntityFrameworkCore;

namespace EFExperimental.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TestChild> TestChildren{ get; set; }
        public DbSet<TestParent> TestParent{ get; set; }
        public DbSet<TestMTM1> TestMTM1 { get; set; }
        public DbSet<TestMTM2> TestMTM2 { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
       : base(options)
        {
        }

    }
}
