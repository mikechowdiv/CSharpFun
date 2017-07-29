﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NetDisconnectedModel
{
    public partial class SearchEmployee : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;

        public SearchEmployee()
        {
            InitializeComponent();
        }

        private void SearchEmployee_Load(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=psdb;Data Source=LAPTOP-JEM4G87I";
            cn = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from employees", cn);
            ds = new DataSet();
            da.Fill(ds, "employees");
            ds.Tables["employees"].Constraints.Add("Empno_PK", ds.Tables["employees"].Columns["empno"], true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empno = int.Parse(txtEmpNum.Text);
            if (ds.Tables["employees"].Rows.Contains(empno) == true)
            {
                DataRow row;
                row = ds.Tables["employees"].Rows.Find(empno);
                txtName.Text = row["ename"].ToString();
                txtSalary.Text = row["salary"].ToString();
                txtHiredate.Text = row["hiredate"].ToString();
            }
            else
            {
                MessageBox.Show("record does not exist...", "error");
                txtName.Clear();
                txtSalary.Clear();
                txtHiredate.Clear();
            }
        }
    }
}
