﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg.Student.Screens
{
    public partial class Schedule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Course");
            table.Columns.Add("Instructor");
            table.Columns.Add("Section");
            table.Columns.Add("Building");
            table.Columns.Add("Room");
            table.Columns.Add("Timeslot");
            table.Rows.Add("TestClass", "dan", "Sec1", "Building1", "234", "MonWeFri 9:00AM-9:50AM");
            table.Rows.Add("TestClass2", "jer", "Sec2", "Building2", "314", "TuesThur 9:00AM - 10:20AM");
            table.Rows.Add("TestClass3", "mon", "Sec3", "Building3", "134", "MonWeFri 10:00AM - 10:50AM");
            table.Rows.Add("TestClass4", "kol", "Sec4", "Building4", "106", "TueThur 10:30AM - 11:50AM");
            ListView1.DataSource = table;
            ListView1.DataBind();
        }
    }
}