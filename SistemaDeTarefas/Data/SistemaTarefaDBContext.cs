using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models;
using System.Reflection;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefaDBContext: DbContext
    {
        public SistemaTarefaDBContext(DbContextOptions<SistemaTarefaDBContext> options)
            :base(options)
        {
            
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new UsuarioMap());
           modelBuilder.ApplyConfiguration(new TarefaMap());
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(SistemaTarefaDBContext).Assembly);

           base.OnModelCreating(modelBuilder);
        }
    }
}
