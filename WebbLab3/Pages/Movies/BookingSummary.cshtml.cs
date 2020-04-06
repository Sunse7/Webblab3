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
    public class BookingSummaryModel : PageModel
    {
        private readonly WebbLab3.Data.WebbLab3Context _context;

        public BookingSummaryModel(WebbLab3.Data.WebbLab3Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }
        public int NumberOfTicketsPurchased { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, int numberOfTicketsPurchased)
        {
            if (id == null)
            {
                return NotFound();
            }

            NumberOfTicketsPurchased = numberOfTicketsPurchased;
            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
