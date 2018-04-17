using Microsoft.EntityFrameworkCore;

namespace EmTechServer.Data
{
    public class EmTechDbContext : DbContext
    {
        public EmTechDbContext(DbContextOptions<EmTechDbContext> options) : base(options)
        {}
    }
}