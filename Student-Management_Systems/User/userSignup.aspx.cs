using Student_Management_Systems.App_Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_Systems.User
{

    public partial class userSignup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkMemberExists())
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                        "alert", "swal('Member Already Exists', '', 'info')", true);
            }
            else
            {
                signUpNewMember();
            }

        }

        bool checkMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from member_master_tbl WHERE member_id='" + TextBox2.Text.Trim() + "'; ", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


                con.Close();

                ClientScript.RegisterClientScriptBlock(this.GetType(),
                        "alert", "swal('Sign Up Successful', 'Go to User Login to Login', 'success')", true);
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
                return false;
            }

        }

        //user Define Method
        void signUpNewMember()
        {
            try { 
            using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert_userDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@full_name", TextBox3.Text.ToString());
                cmd.Parameters.AddWithValue("@dob", TextBox4.Text.ToString());
                cmd.Parameters.AddWithValue("@contact_no", TextBox5.Text.ToString());
                cmd.Parameters.AddWithValue("@email", TextBox6.Text.ToString());
                cmd.Parameters.AddWithValue("@full_address", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@member_id", TextBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@password", TextBox7.Text.ToString());
                cmd.Parameters.AddWithValue("@account_status", "pending");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();

                    ClientScript.RegisterClientScriptBlock(this.GetType(),
                        "alert", "swal('Sign Up Successful', 'Go to User Login to Login', 'success')", true);

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }

        }

    }
}