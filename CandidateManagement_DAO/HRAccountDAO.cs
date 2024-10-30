using CandidateManagement_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_DAO
{
    public class HRAccountDAO
    {
        //private CandidateManagementContext dbContext;
        private GenericDAO<Hraccount> hrAccountDAO;
        private static HRAccountDAO instance = null;

        public static HRAccountDAO Instance
        {
            //Singleton Design Pattern
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }

        public HRAccountDAO()
        {
            hrAccountDAO = new GenericDAO<Hraccount>(new CandidateManagementContext());
        }

        public Hraccount GetHraccountByEmail(String email)
        {
            return hrAccountDAO.GetById(email);
        }

        public List<Hraccount> GetHraccounts()
        {
            return hrAccountDAO.GetAll();
        }
    }
}
