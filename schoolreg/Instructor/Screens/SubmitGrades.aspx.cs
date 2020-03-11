using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg.Instructor.Screens
{
    public partial class SubmitGrades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Student");
            table.Rows.Add("TestStudent");
            table.Rows.Add("TestStudent2");
            table.Rows.Add("TestStudent3");
            ListView1.DataSource = table;
            ListView1.DataBind();
        }
    }
}