using Microsoft.EntityFrameworkCore;

namespace DitaliaAPI.Model.Context
{
    public class MySqlContext:DbContext
    {
        public MySqlContext()
        {


        }
        public MySqlContext(DbContextOptions<MySqlContext> options): base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<User> Users{ get; set; }
    }
}
