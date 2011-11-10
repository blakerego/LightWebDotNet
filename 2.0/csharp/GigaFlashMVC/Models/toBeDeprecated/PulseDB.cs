using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GigaFlashMVC.Models
{
    public class PulseDB : DbContext
    {
        public DbSet<PulseSetting> PulseSettings { get; set; }


        protected override void OnModelCreating(System.Data.Entity.ModelConfiguration.ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}