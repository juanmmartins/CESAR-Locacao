﻿using AgendaSalas.Models;
using Microsoft.EntityFrameworkCore;


namespace AgendaSalas.Context
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public DbSet<Servico> Servico { get; set; }

        public DbSet<Equipamento> Equipamento { get; set; }

        public DbSet<Sala> Sala { get; set; }
    }
}
