using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg
{
    public partial class _Default : Page
    {
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
            table2.Rows.Add("TestName", "CompSci", "Building5", "780-297-1102", "2/10/1980", "80,000$");
            DataList1.DataSource = table2;
            DataList1.DataBind();
            DataList1.GridLines = GridLines.Both;
        }
    }
}