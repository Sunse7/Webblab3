using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebbLab3.Data;
using WebbLab3.Models;

namespace WebbLab3.Pages.Movies
{
    public class SeedDataModel : PageModel
    {
        private readonly WebbLab3.Data.WebbLab3Context _context;

        public SeedDataModel(WebbLab3.Data.WebbLab3Context context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (!_context.Movie.Any())
            {
                _context.SeedDatabase();
            }

            return RedirectToPage("./Index");
        }
    }
}
