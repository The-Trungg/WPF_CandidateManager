﻿using CandidateManagement_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Repository
{
    public interface IJobPostingRepo
    {
        public JobPosting GetJobPostingByID(String jobID);
        public List<JobPosting> GetJobPostings();
    }
}
