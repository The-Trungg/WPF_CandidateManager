using CandidateManagement_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_DAO
{

    public class JobPostingDAO
    {
        private static JobPostingDAO instance;
        private GenericDAO<JobPosting> jobPostingDAO;

        public static JobPostingDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                return instance;
            }
        }
        public JobPostingDAO()
        {
            jobPostingDAO = new GenericDAO<JobPosting> (new CandidateManagementContext());
        }

        public JobPosting GetJobPostingByID(String  jobID)
        {
            return jobPostingDAO.GetById (jobID);
        }
        public List<JobPosting> GetJobPostings()
        {
            return jobPostingDAO.GetAll();
        }
    }
}
