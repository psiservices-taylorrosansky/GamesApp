using GamesWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GamesWeb.Data;
using System;
using System.Linq;

namespace GamesWeb.Models
{
    public class SeedData
    {
        public static void Initilize(IServiceProvider serviceProvider)
        {
            using (var context = new GamesWebContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GamesWebContext>>()))
            {
                //Look for any Games
                if (context.Game.Any())
                {
                    return; //DB has been seeded. Yay!
                }
                context.Game.AddRange(
                    new Game
                    {
                        Name = "Skyrim",
                        ReleaseDate = DateTime.Parse("2011-11-11"),
                        Genre = "Open World RPG",
                        Developer = "Bethesda"
                    },
                    new Game
                    {
                        Name = "Elden Ring",
                        ReleaseDate = DateTime.Parse("2022-02-25"),
                        Genre = "Open World RPG",
                        Developer = "From Software"
                    },
                    new Game
                    {
                        Name = "Counter Strike: Global Offensive",
                        ReleaseDate = DateTime.Parse("2012-08-21"),
                        Genre = "FPS",
                        Developer = "From Software"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
