using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDemo1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string connString = DataLayer.DB.ConnectionString;
            DataLayer.DB.ApplicationName = "ASPDemo Application";
            DataLayer.DB.ConnectionTimeout = 30;

            SqlConnection conn = DataLayer.DB.GetSqlConnection();
        }

        protected void linkGO_Click(object sender, EventArgs e)
        {
            DataLayer.Employees es = new DataLayer.Employees();
            DataLayer.Employee employee = es.GetEmployee(int.Parse(txtEID.Text));

            TxtFName.Text = employee.FirstName;
            txtLName.Text = employee.LastName;
            txtDept.Text = employee.DepartmentName;
        }
    }
}