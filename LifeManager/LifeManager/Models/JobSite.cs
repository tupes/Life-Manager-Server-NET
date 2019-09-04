﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeManager.Models
{
    public class JobSite
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<JobPosting> JobPostings { get; set; }

    }
}
