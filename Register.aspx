<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ShopOnline.Register1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Register</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <script src="~/scripts/jquery-1.10.2.min.js"></script>
    <script src="~/scripts/jquery.validate.min.js"></script>
    <script src="~/scripts/jquery.validate.unobtrusive.min.js"></script>
    <link href="Style1.css" rel="stylesheet" />
    <link href="bootstrap.min.css" rel="stylesheet" />

     <style>
        @import url('https://fonts.googleapis.com/css?family=Leckerli+One|Oleo+Script+Swash+Caps');
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section class="cover">
            <div>
                <asp:Image ID="Image1" runat="server" />
                <div class="elements">
                    <div class="intro">
                        <asp:Label ID="Label1" runat="server" Text="Register"></asp:Label>

                        <asp:TextBox ID="TextBox1" CssClass="txt1 txtstyle" placeholder="First Name:" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" CssClass="txt2 txtstyle" placeholder="Last Name:" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" CssClass="txt3 txtstyle" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" CssClass="txt4 txtstyle" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>

                        <asp:Button ID="Button1" CssClass="btn1 btnstyle" runat="server" Text="Register" OnClick="Button1_Click" />
                        <asp:Button ID="Button2" CssClass="btn1 btnstyle" runat="server" Text="Login" OnClick="Button2_Click" />

                        <br />
                        <br />

                        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
