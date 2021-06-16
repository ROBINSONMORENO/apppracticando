using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using apppracticando.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace apppracticando.Data
{
    public class ApppracticandoDbContext : IdentityDbContext
    {       
        public DbSet<Fail> Fails { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public ApppracticandoDbContext (DbContextOptions dco) : base(dco)
        {
        }
  
    }
}