using Microsoft.EntityFrameworkCore;
using SurfBoardApi.Models;

namespace SurfBoardApi.Data
{
    public class SurfBoardContext : DbContext
    {
        public SurfBoardContext(DbContextOptions<SurfBoardContext> options) : base(options) { }

        public DbSet<Surfista> Surfistas { get; set; }
    }
}
