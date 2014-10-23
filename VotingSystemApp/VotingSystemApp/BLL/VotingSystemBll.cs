using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DLL.DAO;
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp.BLL
{
    
    class VotingSystemBll
    {
        private AdminGateway aAdminGateway;

        public string SaveCandidate(Candidate aCandidate)
        {
            aAdminGateway=new AdminGateway();
            return aAdminGateway.SaveCandidate(aCandidate);
        }

        public string SaveNoOfWinners(int noOfWinners)
        {
            aAdminGateway=new AdminGateway();
            return aAdminGateway.SaveNoOfWinners(noOfWinners);
        }

        public string CastVote(Voter aVoter)
        {
            aAdminGateway=new AdminGateway();
            return aAdminGateway.CastVote(aVoter);
        }

        public List<Candidate> GetAllCandidate()
        {
           aAdminGateway=new AdminGateway();
           return aAdminGateway.GetAllCandidate();
        }
    }
}
