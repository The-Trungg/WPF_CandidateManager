using CandidateManagement_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_Repository
{
    public interface IHRAccountRepo
    {
        public Hraccount GetHraccountByEmail(String email);
        public List<Hraccount> GetHraccounts();


    }
}
