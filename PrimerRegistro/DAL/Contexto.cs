using Microsoft.EntityFrameworkCore;
using PrimerRegistro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerRegistro.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Errores> errores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source = ErroresDB1.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
