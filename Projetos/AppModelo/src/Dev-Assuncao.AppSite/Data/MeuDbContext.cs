using Microsoft.EntityFrameworkCore;
using Dev_Assuncao.AppSite.Models;

namespace Dev_Assuncao.AppSite.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options)
            :base(options)
        {

        }


        public DbSet<Aluno> Alunos { get; set; }
    }
}
