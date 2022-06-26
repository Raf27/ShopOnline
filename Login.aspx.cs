using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopOnline
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-62V61RT\SQLEXPRESS; Initial Catalog =ShopOnlineDB; Integrated Security=True;");
                SqlDataAdapter sda = new SqlDataAdapter("Select * from [User] where Email='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (TextBox1.Text == "Admin" & TextBox2.Text == "0000")
                {
                    Session["admin"] = TextBox1.Text;
                    Response.Redirect("~/Item/Index");
                }
                else if (dt.Rows.Count == 1)
                {
                    Session["username"] = TextBox1.Text;
                    Response.Redirect("~/Shopping/Index");
                }
                else
                {
                    Label2.Text = " Login unsuccessful !";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}