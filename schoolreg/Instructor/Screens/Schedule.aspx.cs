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
    public partial class Schedule : System.Web.UI.Page
    {
        static string connectionString = "Data Source=DESKTOP-CHGMGOF;Initial Catalog=StudentRegistrationSystem;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Credits");
            table.Columns.Add("Section");
            table.Columns.Add("Building");
            table.Columns.Add("Room");
            table.Columns.Add("Timeslot");

            insertScheduleData(table);
            
            ListView1.DataSource = table;
            ListView1.DataBind();
        }


        protected void insertScheduleData(DataTable table)
        {
            //get the data
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getInstructorSchedule"
            };
            cmd.Parameters.AddWithValue("@instructorID", "0-12345678");
            cmd.Parameters.AddWithValue("@semester", "Fall");
            cmd.Parameters.AddWithValue("@year", 2020);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            //operate on data
            foreach (DataTable tab in ds.Tables)
            {
                foreach (DataRow row in tab.Rows)
                {
                    table.Rows.Add(row[0], row[1], row[2], row[3], row[4], formatTimeslot(row[5].ToString()));
                }
            }
            //close the connection
            cnn.Close();
        }

        protected String formatTimeslot(String timeslot) { return timeslot.Substring(0, 3) + " " + timeslot.Substring(3,4) + "0-" + timeslot.Substring(7,4) + "0"; }

        // loads page, gets all departments for dropdown
        protected void loadClassAdd()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getDepartments"
            };
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
           
            foreach (DataTable table in ds.Tables)
            {
                foreach(DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        if (!SelectDept.Items.Contains(new ListItem(row[col].ToString())))
                        {
                            SelectDept.Items.Add(row[col].ToString());
                        }
                    }
                }
            }
            cnn.Close();
        }

        // gets all course numbers associated with selected depatment
        protected void SelectDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDept.Items[0].Enabled = false;

            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getCourseNumbers"
            };
            cmd.Parameters.AddWithValue("@dept", SelectDept.SelectedValue);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        if (!SelectNumber.Items.Contains(new ListItem(row[col].ToString())))
                        {
                            SelectNumber.Items.Add(row[col].ToString());
                        }
                    }
                }
            }
            cnn.Close();
        }

        // gets all sections associated with selected department and course number
        protected void SelectNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectNumber.Items[0].Enabled = false;

            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getSections"
            };
            cmd.Parameters.AddWithValue("@dept", SelectDept.SelectedValue);
            cmd.Parameters.AddWithValue("@courseNum", SelectNumber.SelectedValue);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        if (!SelectSection.Items.Contains(new ListItem(row[col].ToString())))
                        {
                            SelectSection.Items.Add(row[col].ToString());
                        }
                    }
                }
            }
            cnn.Close();
        }
        
        // get all timeslots
        protected void SelectTimeslot_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "addClass",
            };
            cmd.Parameters.AddWithValue("@dept", SelectDept.SelectedValue);
            cmd.Parameters.AddWithValue("@courseNum", SelectNumber.SelectedValue);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
        }

        // add new class according to chosen dept, course num and timeslot
        protected void addClass_Click(object sender, EventArgs e)
        {

        }
    }
}