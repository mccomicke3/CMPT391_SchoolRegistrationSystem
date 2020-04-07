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

            table.Rows.Add("TestClass", "Sec1", "MonWeFri 9:00AM-9:50AM");
            table.Rows.Add("TestClass2", "Sec2", "TuesThur 9:00AM - 10:20AM");
            table.Rows.Add("TestClass3", "Sec3", "MonWeFri 10:00AM - 10:50AM");
            table.Rows.Add("TestClass4", "Sec4", "TueThur 10:30AM - 11:50AM");
            GridView1.DataSource = table;
            GridView1.DataBind();

            DataTable table2 = new DataTable();
            table2.Columns.Add("Name");
            table2.Columns.Add("Department");
            table2.Columns.Add("Building");
            table2.Columns.Add("Phone");
            table2.Columns.Add("DoB");
            table2.Columns.Add("Salary");

            GetProfInfo(table2);
            DataList1.DataSource = table2;
            DataList1.DataBind();
            DataList1.GridLines = GridLines.Both;
        }


        private void GetProfInfo(DataTable table)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "getProfInfo"
            };
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);

            object[] results = ds.Tables[0].Rows[0].ItemArray;

            foreach(object element in results)
            {
                System.Diagnostics.Debug.WriteLine(element.ToString());
            }
            table.Rows.Add(results);
            cnn.Close();
        }
    }
}