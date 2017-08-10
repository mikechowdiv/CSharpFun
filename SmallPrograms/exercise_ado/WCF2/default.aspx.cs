using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCF2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = "data source=.; database = Sample; integrated security=SSPI";

            using (SqlConnection conn = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblProduct", conn);
                conn.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }


            //    SqlConnection conn = new SqlConnection(CS);
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("Select * from tblProduct", conn);
            //    conn.Open();
            //    GridView1.DataSource = cmd.ExecuteReader();
            //    GridView1.DataBind();
            //}
            //catch
            //{

            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}