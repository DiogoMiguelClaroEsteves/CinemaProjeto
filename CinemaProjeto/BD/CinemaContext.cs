﻿using System;
using System.Collections.Generic;
using System.Data.Entity; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    class CinemaContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Bilhete> Bilhetes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
    }
}
