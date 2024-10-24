using Lancamentos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lancamentos.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movimentacao> Movimentacao { get; set; }
    }
}
