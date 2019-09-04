using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LifeManager.Models
{
    public class LifeManagerContext : DbContext
    {
        public LifeManagerContext (DbContextOptions<LifeManagerContext> options)
            : base(options)
        {
        }

        public DbSet<LifeManager.Models.Employer> Employer { get; set; }
    }
}
