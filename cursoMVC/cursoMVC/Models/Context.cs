﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoMVC.Models
{
    // class 'context' herda uma classe do EntityF...
    public class Context : DbContext
    {
        // determina ao entity que existira uma categoria
        public DbSet<Categorias> Categorias { get; set; }

        //sobescreve metodo do Entity
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString:@"Data Source=DESKTOP-M10J657;Initial Catalog=DigitalInnovationOne;Integrated Security=True");
        }
    }
}
