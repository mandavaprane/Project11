<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#3B3131">
    <form id="form1" runat="server">
    <div>
        <br /><br /><br />
        <hr />
        <br />
        <h1 style="color:#0084b4;">LOGIN PAGE</h1>
        <div style="width:25%;margin: 0 auto;height:200px;background-color:#0084b4;display:table;">
            <table style="vertical-align:middle;display:table-cell; width:80%;margin:0 auto;" cellpadding="50px">
                <tr>
                    <td style="margin:0 auto;">
                        <asp:Label ID="Label1" runat="server" Text="USERNAME" style="background-color:Yellow;"></asp:Label></td>
                    <td style="margin:0 auto;"><asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
                    <td style="margin:0 auto;"><asp:LinkButton ID="Submit" runat="server" Text="SUBMIT" style="background-color:Yellow;" onclick="Submit_Click" /></td>
                </tr>
            </table>
        </div>
    </div>
    </form>
</body>
</html>
