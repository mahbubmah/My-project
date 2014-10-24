using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingSystemApp.DLL.DAO
{
    class Candidate
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int NoOfVote { get; set; }

        public Candidate(string symbol, string name, int noOfVote):this()
        {
            Symbol = symbol;
            Name = name;
            NoOfVote = noOfVote;
        }



        public Candidate(string symbol, string name):this()
        {
            Symbol = symbol;
            Name = name;
        }

        public Candidate()
        {
        }

    }
}
