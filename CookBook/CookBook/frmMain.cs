using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookBook
{
    public partial class frmMain : Form
    {
        SqlConnection connection;

        string connectionString;

        public frmMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CookBook.Properties.Settings.CookbookConnectionString"].ConnectionString;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {             
                DataTable reciptTable = new DataTable();
                adaptor.Fill(reciptTable);

                listRecipes.DisplayMember = "Name";
                listRecipes.ValueMember = "Id";
                listRecipes.DataSource = reciptTable;
            }         
        }

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listRecipes.SelectedValue.ToString());
        }
    }
}
