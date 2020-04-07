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
            var date = DateTime.Today;
            var time = DateTime.Now;

            Movie.AddRange(
                new Movie
                {
                    Title = "The Awesome Movie",
                    NumberOfSeats = 50,
                    MovieStartTime = date.Date + time.TimeOfDay
                },
                new Movie
                {
                    Title = "Lucky the Movie",
                    NumberOfSeats = 50,
                    MovieStartTime = date.Date + time.TimeOfDay
                },
                new Movie
                {
                    Title = "Azmodan Gone Wild",
                    NumberOfSeats = 50,
                    MovieStartTime = date.Date + time.TimeOfDay
                },
                new Movie
                {
                    Title = "Big Boii Adventures",
                    NumberOfSeats = 50,
                    MovieStartTime = date.Date + time.TimeOfDay
                });

            SaveChanges();
        }
    }
}
