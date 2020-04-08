using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg
{
    public partial class _Default : Page
    {
        static string connectionString = "Data Source=DESKTOP-CHGMGOF;Initial Catalog=StudentRegistrationSystem;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Class");
            table.Columns.Add("Section");
            table.Columns.Add("Time");

            /*
            table.Rows.Add("TestClass", "Sec1", "MonWeFri 9:00AM-9:50AM");
            table.Rows.Add("TestClass2", "Sec2", "TuesThur 9:00AM - 10:20AM");
            table.Rows.Add("TestClass3", "Sec3", "MonWeFri 10:00AM - 10:50AM");
            table.Rows.Add("TestClass4", "Sec4", "TueThur 10:30AM - 11:50AM");
            */
            insertScheduleData(table);
            GridView1.DataSource = table;
            GridView1.DataBind();

            DataTable table2 = new DataTable();
            table2.Columns.Add("Name");
            table2.Columns.Add("Department");
            table2.Columns.Add("Building");
            table2.Columns.Add("Phone");
            table2.Columns.Add("DoB");
            table2.Columns.Add("Salary");

            insertProfInfo(table2);

            DataList1.DataSource = table2;
            DataList1.DataBind();
            DataList1.GridLines = GridLines.Both;
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
                    table.Rows.Add(row[0], row[2], formatTimeslot( row[5].ToString() ));
                }
            }
            //close the connection
            cnn.Close();
        }
        
        protected string formatTimeslot(string timeslot) { return timeslot.Substring(0, 3) + " " + timeslot.Substring(3, 4) + "0-" + timeslot.Substring(7, 4) + "0"; }

        protected void insertProfInfo(DataTable table)
        {
            //get the data
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getProfInfo"
            };
            cmd.Parameters.AddWithValue("@instructorID", "0-12345678");
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            //operate on data
            foreach (DataTable tab in ds.Tables)
            {
                foreach (DataRow row in tab.Rows)
                {
                    table.Rows.Add(row[0],row[1],row[2],row[3],row[4],row[5]);
                }
            }
            //close the connection
            cnn.Close();
        }
    }
}