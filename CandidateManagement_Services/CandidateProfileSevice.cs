using CandidateManagement_BusinessObjects;
using CandidateManagement_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Services
{
    public class CandidateProfileSevice : ICandidateProfileService
    {
        private ICandidateProfileRepo profileRepo;
        public CandidateProfileSevice()
        {
            profileRepo = new CandidateProfileRepo();
        }
        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            candidateProfile.CandidateId = GetId();
            return profileRepo.AddCandidateProfile(candidateProfile);
        }

        public bool DeleteCandidateProfile(string profileId)
        {
            return profileRepo.DeleteCandidateProfile(profileId);
        }

        public CandidateProfile GetCandidateProfileById(string id)
        {
            return profileRepo.GetCandidateProfileById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return profileRepo.GetCandidateProfiles();
        }

        public bool UpdateCandidateProfile(CandidateProfile candidate)
        {
            return profileRepo.UpdateCandidateProfile(candidate);
        }

        public string GetId()
        {
            int count = profileRepo.GetCandidateProfiles().Count() + 1;
            string id = string.Format("CANDIDATE{0:D4}", count);
            return id;
        }
    }
}
