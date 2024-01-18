using Student_Management_Systems.App_Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_Systems.User
{
    public partial class userLogin : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("login_User", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@memeber_id", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@password", TextBox2.Text.ToString());

                int usercount = (Int32)cmd.ExecuteScalar();

                if (usercount == 1)  // comparing users from table 
                {
                    

                    Response.Redirect("../homePage.aspx");

                    ClientScript.RegisterClientScriptBlock(this.GetType(),
                        "alert", "swal('Success!', 'User Login Successfully', 'success')", true);

                }

                else
                {
                    con.Close();
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "swal('Failed', 'Invalid User ID or Password', 'error')", true);
                    // Label1.Text = "Invalid User Name or word";  //for invalid login
                }

                /* SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 con.Close();

                 Response.Write("<script>alert('Author Added Successfully') ; </script>");
                 clearForm();
                 GridView2.DataBind();
             }*/

                /*      query = "Emplogin";   //stored procedure Name
                  SqlCommand com = new SqlCommand(query, con);
                  com.CommandType = CommandType.StoredProcedure;
                  com.Parameters.AddWithValue("@Usename", TextBox1.Text.ToString());   //for username 
                  com.Parameters.AddWithValue("@word", TextBox2.Text.ToString());  //for word

                 // int usercount = (Int32)com.ExecuteScalar();// for taking single value

                  if (usercount == 1)  // comparing users from table 
                  {
                      Response.Redirect("Welcome.aspx");  //for sucsseful login
                  }
                  else
                  {
                      con.Close();
                      Label1.Text = "Invalid User Name or word";  //for invalid login
                  }

                  try
                  {
                      SqlConnection con = new SqlConnection(strcon);
                      if(con.State == System.Data.ConnectionState.Closed)
                      {
                          con.Open();
                      }
                      SqlCommand cmd = new SqlCommand("SELECT * FROM member_master_tbl WHERE member_id = '"+TextBox1.Text.Trim()+"' AND password='"+TextBox2.Text.Trim()+"'", con);

                      SqlDataReader dr = cmd.ExecuteReader();

                      if (dr.HasRows)
                      {
                          while (dr.Read())
                          {
                              Response.Write("<script>alert('"+dr.GetValue(5).ToString()+"')</script>");
                              Session["username"] = dr.GetValue(5).ToString();
                              Session["full_name"] = dr.GetValue(0).ToString();
                              Session["role"] = "user";
                              Session["status"] = dr.GetValue(7).ToString();
                          }
                          Response.Redirect("../homePage.aspx");
                      }
                      else
                      {
                          Response.Write("<script>alert('Invalid User')</script>");
                      }
                  }
                  catch(Exception ex)
                  {

                  }*/
            }
        }
    }
}