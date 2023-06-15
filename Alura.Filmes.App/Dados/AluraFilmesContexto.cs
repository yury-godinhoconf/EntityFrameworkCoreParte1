﻿using Alura.Desafio.App.Negocio;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Filmes.App.Dados
{
    public class AluraFilmesContexto : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<FilmeAtor> Elenco{ get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmesTST;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeConfiguration());

            modelBuilder.ApplyConfiguration(new CategoriaConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeCategoriaConfiguration());

            modelBuilder.ApplyConfiguration(new FilmeAtorConfiguration());

            modelBuilder.ApplyConfiguration(new PersonagemConfiguration());

            modelBuilder.ApplyConfiguration(new IdiomaConfiguration());
        }
    }
}
