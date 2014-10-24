using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.DLL.DAO;
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp.BLL
{
    class ResultBll:Candidate
    {
        AdminGateway aAdminGateway=new AdminGateway();
        public string Result { get; set; }
        string loser = "Looser";
        string winner = "Winner";

        public string GetResult(int vote,int noOfWinners,int count)
        {
            if (count <= noOfWinners)
            {
                return winner;
            }
            return loser;
        }


    }
}
