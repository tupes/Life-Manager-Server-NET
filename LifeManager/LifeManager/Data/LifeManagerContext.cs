using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LifeManager.Models;

namespace LifeManager.Models
{
    public class LifeManagerContext : DbContext
    {
        public LifeManagerContext (DbContextOptions<LifeManagerContext> options)
            : base(options)
        {
        }

        public DbSet<LifeManager.Models.Employer> Employer { get; set; }

        public DbSet<LifeManager.Models.Responsibility> Responsibility { get; set; }

        public DbSet<LifeManager.Models.Skill> Skill { get; set; }

        public DbSet<LifeManager.Models.JobPosting> JobPosting { get; set; }

        public DbSet<LifeManager.Models.JobSite> JobSite { get; set; }

        public DbSet<LifeManager.Models.Job> Job { get; set; }
    }
}
