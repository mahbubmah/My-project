using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using StudentDeptWebFormApp.BLL;
using StudentDeptWebFormApp.DAL;
using StudentDeptWebFormApp.Models;

namespace StudentDeptWebFormApp.UI
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        private DeptBLL aDeptBll;
        private Dept aDept;
        private Student aStudent;
        private StudentBLL aStudentBll;
        private StudentEntryGateway aStudentEntryGateway;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                aStudentEntryGateway=new StudentEntryGateway();
                labMsgStudent.Text = string.Empty;
                GetAllDeptInDropDown();
                GetAllStudntInDropDown();
                
            }
        }

        private void GetAllStudntInDropDown()
        {
            aStudentBll=new StudentBLL();
            List<Student> aStudents = aStudentBll.GetAllStudentBll();

            dropDownStudentReg.DataSource = aStudents;
            dropDownStudentReg.DataTextField = "RegNo";
            dropDownStudentReg.DataValueField = "Id";
            dropDownStudentReg.DataBind();

        }

        private void GetAllDeptInDropDown()
        {
            aDeptBll=new DeptBLL();
            List<Dept> aDepts = aDeptBll.GetAllDeptsBll();

            dropDownDept.DataSource = aDepts;
            dropDownDept.DataTextField = "Title";
            dropDownDept.DataValueField = "Id";
            dropDownDept.DataBind();
        }
       

        protected void Button2_Click(object sender, EventArgs e)
        {
            aStudent=new Student(txtName.Text,txtEmail.Text,txtRegNo.Text);
            aStudentBll=new StudentBLL();
            string msg;
            try
            {
                msg = aStudentBll.InsertStudentBll(aStudent);
            }
            catch (Exception exception)
            {
                msg=exception.Message;
            }
            labMsgStudent.Text = msg;

            txtEmail.Text = string.Empty;
            txtName.Text = string.Empty;
            txtRegNo.Text = string.Empty;
        }

        protected void btnSearchStudent_Click(object sender, EventArgs e)
        {
            string msg=string.Empty;
            try
            {
                aStudentBll = new StudentBLL();
                aStudent=new Student();
                string regNo = dropDownStudentReg.SelectedItem.Text;
                aStudent = aStudentBll.GetStudentByRegNo(regNo);

                txtName.Text = aStudent.Name;
                txtEmail.Text = aStudent.Email;
                txtRegNo.Text = aStudent.RegNo;
                
                
            }
            catch (Exception exception)
            {
                msg=exception.Message;
                labMsgStudent.Text = msg;
            }
            

        }

        protected void btnEnrollStudent_Click(object sender, EventArgs e)
        {
            aStudent=new Student();
            aStudent.Id=Convert.ToInt32(dropDownStudentReg.SelectedItem.Value);
            
        }

       
    }
}