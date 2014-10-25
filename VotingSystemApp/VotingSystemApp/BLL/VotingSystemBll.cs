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

        public string CastVote(Voter aVoter,Candidate aCandidate)
        {
            aAdminGateway=new AdminGateway();
            
            if (HasThisVoterOnTheVoterList(aVoter))
            {
                int i = aAdminGateway.GetNoOfWinner();
                int j = aAdminGateway.GetNoOfVoteCasted(aVoter.Email);
                if (j < i)
                {
                    return aAdminGateway.CastVote(aVoter,aCandidate);
                }
                return "You already cast your maximum no of vote";
            }
            return "Voter does not exist in the system";

        }

        private bool HasThisVoterOnTheVoterList(Voter aVoter)
        {
            aAdminGateway=new AdminGateway();
            bool i=aAdminGateway.HasThisVoterOnTheList(aVoter);
            if (i)
            {
                return true;
            }
            return false;
        }

        public List<Candidate> GetAllCandidate()
        {
           aAdminGateway=new AdminGateway();
           return aAdminGateway.GetAllCandidate();
        }

        public List<ResultBll> GetResult()
        {
            aAdminGateway = new AdminGateway();
            return aAdminGateway.GetResult();
        }

        public bool IsCandiateSymbolExistInDatabase(Candidate aCandidate, List<Candidate> getAllCandidate)
        {
            foreach (Candidate candidate in getAllCandidate)
            {
                if (candidate == aCandidate)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
