using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystemApp.UI;

namespace VotingSystemApp
{
    public partial class AdminUI : Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void btnEnterNoOfWinners_Click(object sender, EventArgs e)
        {
            NoOfWinnersUI aNoOfWinnersUi=new NoOfWinnersUI();
            aNoOfWinnersUi.ShowDialog();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            CandidateEntryUI aCandidateEntryUi = new CandidateEntryUI();
            aCandidateEntryUi.ShowDialog();
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            ResultOfVotingUI aResultOfVotingUi=new ResultOfVotingUI();
            aResultOfVotingUi.ShowDialog();
        }
    }
}
