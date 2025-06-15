using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace AgenciaTurismo.Data
{
    public class AgenciaTurismoContextFactory : IDesignTimeDbContextFactory<AgenciaTurismoContext>
    {
        public AgenciaTurismoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AgenciaTurismoContext>();
            optionsBuilder.UseSqlite("Data Source=AgenciaTurismo.db");

            return new AgenciaTurismoContext(optionsBuilder.Options);
        }
    }
}