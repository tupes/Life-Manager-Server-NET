using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeManager.Models
{
    public class Job
    {

        public int Id { get; set; }

        public int EmployerId { get; set; }


        public string Title { get; set; }

        public List<Responsibility> Responsibilities { get; set; }
        public List<Skill> Skills { get; set; }

        public List<JobPosting> JobPostings { get; set; }

    }
}
