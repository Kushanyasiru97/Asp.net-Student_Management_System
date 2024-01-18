using Student_Management_Systems.App_Code;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Student_Management_Systems.Admin
{
    public partial class adminauthorManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //Add Button_Click
        protected void Button8_Click(object sender, EventArgs e)
        {
            if (checkIfAuthorExists())
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                        "alert", "swal('Author with this ID Already Exists', 'You cannot add Abother Author Same ID', 'warning')", true);
               // Response.Write("<script>alert('Author with this ID Already Exists. You cannot add Abother Author Same ID'); </script>");
            }
            else
            {
                addNewAuthor();
            }

        }

        //Update Button_Click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfAuthorExists())
            {
               updateAuthor();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                       "alert", "swal('Author does not Exists', '', 'info')", true);
               // Response.Write("<script>alert('Author does not Exists'); </script>");
                
            }
        }

        //Delete Button_Click
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfAuthorExists())
            {
                deleteAuthor();
            }
            else
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(),
                      "alert", "swal('Author does not Exists', '', 'info')", true);

            }
        }

        //Go Button_Click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getAuthorByID();
        }

        //User Defined Function

        void addNewAuthor()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert_authorDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    cmd.Parameters.AddWithValue("@author_id", TextBox5.Text.ToString());
                    cmd.Parameters.AddWithValue("@author_name", TextBox6.Text.ToString());
                    
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();

                    ClientScript.RegisterClientScriptBlock(this.GetType(),
                      "alert", "swal('Author Added Successfully', '', 'success')", true);
                    //Response.Write("<script>alert('Author Added Successfully') ; </script>");
                    clearForm();
                    GridView2.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

          void updateAuthor()
          {
            try
            {
                using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update_authorDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@author_id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@author_name", TextBox2.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    ClientScript.RegisterClientScriptBlock(this.GetType(),
                      "alert", "swal('Author Updated Successfully', '', 'success')", true);
                    //Response.Write("<script>alert('Author Updated Successfully') ; </script>");
                    clearForm();
                    GridView2.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        void deleteAuthor()
        {
            try
            {
            using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete_authorDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@author_id", TextBox1.Text);
                cmd.Parameters.AddWithValue("@author_name", TextBox2.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                    ClientScript.RegisterClientScriptBlock(this.GetType(),
                     "alert", "swal('Author Deleted Successfully', '', 'warning')", true);
                   // Response.Write("<script>alert('Author Deleted Successfully') ; </script>");
                clearForm();
                GridView2.DataBind();

            }
        }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
}

        bool checkIfAuthorExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from author_master_tbl WHERE author_id='" + TextBox1.Text.Trim() + "'; ", con);

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

               // Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login') ; </script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
                return false;
            }
        }

        void getAuthorByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from author_master_tbl WHERE author_id='" + TextBox1.Text.Trim() + "'; ", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                   TextBox2.Text = dt.Rows[0][2].ToString();
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(),
                    "alert", "swal('Invalid Author ID', '', 'warning')", true);
                   // Response.Write("<script>alert(Invalid Author ID') ; </script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

    }
}