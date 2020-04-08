using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg.Instructor.Screens
{
    public partial class SubmitGrades : System.Web.UI.Page
    {
        static string connectionString = "Data Source=DESKTOP-CHGMGOF;Initial Catalog=StudentRegistrationSystem;Integrated Security=True";
        DataTable table = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            table.Columns.Add("Student");

            populateCourseDropDown();
        }

        //populate course dropdown with courses taught by professor
        protected void populateCourseDropDown()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getCourses"
            };
            cmd.Parameters.AddWithValue("@instructorID", "0-12345678");
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        if (!SelectCourse.Items.Contains(new ListItem(row[col].ToString())))
                        {
                            SelectCourse.Items.Add(row[col].ToString());
                        }
                    }
                }
            }
            cnn.Close();
        }

        //handle course dropdown selection
        protected void SelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the data
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getStudentsByCourse"
            };
            cmd.Parameters.AddWithValue("@dept", SelectCourse.SelectedValue.Substring(0,4));
            cmd.Parameters.AddWithValue("@courseNum", SelectCourse.SelectedValue.Substring(4, 3));
            cmd.Parameters.AddWithValue("@sectionID", SelectCourse.SelectedValue.Substring(8, 4));
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            //operate on data
            foreach (DataTable tab in ds.Tables)
            {
                foreach (DataRow row in tab.Rows)
                {
                    //System.Diagnostics.Debug.WriteLine(row[0]);
                    table.Rows.Add(row[0]);
                }
            }
            //close the connection
            cnn.Close();

            ListView1.DataSource = table;
            ListView1.DataBind();
        }

        protected void submitGrades_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(table.Rows.Count);

            foreach (DataRow row in table.Rows)
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnn,
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "submitGrades"
                };
                cmd.Parameters.AddWithValue("@studentID", row[0]);
                cmd.Parameters.AddWithValue("@dept", SelectCourse.SelectedValue.Substring(0, 4));
                cmd.Parameters.AddWithValue("@courseNum", SelectCourse.SelectedValue.Substring(4, 3));
                cmd.Parameters.AddWithValue("@sectionID", SelectCourse.SelectedValue.Substring(8, 4));
                cmd.Parameters.AddWithValue("@semester", "Fall");
                cmd.Parameters.AddWithValue("@year", 2020);
                cmd.Parameters.AddWithValue("@grade", (ListView1.FindControl("TextBox1") as TextBox).Text);

                System.Diagnostics.Debug.WriteLine(row[0].ToString(), SelectCourse.SelectedValue.Substring(0, 4), SelectCourse.SelectedValue.Substring(4, 3), SelectCourse.SelectedValue.Substring(8, 4), (ListView1.FindControl("TextBox1") as TextBox).Text);

                cnn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}