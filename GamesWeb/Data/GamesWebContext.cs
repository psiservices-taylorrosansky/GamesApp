using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesWeb.Models;

namespace GamesWeb.Data
{
    public class GamesWebContext : DbContext
    {
        public GamesWebContext (DbContextOptions<GamesWebContext> options)
            : base(options)
        {
        }

        public DbSet<GamesWeb.Models.Game> Game { get; set; } = default!; //allows for CRUD operations on DB entities
    }
}
