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


namespace VotingSystemApp.UI
{
    public partial class ResultOfVotingUI : Form
    {
        public ResultOfVotingUI()
        {
            VotingSystemBll aVotingSystemBll=new VotingSystemBll();
            InitializeComponent();
            List<ResultBll> aResultBll=new List<ResultBll>();
            aResultBll = aVotingSystemBll.GetResult();
            gridResult.DataSource =aResultBll;
            
        }
    }
}
