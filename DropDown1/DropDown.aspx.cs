using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDown : System.Web.UI.Page
{
    string connectionString = ConfigurationManager.ConnectionStrings["Ginie"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind_Role();
        }
    }

    public void Bind_Role()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string sql = "select UserRole, RoleName, HomePage from UserRoles";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            con.Close();

            ddlRole.DataSource = dt;    //datasource
            ddlRole.DataTextField = "RoleName";
            //ddlRole.DataValueField = "RoleID";  // input taken as User ID for that RoleName
            ddlRole.DataBind();
            ddlRole.Items.Insert(0, new ListItem("------Select Role------", "0"));
        }
    }

    protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}