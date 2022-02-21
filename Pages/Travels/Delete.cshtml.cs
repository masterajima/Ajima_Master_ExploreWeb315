using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AjimaExploreTravel.Data;
using AjimaExploreTravel.Models;

namespace AjimaExploreTravel.Pages.Travels
{
    public class DeleteModel : PageModel
    {
        private readonly AjimaExploreTravel.Data.AjimaExploreTravelContext _context;

        public DeleteModel(AjimaExploreTravel.Data.AjimaExploreTravelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Travel Travel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Travel = await _context.Travel.FirstOrDefaultAsync(m => m.ID == id);

            if (Travel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Travel = await _context.Travel.FindAsync(id);

            if (Travel != null)
            {
                _context.Travel.Remove(Travel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
