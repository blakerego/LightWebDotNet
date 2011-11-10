using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GigaFlashMVC.Models
{
    public class LightDB : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<ColorModel> Colors { get; set; }

        public DbSet<RoomModel> Rooms { get; set; } 
    }
}