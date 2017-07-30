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

namespace DataRelations
{
    public partial class dataRelations : Form
    {
        SqlConnection cn;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        DataSet ds;

        public dataRelations()
        {
            InitializeComponent();
        }

        private void dataRelations_Load(object sender, EventArgs e)
        {

            // string cs = "Integrated Security=SSPI; Persist Security Info=False;Initial Catalog = Northwind1; Data Source=LAPTOP-JEM4G87I";
            string cs = "Data Source=LAPTOP-JEM4G87I;Initial Catalog=NORTHWND1;Integrated Security=True";
             cn = new SqlConnection(cs);
            da1 = new SqlDataAdapter("select * from categories", cn);
            da2 = new SqlDataAdapter("select * from products", cn);

            //fill the dataset with the data present within categories and products tables.
            ds = new DataSet();
            da1.Fill(ds, "categories");
            da2.Fill(ds, "products");

            //add a PRIMARY KEY constraints on the CategoryID column of the categories table present within the Dataset.
            ds.Tables["categories"].Constraints.Add("CategoryID_PK", ds.Tables["categories"].Columns["CategoryID"], true);

            //establish the relationship between the categories and the products tables considering the categories as the parent and products as the child.
            ds.Relations.Add("Categories_Products", ds.Tables["categories"].Columns["CategoryID"], ds.Tables["products"].Columns["CategoryID"]);

            //assigned the categories table as a source of data for the DataGridView control
            dataGridView1.DataSource = ds.Tables["categories"];

            //user defined method which accepts the row index of the parent and projects the relevent products on the DataGridView control.
            LoadChildData(0);
        }

        private void LoadChildData(int rowIndex)
        {
            var parentRow = ds.Tables["categories"].Rows[rowIndex];
            var childRows = parentRow.GetChildRows("Categories_Products");
            DataTable childTable = ds.Tables["products"].Clone();
            foreach (var row in childRows)
            {
                childTable.ImportRow(row);
            }
            dataGridView2.DataSource = childTable;
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            LoadChildData(dataGridView1.CurrentRow.Index);
        }
    }
}
