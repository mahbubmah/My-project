using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentDeptWebFormApp.BLL;
using StudentDeptWebFormApp.DAL;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.UI
{
    public partial class DeptEntry : System.Web.UI.Page
    {
        private Dept aDept;
        private DeptEntryGateway aDeptEntryGateway;
        private DeptBLL aDeptBll;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeptSave_Click(object sender, EventArgs e)
        {
            aDept=new Dept(txtCode.Text,txtTitle.Text);
            aDeptBll=new DeptBLL();
            string msg = aDeptBll.AddDept(aDept);
            msgDeptSave.Text = msg;
        }
    }
}