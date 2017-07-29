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
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //connection object is defined to establish the physical connection to the db.
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=psdb;Data Source=LAPTOP-JEM4G87I";
            SqlConnection cn = new SqlConnection(cs);

            //dataAdapter is defined to interact with the employee's table
            SqlDataAdapter da = new SqlDataAdapter("Select * from Employees", cn);

            //commendBuilder object generated the commands for the DataAdapter object
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);

            //we defined the dataset and filled the data to the dataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            //add a primery key constraint on the data column
            ds.Tables[0].Constraints.Add("Empno_PK", ds.Tables[0].Columns[0], true);

            //adding record - define the DataRow variable, assign the new rows of the DataTable, provide the values for the columns.
            //Once done, add the DataRow variable to the Rows collection, and finally update the DataAdapter

            //in order to add a record, we defined our DataRow
            DataRow row;
            //we assign a new row of the DataTable, provided the values to the DataColumns and added the row to the DataTable
            row = ds.Tables[0].NewRow();
            row["Empno"] = txtEmpno.Text;
            row["Ename"] = txtEname.Text;
            row["Salary"] = txtSalary.Text;
            row["Hiredate"] = dtpHireDate.Value;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Employee Record Added.", this.Text);


        }
    }
}
