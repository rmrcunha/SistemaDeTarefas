﻿using Microsoft.EntityFrameworkCore;
using Tarefas.Data.Map;
using Tarefas.Models;

namespace Tarefas.Data
{
    public class TarefasDbContext : DbContext
    {
        public TarefasDbContext(DbContextOptions<TarefasDbContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
