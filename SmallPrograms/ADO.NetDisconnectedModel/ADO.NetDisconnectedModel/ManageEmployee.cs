using System;
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
    public partial class ManageEmployee : Form
    {
        SqlConnection cn;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;

        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=psdb;Data Source=LAPTOP-JEM4G87I";
            cn = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from employees", cn);
            cmb = new SqlCommandBuilder(da);
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
                txtHireDate.Text = row["hiredate"].ToString();
            }
            else
            {
                MessageBox.Show("record does not exist...", "error");
                txtName.Clear();
                txtSalary.Clear();
                txtHireDate.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtEmpNum.Text);
            DataRow row;
            row = ds.Tables["employees"].Rows.Find(eno);
            row.BeginEdit();
            row["ename"] = txtName.Text;
            row["salary"] = txtSalary.Text;
            row.EndEdit();
            da.Update(ds.Tables["employees"]);
            MessageBox.Show("Employee record updated", "update");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete the record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int eno = int.Parse(txtEmpNum.Text);
                ds.Tables["employees"].Rows.Find(eno).Delete();
                da.Update(ds.Tables["employees"]);
                MessageBox.Show("Employee Record Removed...", "Delete");
                txtName.Clear();
                txtSalary.Clear();
                txtHireDate.Clear();
            }
        }
    }
}
