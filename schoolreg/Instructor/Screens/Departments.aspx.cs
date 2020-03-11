using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg.Instructor.Screens
{
    public partial class Departments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            table1.Columns.Add("Name");
            table1.Columns.Add("Email");
            table1.Columns.Add("Phone");
            table1.Rows.Add("TestName", "example@example.com", "123-456-7890");
            table1.Rows.Add("TestName2", "example2@example.com", "098-765-4321");
            ListView1.DataSource = table1;
            ListView1.DataBind();

        }
    }
}