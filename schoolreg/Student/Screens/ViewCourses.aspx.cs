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
    public partial class ViewCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.QueryString["ID"];

            if (!Page.IsPostBack)
            {

                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
                conn.Open();

                AllCourseHistory(conn, user);
                GetTermHistoy(conn, user);
                conn.Close();
            }
            /*DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Year");
            table.Columns.Add("Semester");
            table.Columns.Add("Grade");
            table.Rows.Add("TestClass", "2019", "Fall", "A");
            table.Rows.Add("TestClass2", "2020", "Winter", "B");
            table.Rows.Add("TestClass3", "2020", "Winter", "C");
            table.Rows.Add("TestClass4", "2020", "Winter", "D");
            ListView1.DataSource = table;
            ListView1.DataBind();*/
        }

        protected void AllCourseHistory(SqlConnection conn, string user)
        {
            SqlCommand cmd = new SqlCommand("course_history", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);

            SqlDataReader myReader = cmd.ExecuteReader();

            ListView1.DataSource = myReader;
            ListView1.DataBind();
            myReader.Close();
        }
        protected void FilteredCourseHistory(object sender, EventArgs e)
        {
            string year = null;
            string semester = null;
            string user = Request.QueryString["ID"];

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
            conn.Open();

            if (courseFilter.SelectedItem.Value.Equals("-1"))
            {
                AllCourseHistory(conn, user);
                conn.Close();
                return;
            }
            else
            {
                string[] strlist = courseFilter.SelectedItem.Value.Split(' ');
                year = strlist[0];
                semester = strlist[1];
            }
            SqlCommand cmd = new SqlCommand("filtered_term_history", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);
            cmd.Parameters.AddWithValue("@year", Int32.Parse(year));
            cmd.Parameters.AddWithValue("@semester", semester);

            SqlDataReader myReader = cmd.ExecuteReader();

            ListView1.DataSource = myReader;
            ListView1.DataBind();
            myReader.Close();
            conn.Close();
        }

        protected void GetTermHistoy(SqlConnection conn, string user)
        {
            SqlCommand cmd = new SqlCommand("term_history", conn);
            cmd.Parameters.AddWithValue("@userID", user);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            adpt.Fill(dt);
            dt.Columns.Add("YearAndSemester", typeof(string), "Year + ' ' + Semester");
            courseFilter.DataSource = dt;
            courseFilter.DataBind();
            courseFilter.DataTextField = "YearAndSemester";
            courseFilter.DataValueField = "YearAndSemester";
            courseFilter.DataBind();
            courseFilter.Items.Insert(0, new ListItem("All", "-1"));
        }
    }
}