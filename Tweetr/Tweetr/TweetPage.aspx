<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TweetPage.aspx.cs" Inherits="TweetPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br /><br /><br />
        <hr />
        <br />
        <h1 style="color:#0084b4;">MAIN PAGE</h1>
        <div style="width:50%;margin: 0 auto;height:50%">
            <table style="margin:0 auto;width:95%;">
                <tr>
                    <td><asp:TextBox ID="txtTweet" runat="server" style="width:300px;" MaxLength="140" 
                            Rows="3" TextMode="MultiLine"></asp:TextBox></td>
                    <td><asp:LinkButton ID="TWEET" runat="server" Text="TWEET" onclick="TWEET_Click" style="background-color:Yellow;" /></td>
                    <td><asp:LinkButton ID="FOLLOW" runat="server" Text="FOLLOW" onclick="FOLLOW_Click" style="background-color:Yellow;"/></td>
                </tr>
            </table>
            <br /><hr />
            <asp:GridView ID="gridTweets" runat="server" style="width:80%;margin:0 auto;background-color:#0084b4;color:White;" 
                ShowHeader=false>
            </asp:GridView>
        </div>
</asp:Content>

