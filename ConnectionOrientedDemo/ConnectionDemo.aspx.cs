using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using Oracle.ManagedDataAccess.Client;
namespace ConnectionOrientedDemo

/*
 * tnsping ORCL : Check the Service name
 * Installation required: Oracle.ManagedDataAccess
*/
{
    public partial class ConnectionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager
                         .ConnectionStrings["OracleDBConnectionString"].ConnectionString;

            OracleConnection con = new OracleConnection(connStr);
            con.Open();

            OracleCommand cmd = new OracleCommand("SELECT * FROM Students", con);
            OracleDataReader dr = cmd.ExecuteReader();

            GridView1.DataSource = dr;
            GridView1.DataBind();

            con.Close();
        }
    }
}