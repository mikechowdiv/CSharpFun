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
    public partial class ShowEmployees : Form
    {
        public ShowEmployees()
        {
            InitializeComponent();
        }

        private void ShowEmployees_Load(object sender, EventArgs e)
        {
            string cs = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=psdb;Data Source=LAPTOP-JEM4G87I";
            SqlConnection cn = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("select * from Employees", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
