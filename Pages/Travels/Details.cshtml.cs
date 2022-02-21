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
    public class DetailsModel : PageModel
    {
        private readonly AjimaExploreTravel.Data.AjimaExploreTravelContext _context;

        public DetailsModel(AjimaExploreTravel.Data.AjimaExploreTravelContext context)
        {
            _context = context;
        }

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
    }
}
