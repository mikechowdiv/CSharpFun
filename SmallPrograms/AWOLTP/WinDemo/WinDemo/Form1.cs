using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connString = DataLayer.DB.ConnectionString;
            DataLayer.DB.ApplicationName = "WinDemo Application";
            DataLayer.DB.ConnectionTimeout = 30;

            SqlConnection conn = DataLayer.DB.GetSqlConnection();
            
        }

        private void btnGetEmp_Click(object sender, EventArgs e)
        {
            
                
                DataLayer.Employees es = new DataLayer.Employees();
                DataLayer.Employee employee = es.GetEmployee(int.Parse(txtEID.Text));

                txtFName.Text = employee.FirstName;
                txtLName.Text = employee.LastName;
                txtDeptName.Text = employee.DepartmentName;
      
        }
    }
}
