using CandidateManagement_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Services
{
    public interface IJobPostingService
    {
        public JobPosting GetJobPostingByID(String jobID);
        public List<JobPosting> GetJobPostings();
    }
}
