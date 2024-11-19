using Microsoft.EntityFrameworkCore;

namespace InternshipTestDB.Models
{
    public class ProdutoClassContext : DbContext
    {
        public ProdutoClassContext(DbContextOptions<ProdutoClassContext> options) : base(options)
        {
                        
        }
        public DbSet<ProdutoClass> Produtos { get; set; }
    }
}
