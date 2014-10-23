using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
                aCandidate.NoOfVote = 0;
                connection.Open();
                string query = string.Format("INSERT INTO t_Candidate VALUES ('{0}','{1}',{2})",aCandidate.Symbol,aCandidate.Name,aCandidate.NoOfVote);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return "Candidate Added";
            }
            catch (Exception exception)
            {

                return "Symbol already exist in the system try another";
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

        public string CastVote(Voter aVoter)
        {
            try
            {
                connection.Open();
                aVoter.NoOfVoteCasted = GetNoOfVoteCasted(aVoter.Email);
                string query = string.Format("UPDATE t_Voter SET NoOfCastedVote=({0}) WHERE Email=('{1}')", aVoter.NoOfVoteCasted + 1, aVoter.Email);
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                return "Vote Case Successful";
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
            
        }

        private int GetNoOfVoteCasted(string email)
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
                    i = (int)aReader[1];
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
                    aCandidate.Symbol = aReader[0].ToString();
                    aCandidate.Name = aReader[1].ToString();
                    aCandidate.NoOfVote = (int) aReader[2];
                    aListCandidate.Add(aCandidate);
                }
            }
            connection.Close();
            return aListCandidate;
        }
    }
}
