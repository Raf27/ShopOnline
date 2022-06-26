<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register2.aspx.cs" Inherits="ShopOnline.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    <table align="center">
        <tr>
            <td colspan="2" align="center">
                Register Page
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp;&nbsp;&nbsp;&nbsp; First Name:</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp;&nbsp;&nbsp;&nbsp; Last Name:</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email:</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Password:</b>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Register" Height="40px" Width="120px" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
  </div>
    </form>
</body>
</html>
