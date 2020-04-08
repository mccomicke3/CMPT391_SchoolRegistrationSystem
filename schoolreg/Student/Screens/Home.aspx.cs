using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace schoolreg.Student.Screens
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["ID"];
            HtmlAnchor masterName = (HtmlAnchor)Page.Master.FindControl("masterName");
            masterName.InnerText = user;

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
            conn.Open();

            BasicInfo(conn, user);
            CurrentCourses(conn, user);
            conn.Close();
            /*DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Instructor");
            table.Columns.Add("Section");
            table.Columns.Add("Building");
            table.Columns.Add("Room");
            table.Columns.Add("Timeslot");
            table.Rows.Add("TestClass", "dan", "Sec1", "Building1", "234", "MonWeFri 9:00AM-9:50AM");
            table.Rows.Add("TestClass2", "jer", "Sec2", "Building2", "314", "TuesThur 9:00AM - 10:20AM");
            table.Rows.Add("TestClass3", "mon", "Sec3", "Building3", "134", "MonWeFri 10:00AM - 10:50AM");
            table.Rows.Add("TestClass4", "kol", "Sec4", "Building4", "106", "TueThur 10:30AM - 11:50AM");
            ListView1.DataSource = table;
            ListView1.DataBind();*/
        }

        protected void BasicInfo(SqlConnection conn, string user)
        {
            SqlCommand cmd = new SqlCommand("basicStudent", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", user);

            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            studentName.Text = myReader.GetString(0) + " " + myReader.GetString(1);
            studentMajor.Text = myReader.GetString(3);
            studentMinor.Text = myReader.GetString(4);
            studentGPA.Text = Convert.ToString(myReader.GetDouble(5));
            myReader.Close();
        }

        protected void CurrentCourses(SqlConnection conn, string user)
        {
            SqlCommand cmd = new SqlCommand("current_courses", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);

            SqlDataReader myReader = cmd.ExecuteReader();

            ListView1.DataSource = myReader;
            ListView1.DataBind();
            myReader.Close();
        }

        protected void GoToCourseHistory(object sender, EventArgs e)
        {
            Response.Redirect("~/Student/Screens/ViewCourses.aspx?ID=" + Request.QueryString["ID"]);
        }
    }
}