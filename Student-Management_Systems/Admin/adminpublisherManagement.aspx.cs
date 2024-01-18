using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Student_Management_Systems.App_Code;

namespace Student_Management_Systems.Admin
{
    public partial class adminpublisherManagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Add
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfPublisherExists())
            {
                Response.Write("<script>alert('Publisher with this ID Already Exists. You cannot add Another Publisher Same ID'); </script>");
            }
            else
            {
                addNewPublisher();
            }
        }


        //update
        protected void Button3_Click(object sender, EventArgs e)
        {

            if (checkIfPublisherExists())
            {
                updatePublisher();
            }
            else
            {
                Response.Write("<script>alert('Publisher does not Exists'); </script>");

            }

        }

        //Delete
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfPublisherExists())
            {
                deletePublisher();
            }
            else
            {
                Response.Write("<script>alert('Publisher does not Exists'); </script>");

            }

        }

        //search
        protected void Button1_Click(object sender, EventArgs e)
        {
            getPublisherByID();
        }

            //User Defined Function

            void addNewPublisher()
            {
            try
            {
                using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert_publisherDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.ToString());
                    cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.ToString());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();

                    Response.Write("<script>alert('Publisher Added Successfully') ; </script>");
                    clearForm();
                    GridView1.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
            try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("INSERT INTO  publisher_master(publisher_id, publisher_name) values(@publisher_id, @publisher_name)", con);

                    cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());

                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Publisher Added Successfully') ; </script>");
                    clearForm();
                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "'); </script>");
                }
            }

            void updatePublisher()
            {
            try
            {
                using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update_publisherDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Publisher Updated Successfully') ; </script>");
                    clearForm();
                    GridView1.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

            void deletePublisher()
            {
            try
            {
                using (SqlConnection con = new SqlConnection(new DBConnection().GetConn().ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete_publisherDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Author Deleted Successfully') ; </script>");
                    clearForm();
                    GridView1.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }
            
            bool checkIfPublisherExists()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from publisher_master WHERE publisher_id='" + TextBox1.Text.Trim() + "'; ", con);

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

                    Response.Write("<script>alert('Sign Up Successful. Go to User Login to Login') ; </script>");
                }
                catch (Exception ex)
                {
                   Response.Write("<script>alert('" + ex.Message + "'); </script>");
                    return false;
                }
            }

            void getPublisherByID()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from publisher_master WHERE publisher_id='" + TextBox1.Text.Trim() + "'; ", con);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count >= 1)
                    {
                        TextBox2.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert(Invalid Publisher ID') ; </script>");
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
            }
        }
    }

        
    