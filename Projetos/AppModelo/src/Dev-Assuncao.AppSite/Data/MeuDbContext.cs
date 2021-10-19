using Microsoft.EntityFrameworkCore;

namespace Dev_Assuncao.AppSite.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
            :base(options)
        {

        }

    }
}
