using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbDataAdapter adp;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("./Tweetr.mdb") + ";");
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        adp = new OleDbDataAdapter("select * from Users where Username = '" + txtUser.Text + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count == 0)
        {
            adp = new OleDbDataAdapter("insert into Users values('" + txtUser.Text + "')", con);
            DataSet ds1 = new DataSet();
            adp.Fill(ds1);
        }
        Session["Username"] = txtUser.Text;
        Response.Redirect("TweetPage.aspx");
    }
}