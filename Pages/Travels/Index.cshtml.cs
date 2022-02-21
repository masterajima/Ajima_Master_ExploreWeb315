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
    public class IndexModel : PageModel
    {
        private readonly AjimaExploreTravel.Data.AjimaExploreTravelContext _context;

        public IndexModel(AjimaExploreTravel.Data.AjimaExploreTravelContext context)
        {
            _context = context;
        }

        public IList<Travel> Travel { get;set; }

        public async Task OnGetAsync()
        {
            Travel = await _context.Travel.ToListAsync();
        }
    }
}
