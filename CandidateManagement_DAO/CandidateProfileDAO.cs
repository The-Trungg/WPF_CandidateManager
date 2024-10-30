using CandidateManagement_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_DAO
{
    public class CandidateProfileDAO
    {
        private static CandidateProfileDAO instance;
        private GenericDAO<CandidateProfile> candidateProfileDAO;
        public CandidateProfileDAO()
        {
            candidateProfileDAO = new GenericDAO<CandidateProfile>(new CandidateManagementContext());
        }

        public static CandidateProfileDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;
            }

        }

        public CandidateProfile GetCandidateProfileById(String id)
        {
            return candidateProfileDAO.GetById(id);
        }

        public List<CandidateProfile> GetCandidateProfiles()
        {
            return candidateProfileDAO.GetAll();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool isSuccess = false;
            CandidateProfile candidate = this.GetCandidateProfileById(candidateProfile.CandidateId);

            try
            {
                if (candidate == null)
                {
                    candidateProfileDAO.Add(candidateProfile);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool DeleteCandidateProfile(string profileId)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(profileId);
            try
            {
                if (candidateProfile != null)
                {
                    candidateProfileDAO.Delete(profileId);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool UpdateCandidateProfile(CandidateProfile candidate)
        {
            bool isSuccess = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(candidate.CandidateId);
            try
            {
                if (candidateProfile != null)
                {
                    candidateProfile.Fullname = candidate.Fullname;
                    candidateProfile.Birthday = candidate.Birthday;
                    candidateProfile.ProfileShortDescription = candidate.ProfileShortDescription;
                    candidateProfile.ProfileUrl = candidate.ProfileUrl;
                    candidateProfile.PostingId = candidate.PostingId;
                    candidateProfileDAO.Update(candidateProfile);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
    }
}
