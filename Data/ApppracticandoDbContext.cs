using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using apppracticando.Models;
using System.ComponentModel.DataAnnotations;


namespace apppracticando.Data
{
    public class ApppracticandoDbContext : DbContext
    {       
        public DbSet<Fail> Fails { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public ApppracticandoDbContext (DbContextOptions dco) : base(dco)
        {
        }
  
    }
}