using CandidateManagement_BusinessObjects;
using CandidateManagement_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Services
{
    public class JobPostingService : IJobPostingService
    {
        private readonly IJobPostingRepo jobPostingRepo;  

        public JobPostingService()
        {
            jobPostingRepo = new JobPostingRepo();
        }

        public JobPosting GetJobPostingByID(string jobID)
        {
            return jobPostingRepo.GetJobPostingByID(jobID);
        }

        public List<JobPosting> GetJobPostings()
        {
            return jobPostingRepo.GetJobPostings();
        }
    }
}
