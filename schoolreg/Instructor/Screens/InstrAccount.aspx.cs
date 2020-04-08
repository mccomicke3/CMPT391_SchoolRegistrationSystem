using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace schoolreg.Instructor.Screens
{
    public partial class InstrAccount : System.Web.UI.Page
    {
        static string connectionString = "Data Source=DESKTOP-CHGMGOF;Initial Catalog=StudentRegistrationSystem;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
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

            DataRow data = ds.Tables[0].Rows[0];
            //operate on data
            FacilitatorFirst.Text = data[0].ToString().Substring(0, data[0].ToString().IndexOf(@" "));
            FacilitatorLast.Text = data[0].ToString().Substring(data[0].ToString().IndexOf(@" "));
            dobLabel.Text = data[4].ToString();
            salaryLabel.Text = data[5].ToString();
            deptLabel.Text = data[1].ToString();
            buildingLabel.Text = data[2].ToString();
            //close the connection
            cnn.Close();
        }

        protected void LastButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand
            {
                Connection = cnn,
                CommandType = CommandType.StoredProcedure,
                CommandText = "updateName"
            };
            cmd.Parameters.AddWithValue("@ID", "0-12345678");
            cmd.Parameters.AddWithValue("@fname", FacilitatorFirst.Text);
            cmd.Parameters.AddWithValue("@lname", FacilitatorLast.Text);

            cnn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}