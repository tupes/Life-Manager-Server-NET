using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeManager.Models
{
    public class JobPosting
    {

        public int Id { get; set; }

        public int JobId { get; set; }
        public int JobSiteId { get; set; }

        public string Url { get; set; }
        public string Text { get; set; }

    }
}
