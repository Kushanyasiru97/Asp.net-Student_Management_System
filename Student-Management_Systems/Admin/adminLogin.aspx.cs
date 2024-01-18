using Student_Management_Systems.App_Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_Systems.Admin
{
    public partial class adminLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("login_Admin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@password", TextBox2.Text.ToString());

                int usercount = (Int32)cmd.ExecuteScalar();

                if (usercount == 1)  // comparing users from table 
                {

                    Response.Redirect("../homePage.aspx");  //for sucsseful login
                }
                else
                {
                    con.Close();
                    Response.Write("<script>alert('Invalid Admin')</script>");
                    // Label1.Text = "Invalid User Name or word";  //for invalid login
                }

            }
                

            /*try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM admin_login_tbl WHERE username = '" + TextBox1.Text.Trim() + "' AND password='" + TextBox2.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        
                        Session["username"] = dr.GetValue(0).ToString();
                        Session["full_name"] = dr.GetValue(2).ToString();
                        Session["role"] = "admin";
                        //Session["status"] = dr.GetValue(10).ToString();
                        Response.Write("<script>swal('Login Successfully', 'You clicked the button!', 'success');</script>");
                    }
                    Response.Redirect("../homePage.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "k", "swal('Login Successfully', 'You clicked the button!', 'error')", true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('"+ex.Message+"')</script>");
            }*/
        }
    }
}