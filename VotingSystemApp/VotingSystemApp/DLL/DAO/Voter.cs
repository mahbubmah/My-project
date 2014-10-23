using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DLL.DAO
{
    class Voter
    {
        public string Email { get; set; }
        public int NoOfVoteCasted { get; set; }

        public Voter(string email)
        {
            Email = email;
        }
    }
}
