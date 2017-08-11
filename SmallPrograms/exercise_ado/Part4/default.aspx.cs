using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part4
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select ProductId, Laptops, UnitPrice, Qty from tblProduct", conn);
                conn.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}