using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AjimaExploreTravel.Data;
using AjimaExploreTravel.Models;

namespace AjimaExploreTravel.Pages.Travels
{
    public class EditModel : PageModel
    {
        private readonly AjimaExploreTravel.Data.AjimaExploreTravelContext _context;

        public EditModel(AjimaExploreTravel.Data.AjimaExploreTravelContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Travel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelExists(Travel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TravelExists(int id)
        {
            return _context.Travel.Any(e => e.ID == id);
        }
    }
}
