using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class TweetPage : System.Web.UI.Page
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
    protected void TWEET_Click(object sender, EventArgs e)
    {
        adp = new OleDbDataAdapter("insert into Tweets(Username, Tweet) values('" + Session["Username"].ToString() + "', '" + txtTweet.Text + "')", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        BindGrid();
    }
    protected void BindGrid()
    {
        adp = new OleDbDataAdapter("select follower from follow where Username ='" + Session["Username"].ToString() + "'", con);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        String showTweets = "'"+Session["Username"].ToString()+"'";
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            showTweets += ",'" + ds.Tables[0].Rows[i]["follower"]+"'";
        adp = new OleDbDataAdapter("select Tweet, 'By ' + iif(Username='"+Session["Username"].ToString()+ "','YOU',Username) as Username from Tweets where Username in ("+showTweets+") order by Id desc", con);
        ds = new DataSet();
        adp.Fill(ds);
        gridTweets.DataSource = ds;
        gridTweets.DataBind();
    }
    protected void FOLLOW_Click(object sender, EventArgs e)
    {
        Response.Redirect("FollowPage.aspx");
    }
}