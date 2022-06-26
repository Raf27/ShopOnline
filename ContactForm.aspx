<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.aspx.cs" Inherits="ShopOnline.ContactForm" %> 
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact</title>
    <link href="~/Content/Site.css" rel="stylesheet" type="text/css" />
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="~/Scripts/modernizr-2.6.2.js"></script>
    <script src="~/scripts/jquery-1.10.2.min.js"></script>
    <script src="~/scripts/jquery.validate.min.js"></script>
    <script src="~/scripts/jquery.validate.unobtrusive.min.js"></script>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <script src="https://kit.fontawesome.com/a076d05399.js"></script>
    <link href="ContactStyle.css" rel="stylesheet" />
    <link href="bootstrap.min.css" rel="stylesheet" />

     <style>
        @import url('https://fonts.googleapis.com/css?family=Leckerli+One|Oleo+Script+Swash+Caps');
    </style>

</head>
<body>

    <form id="form1" runat="server">

<div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                </ul>
                    </div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Button ID="Button1" runat="server" Text="Go Back Shopping" OnClick="Button1_Click1" />
            </asp:Panel>
            </div>
    </div>

    <div>
        <div class="container">
            <div class="contact-main">
                <div class="contact-second second1">
                    <p>
                        <i class="fas fa-map-marker-alt"></i> Adress <br />
                        <span> Bulevardul Revolutiei 90
                            <br />
                            Arad, Romania
                        </span>
                    </p>

                    <p>
                        <i class="fas fa-phone-alt"></i> Call Us <br />
                        <span> 0742568765</span>
                    </p>

                    <p>
                        <i class="far fa-envelope"></i> General Support Email <br />
                        <span> rafaelrasca20@yahoo.ro </span>
                    </p>
                </div>

                <div class="contact-second second2">
                    <div class="inside-contact">
                        <h2>Contact Us</h2>
                        <h3>
                            <asp:Label ID="confirm" runat="server" Text=""></asp:Label>
                        </h3>

                        <p>Name *</p>
                        <asp:TextBox ID="text_name" runat="server" ></asp:TextBox>

                        <p>Email *</p>
                        <asp:TextBox ID="text_email" runat="server" ></asp:TextBox>

                        <p>Phone *</p>
                        <asp:TextBox ID="text_phone" runat="server" ></asp:TextBox>

                        <p>Subject </p>
                        <asp:TextBox ID="text_subject" runat="server" ></asp:TextBox>

                        <p>Message </p>
                        <asp:TextBox ID="text_message" runat="server"  TextMode="MultiLine" Rows="4"></asp:TextBox>

                        <asp:Button ID="btn_send" runat="server" Text="Send" OnClick="btn_send_click" />
                    </div>
                    
                </div>
            </div>
        </div>
    </div>

        <div class="container body-content">
        <hr />
        <footer>
            <p>&copy; 2022 - My ASP.NET Shop Online</p>
            <div class="social">
                <a href=""><i class="fab fa-facebook-f"></i></a>
                <a href=""><i class="fab fa-twitter"></i></a>
                <a href=""><i class="fab fa-instagram"></i></a>
            </div>
    </footer>
    </div>

        <script src="~/Scripts/jquery-1.10.2.min.js"></script>
    <script src="~/Scripts/bootstrap.min.js"></script>
    </form> 
</body>
</html>
