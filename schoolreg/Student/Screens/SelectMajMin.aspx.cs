using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg.Student.Screens
{
    public partial class SelectMajMin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["ID"];

            if (!Page.IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
                conn.Open();

                GetDepartments(conn);
                CurrentMajorMinor(conn, user);
                conn.Close();
            }

        }

        protected void GetDepartments(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("get_departments", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            majorDrop.DataSource = dt;
            majorDrop.DataBind();
            majorDrop.DataTextField = "DeptName";
            majorDrop.DataValueField = "DeptName";
            majorDrop.DataBind();
            majorDrop.Items.Insert(0, new ListItem("Major", "-1"));

            minorDrop.DataSource = dt;
            minorDrop.DataBind();
            minorDrop.DataTextField = "DeptName";
            minorDrop.DataValueField = "DeptName";
            minorDrop.DataBind();
            minorDrop.Items.Insert(0, new ListItem("Minor", "-1"));
          
        }

        protected void CurrentMajorMinor(SqlConnection conn, string user)
        {
            SqlCommand cmd = new SqlCommand("get_major_minor", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);

            SqlDataReader myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                majorDrop.SelectedIndex = majorDrop.Items.IndexOf(majorDrop.Items.FindByValue(myReader.GetString(0)));
                minorDrop.SelectedIndex = minorDrop.Items.IndexOf(minorDrop.Items.FindByValue(myReader.GetString(1)));
                //has rows
            }
            myReader.Close();
        }

        protected void UpdateMajorMinor(object sender, EventArgs e)
        {
            string major = majorDrop.SelectedItem.Value;
            string minor = minorDrop.SelectedItem.Value;

            if (major.Equals(minor))
            {
                FailureText.Text = "Can't have the same major and minor";
                ErrorMessage.Visible = true;
                return;
            }
            else if (major.Equals("-1") || minor.Equals("-1"))
            {
                FailureText.Text = "Select both a major and minor";
                ErrorMessage.Visible = true;
                return;

            }
            else
            {
                string user = Request.QueryString["ID"];
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("set_major_minor", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", user);
                cmd.Parameters.AddWithValue("@major", major);
                cmd.Parameters.AddWithValue("@minor", minor);
                cmd.ExecuteNonQuery();
                FailureText.Text = "Success!";
                ErrorMessage.Visible = true;
            }
        }
    }
}