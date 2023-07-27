﻿using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

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
           base.OnModelCreating(modelBuilder);
        }
    }
}
