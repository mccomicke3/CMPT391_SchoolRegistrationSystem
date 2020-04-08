using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg
{
    public partial class Warehouse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=SchoolWarehouse;Integrated Security=True");
                conn.Open();
                GetDropDownCourses(conn);
                GetDropDownDepartment(conn);
                GetDropDownFaculty(conn);
                GetDropDownYear(conn);
                GetDropDownInstructor(conn);
                conn.Close();
            }
        }

        protected void GetDropDownCourses(SqlConnection conn)
        {
            string query = "select top 16 CName from [Course]";
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(dt);
            courseDrop.DataSource = dt;
            courseDrop.DataBind();
            courseDrop.DataTextField = "CName";
            courseDrop.DataValueField = "CName";
            courseDrop.DataBind();
            courseDrop.Items.Insert(0, new ListItem("Course", "-1"));
        }

        protected void GetDropDownFaculty(SqlConnection conn)
        {
            string query = "select distinct DFaculty from [Department]";
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(dt);
            facDrop.DataSource = dt;
            facDrop.DataBind();
            facDrop.DataTextField = "DFaculty";
            facDrop.DataBind();
            facDrop.Items.Insert(0, new ListItem("Faculty", "-1"));
        }

        protected void GetDropDownDepartment(SqlConnection conn)
        {
            string query = "select top 14 DName from [Department]";
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(dt);
            deptDrop.DataSource = dt;
            deptDrop.DataBind();
            deptDrop.DataTextField = "DName";
            deptDrop.DataBind();
            deptDrop.Items.Insert(0, new ListItem("Department", "-1"));
        }

        protected void GetDropDownYear(SqlConnection conn)
        {
            string query = "select Distinct Year from [Semester]";
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(dt);
            yearDrop.DataSource = dt;
            yearDrop.DataBind();
            yearDrop.DataTextField = "Year";
            yearDrop.DataBind();
            yearDrop.Items.Insert(0, new ListItem("Year", "-1"));
        }

        protected void GetDropDownInstructor(SqlConnection conn)
        {
            string query = "select top 10 IName from [Instructor]";
            DataTable dt = new DataTable();
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            adpt.Fill(dt);
            instrDrop.DataSource = dt;
            instrDrop.DataBind();
            instrDrop.DataTextField = "IName";
            instrDrop.DataBind();
            instrDrop.Items.Insert(0, new ListItem("Instructor", "-1"));
        }

        protected void GetCourses(object sender, EventArgs e)
        {
            String course = null;
            String department = null;
            String faculty = null;
            String year = null;
            String term = null;
            String instructor = null;

            if (!courseDrop.SelectedItem.Value.Equals("-1"))
                course = courseDrop.SelectedItem.Text;
            if (!deptDrop.SelectedItem.Value.Equals("-1"))
                department = deptDrop.SelectedItem.Text;
            if (!facDrop.SelectedItem.Value.Equals("-1"))
                faculty = facDrop.SelectedItem.Text;
            if (!yearDrop.SelectedItem.Value.Equals("-1"))
                year = yearDrop.SelectedItem.Text;
            if (!termDrop.SelectedItem.Value.Equals("-1"))
                term = termDrop.SelectedItem.Text;
            if (!instrDrop.SelectedItem.Value.Equals("-1"))
                instructor = instrDrop.SelectedItem.Text;

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=SchoolWarehouse;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("offered_courses", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if(course == null)
                cmd.Parameters.AddWithValue("@course", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@course", course);
            if(department == null)
                cmd.Parameters.AddWithValue("@department", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@department", department);
            if(faculty == null)
                cmd.Parameters.AddWithValue("@faculty", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@faculty", faculty);
            if (year == null)
                cmd.Parameters.AddWithValue("@year", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@year", Convert.ToInt32(year));
            if(term == null)
                cmd.Parameters.AddWithValue("@term", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@term", term);
            if(instructor == null)
                cmd.Parameters.AddWithValue("@instructor", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@instructor", instructor);

            SqlDataReader myReader = cmd.ExecuteReader();
            GridView1.DataSource = myReader;
            GridView1.DataBind();
            myReader.Close();
        }
    }
}