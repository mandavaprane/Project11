<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="FollowPage.aspx.cs" Inherits="FollowPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <br /><br /><br />
        <hr />
        <br />
        <h1 style="color:#0084b4;">FOLLOW PAGE</h1>
        <div style="width:50%;margin: 0 auto;height:200px;background-color:#0084b4;">
            <br /><br />
            <table style="margin:0 auto;width:95%;">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="USER TO FOLLOW"  style="background-color:Yellow;"></asp:Label></td>
                    <td><asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
                    <td><asp:LinkButton ID="Submit" runat="server" Text="SUBMIT" onclick="Submit_Click"  style="background-color:Yellow;" /> </td>
                    <td><asp:LinkButton ID="TweetPage" runat="server" Text="TWEET PAGE"  style="background-color:Yellow;"
                            onclick="TweetPage_Click" /></td>
                    </td>
                </tr>
                <tr><td colspan="3">
                    <asp:Label ID="lblError" runat="server" Text="" style="width:100%;" Font-Bold="True" ForeColor="Red"></asp:Label></td></tr>
            </table>
            <br /><hr />
            <asp:GridView ID="gridFollow" runat="server" style="width:80%;margin:0 auto;background-color:#0084b4;color:White;border-style:none;" ShowHeader=false BorderStyle="None">
            </asp:GridView>
        </div>
</asp:Content>

