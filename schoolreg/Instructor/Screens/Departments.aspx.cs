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
    public partial class Departments : System.Web.UI.Page
    {
        static string connectionString = "Data Source=DESKTOP-CHGMGOF;Initial Catalog=StudentRegistrationSystem;Integrated Security=True";
        // don't crucify me for making this a global variable, I don't know how else to get it where it needs to go
        DataTable table = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            table.Columns.Add("Name");
            table.Columns.Add("Salary");
            table.Columns.Add("Phone");

            populateDeptDropDown();
            insertProfInfo(table);
            getDeptHead();

            ListView1.DataSource = table;
            ListView1.DataBind();

        }
        // populate the department dropdown
        protected void populateDeptDropDown()
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
                foreach (DataRow row in table.Rows)
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
        // handle dropdown selection
        protected void SelectDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectDept.Items[0].Enabled = false;
            insertProfInfo(table);
            getDeptHead();
        }
        // insert instructor info into the table
        protected void insertProfInfo(DataTable table)
        {
            table.Clear();
            //get the data
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getDeptProfs"
            };
            cmd.Parameters.AddWithValue("@deptName", SelectDept.SelectedValue);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            //operate on data
            foreach (DataTable tab in ds.Tables)
            {
                foreach (DataRow row in tab.Rows)
                {
                    //System.Diagnostics.Debug.WriteLine("inserting prof info...");
                    table.Rows.Add(row[0], row[1], row[2]);
                }
            }
            //close the connection
            cnn.Close();
        }
        //get the department head
        protected void getDeptHead()
        {
            deptHead.Text = "";
            //get the data
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getDeptHead"
            };
            cmd.Parameters.AddWithValue("@deptName", SelectDept.SelectedValue);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            //operate on data
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn col in table.Columns)
                    {
                        deptHead.Text = row[col].ToString();
                    }
                }
            }
        }
    }
}