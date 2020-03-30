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
    }
}
