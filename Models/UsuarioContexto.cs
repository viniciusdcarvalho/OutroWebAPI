using Microsoft.EntityFrameworkCore;

namespace WebApiOutro.Models
{
    public class UsuarioContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public UsuarioContexto(DbContextOptions options) : base(options)
        {

        }
        
    }
}