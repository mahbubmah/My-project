using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApp.BLL;
using VotingSystemApp.DLL.DAO;

namespace VotingSystemApp
{
    public partial class VoteCastUI : Form
    {
        VotingSystemBll aVotingSystemBll=new VotingSystemBll();
        public VoteCastUI()
        {
            InitializeComponent();
            GetCandidateInComboBox();
            comboCandidateList.DisplayMember = "Symbol";
            comboCandidateList.ValueMember = "Symbol";

        }

        private void GetCandidateInComboBox()
        {
            List<Candidate> aListCandidates=new List<Candidate>();
            aListCandidates = aVotingSystemBll.GetAllCandidate();
            foreach (Candidate candidate in aListCandidates)
            {
                comboCandidateList.Items.Add(candidate);
            }
            
        }


        private void btnCastVote_Click(object sender, EventArgs e)
        {
            Voter aVoter=new Voter(txtEmail.Text);
            Candidate aCandidate=new Candidate();
            
            

            aCandidate = (Candidate)comboCandidateList.SelectedItem;

            string msg=aVotingSystemBll.CastVote(aVoter, aCandidate);

            MessageBox.Show(msg);


        }
    }
}
