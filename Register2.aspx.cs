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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-62V61RT\SQLEXPRESS; Initial Catalog =ShopOnlineDB; Integrated Security=False; User ID = sa; Password=alex;");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (FirstName, LastName, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)", con);

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = TextBox1.Text;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = TextBox2.Text;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 255).Value = TextBox3.Text;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100).Value = TextBox4.Text;

            cmd.ExecuteNonQuery();
            con.Close();

            Label1.Text = "Registered successfully!";
        }
    }
}