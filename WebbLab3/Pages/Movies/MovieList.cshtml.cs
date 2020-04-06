using System;
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
    public class MovieListModel : PageModel
    {
        private readonly WebbLab3.Data.WebbLab3Context _context;

        public MovieListModel(WebbLab3.Data.WebbLab3Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
