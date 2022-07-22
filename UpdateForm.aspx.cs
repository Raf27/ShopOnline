using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopOnline.Views.Item
{
    public partial class UpdateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-62V61RT\SQLEXPRESS; Initial Catalog =ShopOnlineDB; Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update Master.Items set CategoryId=@CategoryId, ItemName=@ItemName, Description=@Description, ItemPrice=@ItemPrice, ImagePath=@ImagePath where ItemId= @ItemId", con);
            cmd.Parameters.Add("@ItemId", SqlDbType.UniqueIdentifier).Value = Guid.Parse(txtbox1.Text);
            cmd.Parameters.Add("@CategoryId", SqlDbType.Int, 50).Value = txtbox2.Text;
            cmd.Parameters.Add("@ItemName", SqlDbType.VarChar, 200).Value = txtbox3.Text;
            cmd.Parameters.Add("@Description", SqlDbType.VarChar, 600).Value = txtbox4.Text;
            cmd.Parameters.Add("@ItemPrice", SqlDbType.Decimal).Value = txtbox4.Text;
            cmd.Parameters.Add("@ImagePath", SqlDbType.VarChar, 600).Value = txtbox4.Text;
            cmd.ExecuteNonQuery();
            con.Close();

            Label2.Text = " Success!";
        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-62V61RT\SQLEXPRESS; Initial Catalog =ShopOnlineDB; Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Master.Items", con);
            SqlDataAdapter dat = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dat.Fill(dt);
            GridView1.DataSource = dt;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-62V61RT\SQLEXPRESS; Initial Catalog =ShopOnlineDB; Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Master.Items where ItemId=@ItemId", con);
            cmd.Parameters.AddWithValue("@ItemId", Guid.Parse(txtbox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            Label2.Text = "Success !";
        }
    }
}
