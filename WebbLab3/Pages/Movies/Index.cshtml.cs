﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebbLab3.Data;
using WebbLab3.Models;

namespace WebbLab3.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly WebbLab3.Data.WebbLab3Context _context;

        public IndexModel(WebbLab3.Data.WebbLab3Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync(string sortorder)
        {
            if (sortorder == "SeatsLeft")
            {
                Movie = await _context.Movie.OrderByDescending(m => m.NumberOfSeats).ToListAsync();
            }
            else if (sortorder == "StartTime")
            {
                Movie = await _context.Movie.OrderByDescending(m => m.MovieStartTime).ToListAsync();
            }
            else
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
