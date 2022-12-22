﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Entity_Framework_Players
{
    public class PlayerContext : DbContext
    {
        public DbSet<Players> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PlayersDB;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}