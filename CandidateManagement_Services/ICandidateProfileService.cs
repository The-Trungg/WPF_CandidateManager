﻿using CandidateManagement_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Services
{
    public interface ICandidateProfileService
    {
        public CandidateProfile GetCandidateProfileById(String id);
        public List<CandidateProfile> GetCandidateProfiles();
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool DeleteCandidateProfile(string profileId);
        public bool UpdateCandidateProfile(CandidateProfile candidate);
    }
}
