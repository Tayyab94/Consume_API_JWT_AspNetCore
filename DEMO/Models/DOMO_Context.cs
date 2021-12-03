using Microsoft.EntityFrameworkCore;

namespace DEMO.Models
{
    public class DOMO_Context:DbContext
    {

        public DOMO_Context(DbContextOptions<DOMO_Context> options):base(options)
        {
        }

        public DbSet<Hero> Heros { get; set; }

        public DbSet<HeroAcheivement>HeroAcheivements { get; set; }
    }
}
