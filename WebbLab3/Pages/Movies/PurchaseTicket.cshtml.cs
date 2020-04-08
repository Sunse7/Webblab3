using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebbLab3.Data;
using WebbLab3.Models;

namespace WebbLab3.Pages.Movies
{
    public class PurchaseTicketModel : PageModel
    {
        private readonly WebbLab3.Data.WebbLab3Context _context;

        public PurchaseTicketModel(WebbLab3.Data.WebbLab3Context context)
        {
            _context = context;
        }
        public Movie Movie { get; set; }
        
        [BindProperty]
        [Range(1, 12)]
        public int TicketAmount { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task <IActionResult> OnPostPurchaseTicket(int? id)
        {
            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            try
            {
                if (Movie == null)
                {
                    return NotFound();
                }
                else if (Movie.NumberOfSeats - TicketAmount < 0)
                {
                    return RedirectToPage("./Index");                    
                }
                else
                {
                    Movie.NumberOfSeats -= TicketAmount;
                }

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(Movie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./BookingSummary", new {id = Movie.ID, numberOfTicketsPurchased = TicketAmount });
        }
        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }
    }
}
