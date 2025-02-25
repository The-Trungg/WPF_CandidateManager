﻿using CandidateManagement_BusinessObjects;
using CandidateManagement_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Repository
{
    public class JobPostingRepo : IJobPostingRepo
    {
        public JobPosting GetJobPostingByID(string jobID) => JobPostingDAO.Instance.GetJobPostingByID(jobID);

        public List<JobPosting> GetJobPostings() => JobPostingDAO.Instance.GetJobPostings();
    }
}
