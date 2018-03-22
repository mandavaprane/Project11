using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class FollowPage : System.Web.UI.Page
{
    OleDbConnection con;
    OleDbDataAdapter adp;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] == null || Session["Username"].ToString().Equals(""))
            Response.Redirect("Default.aspx");
        con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("./Tweetr.mdb") + ";");
        BindGrid();
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        adp = new OleDbDataAdapter("select Username from Users where Username='" + txtUser.Text + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        if (ds.Tables[0].Rows.Count == 0)
        {
            lblError.Text = "No such User exist.";
        }
        else
        {
            if (txtUser.Text.Equals(Session["Username"].ToString()))
            {
                lblError.Text = "You cannot follow yourself";
                return;
            }
            else
            {
                lblError.Text = "";
            }
            adp = new OleDbDataAdapter("select * from Follow where Username='" + Session["Username"].ToString() + "' and Follower='" + txtUser.Text + "'", con);
            ds = new DataSet();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count == 0)
            {
                adp = new OleDbDataAdapter("insert into Follow(Username, Follower) values('" + Session["Username"].ToString() + "','" + txtUser.Text + "')", con);
                ds = new DataSet();
                adp.Fill(ds);
                BindGrid();
            }
        }
    }
    protected void BindGrid()
    {
        adp = new OleDbDataAdapter("select Follower from Follow where Username='" + Session["Username"].ToString() + "' order by Id desc", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        gridFollow.DataSource = ds;
        gridFollow.DataBind();
    }
    protected void TweetPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("TweetPage.aspx");
    }
}