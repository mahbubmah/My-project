using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingSystemApp.BLL;
using VotingSystemApp.DLL.DAO;

namespace VotingSystemApp.DLL.Gateway
{
    
    class AdminGateway
    {
        private SqlConnection connection;

        public AdminGateway()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }

        public String SaveCandidate(Candidate aCandidate)
        {
            try
            {
                VotingSystemBll aVotingSystemBll=new VotingSystemBll();
                aCandidate.NoOfVote = 0;
                bool a = aVotingSystemBll.IsCandiateSymbolExistInDatabase(aCandidate, GetAllCandidate());
                if (a)
                {
                    return "Symbol already exist in the system try another";
                }
                connection.Open();
                string query = string.Format("INSERT INTO t_Candidate VALUES ('{0}','{1}',{2})",aCandidate.Symbol,aCandidate.Name,aCandidate.NoOfVote);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return "Candidate Added";
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

        }

        public string SaveNoOfWinners(int noOfWinners)
        {
            try
            {
                connection.Open();
                string query = string.Format("UPDATE t_NoOfWinners SET NoOfWinners=({0})", noOfWinners);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return "No of winner set successful";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string CastVote(Voter aVoter,Candidate aCandidate)
        {
            try
            {
                aVoter.NoOfVoteCasted = GetNoOfVoteCasted(aVoter.Email);
                connection.Open();
                string query = string.Format("UPDATE t_Voter SET NoOfCastedVote={0} WHERE Email='{1}'", aVoter.NoOfVoteCasted + 1, aVoter.Email);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                string aquery = string.Format("UPDATE t_Candidate SET Vote={0} WHERE Symbol='{1}'", aCandidate.NoOfVote+1,aCandidate.Symbol);
                SqlCommand acmd = new SqlCommand(aquery, connection);
                acmd.ExecuteNonQuery();
                connection.Close();
                return "Vote Cast Successful";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            
        }

        public int GetNoOfVoteCasted(string email)
        {
            int i=0;
            connection.Open();
            string query = string.Format("SELECT * FROM t_Voter WHERE Email=('{0}')", email);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            bool HasRow = aReader.HasRows;
            if (HasRow)
            {
                while (aReader.Read())
                {
                    i = (int)aReader[2];
                }
            }
            connection.Close();

            return i;
        }

        public List<Candidate> GetAllCandidate()
        {
            Candidate aCandidate;
            connection.Open();
            string qurey = string.Format("SELECT * FROM t_Candidate");
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            List<Candidate> aListCandidate = new List<Candidate>();
            bool HasRow = aReader.HasRows;
            if (HasRow)
            {
                while (aReader.Read())
                {
                    aCandidate=new Candidate();
                    aCandidate.Symbol = aReader[1].ToString();
                    aCandidate.Name = aReader[2].ToString();
                    aCandidate.NoOfVote = (int) aReader[3];
                    aListCandidate.Add(aCandidate);
                }
            }
            connection.Close();
            return aListCandidate;
        }

        public int GetNoOfWinner()
        {
                connection.Open();
                string query = string.Format("select * from t_NoOfWinners");
                SqlCommand cmd = new SqlCommand(query, connection);
                int i=(int) cmd.ExecuteScalar();
                connection.Close();
                return i ;
            
        }

        public bool HasThisVoterOnTheList(Voter aVoter)
        {
            
            connection.Open();
            string query = string.Format("SELECT * FROM t_Voter WHERE Email=('{0}')", aVoter.Email);
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            bool HasRow = aReader.HasRows;
            connection.Close();
            if (HasRow)
            {
                return true;
            }
            

            return false;
        }

        public List<ResultBll> GetResult()
        {
            ResultBll aResultBll;
            int count = 0;
            int j = GetNoOfWinner();
            connection.Open();
            string qurey = string.Format("SELECT * FROM t_Candidate ORDER BY Vote DESC");
            SqlCommand cmd = new SqlCommand(qurey, connection);
            SqlDataReader aReader = cmd.ExecuteReader();
            List<ResultBll> aListResult = new List<ResultBll>();
            bool HasRow = aReader.HasRows;
            if (HasRow)
            {
                while (aReader.Read())
                {
                    count++;
                    aResultBll = new ResultBll();
                    aResultBll.Symbol = aReader[1].ToString();
                    aResultBll.Name = aReader[2].ToString();
                    aResultBll.Result=aResultBll.GetResult((int) aReader[3],j,count);
                    aResultBll.NoOfVote = (int)aReader[3];
                    aListResult.Add(aResultBll);
                }
            }
            connection.Close();
            return aListResult;
        }
    }
}
