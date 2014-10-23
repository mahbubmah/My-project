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

namespace VotingSystemApp
{
    public partial class NoOfWinnersUI : Form
    {
        private VotingSystemBll aVotingSystemBll;
        public NoOfWinnersUI()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            aVotingSystemBll=new VotingSystemBll();
            int noOfWinners = Convert.ToInt32(txtNoOfWinners.Text);
            string msg=aVotingSystemBll.SaveNoOfWinners(noOfWinners);
            MessageBox.Show(msg);
        }

        
    }
}
