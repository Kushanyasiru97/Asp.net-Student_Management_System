using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Management_Systems
{
    public partial class adminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton3.Visible = false;
                    LinkButton5.Visible = false;

                    LinkButton6.Visible = true; // admin login
                    LinkButton7.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton11.Visible = false;
                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; // user Login
                    LinkButton2.Visible = false;
                    LinkButton3.Visible = true;
                    LinkButton5.Visible = true;
                    LinkButton5.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = true; // admin login
                    LinkButton7.Visible = false;
                    LinkButton8.Visible = false;
                    LinkButton9.Visible = false;
                    LinkButton10.Visible = false;
                    LinkButton11.Visible = false;
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; // user Login
                    LinkButton2.Visible = false;
                    LinkButton3.Visible = true;
                    LinkButton5.Visible = true;
                    LinkButton5.Text = "Hello Admin";

                    LinkButton6.Visible = false; // admin login
                    LinkButton7.Visible = true;
                    LinkButton8.Visible = true;
                    LinkButton9.Visible = true;
                    LinkButton10.Visible = true;
                    LinkButton11.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthorManagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublisherManagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookInventory.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminissueBooks.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmemeberManagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmemeberManagement.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../User/userSignup.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../User/userLogin.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["full_name"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; // User Login
            LinkButton2.Visible = true;
            LinkButton3.Visible = false;
            LinkButton5.Visible = false;

            LinkButton6.Visible = true; // admin login
            LinkButton7.Visible = false;
            LinkButton8.Visible = false;
            LinkButton9.Visible = false;
            LinkButton10.Visible = false;
            LinkButton11.Visible = false;
        }
    }
}