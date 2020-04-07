using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebbLab3.Models;

namespace WebbLab3.Data
{
    public class WebbLab3Context : DbContext
    {
        public WebbLab3Context (DbContextOptions<WebbLab3Context> options)
            : base(options)
        {
        }

        public DbSet<WebbLab3.Models.Movie> Movie { get; set; }

        public void SeedDatabase()
        {
            Movie.AddRange(
                new Movie
                {
                    Title = "The Awesome Movie",
                    NumberOfSeats = 50,
                    MovieStartTime = new DateTime(2020, 04, 15, 17, 00, 00)
                },
                new Movie
                {
                    Title = "Lucky the Movie",
                    NumberOfSeats = 50,
                    MovieStartTime = new DateTime(2020, 04, 20, 19, 15, 00)
                },
                new Movie
                {
                    Title = "Azmodan Gone Wild",
                    NumberOfSeats = 50,
                    MovieStartTime = new DateTime(2020, 04, 22, 22, 30, 00)
                },
                new Movie
                {
                    Title = "Big Boii Adventures",
                    NumberOfSeats = 50,
                    MovieStartTime = new DateTime(2020, 04, 25, 15, 45, 00)
                });

            SaveChanges();
        }
    }
}
