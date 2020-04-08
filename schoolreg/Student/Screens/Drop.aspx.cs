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
    public partial class Drop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string user = "keysc3";
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
                conn.Open();

                CurrentCourses(conn, user);
                conn.Close();
            }
            /*DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Credits");
            table.Columns.Add("Section");
            table.Columns.Add("Building");
            table.Columns.Add("Room");
            table.Columns.Add("Timeslot");
            table.Rows.Add("TestClass", "3", "Sec1", "Building1", "234", "MonWeFri 9:00AM-9:50AM");
            table.Rows.Add("TestClass2", "3", "Sec2", "Building2", "314", "TuesThur 9:00AM - 10:20AM");
            table.Rows.Add("TestClass3", "3", "Sec3", "Building3", "134", "MonWeFri 10:00AM - 10:50AM");
            table.Rows.Add("TestClass4", "3", "Sec4", "Building4", "106", "TueThur 10:30AM - 11:50AM");
            ListView1.DataSource = table;
            ListView1.DataBind();*/
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

        protected void CheckChecked(object sender, EventArgs e)
        {
            foreach (ListViewItem row in ListView1.Items)
            {
                try
                {
                    if(row.ItemType == ListViewItemType.DataItem)
                    {
                        CheckBox checkBox = (CheckBox)row.FindControl("CheckBox1");
                        if (checkBox.Checked)
                        {
                            test.Text = ListView1.Items.IndexOf((ListViewDataItem)row).ToString();

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}