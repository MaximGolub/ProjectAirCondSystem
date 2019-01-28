using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AirCondSystem.Models
{
    public class AirCondContext : DbContext
    {
        public DbSet<Wall> Walls { get; set; }
        public DbSet<Window> Windows { get; set; }
        public DbSet<Door> Doors { get; set; }
    }

    public class Wall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }

    public class Window
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }

    public class Door
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
    }
}