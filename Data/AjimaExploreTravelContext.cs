using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AjimaExploreTravel.Models;

namespace AjimaExploreTravel.Data
{
    public class AjimaExploreTravelContext : DbContext
    {
        public AjimaExploreTravelContext (DbContextOptions<AjimaExploreTravelContext> options)
            : base(options)
        {
        }

        public DbSet<AjimaExploreTravel.Models.Travel> Travel { get; set; }
    }
}
