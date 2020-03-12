using System;
using System.Collections.Generic;
using System.Data;
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
            DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Year");
            table.Columns.Add("Semester");
            table.Columns.Add("Grade");
            table.Rows.Add("TestClass", "2019", "Fall", "A");
            table.Rows.Add("TestClass2", "2020", "Winter", "B");
            table.Rows.Add("TestClass3", "2020", "Winter", "C");
            table.Rows.Add("TestClass4", "2020", "Winter", "D");
            ListView1.DataSource = table;
            ListView1.DataBind();
        }
    }
}