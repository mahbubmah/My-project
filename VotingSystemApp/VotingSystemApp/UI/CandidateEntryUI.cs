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
using VotingSystemApp.DLL.Gateway;

namespace VotingSystemApp
{
    public partial class CandidateEntryUI : Form
    {
        private VotingSystemBll aVotingSystemBll;
        private Candidate aCandidate;
        public CandidateEntryUI()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            aVotingSystemBll=new VotingSystemBll();
            aCandidate = new Candidate();
            aCandidate.Symbol = txtSymbol.Text;
            aCandidate.Name = txtCandidateName.Text;
            string msg=aVotingSystemBll.SaveCandidate(aCandidate);
            MessageBox.Show(msg);
        }

        

       
    }
}
