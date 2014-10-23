using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystemApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminUI aAdminUi=new AdminUI();
            aAdminUi.Show();
        }

        private void btnVoter_Click(object sender, EventArgs e)
        {
            VoteCastUI aVoteCastUi=new VoteCastUI();
            aVoteCastUi.Show();
        }

       
    }
}
