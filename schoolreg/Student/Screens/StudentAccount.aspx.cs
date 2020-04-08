using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace schoolreg.Student.Screens
{
    public partial class StudentAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
                conn.Open();

                GetAccountInfo(conn, "keysc3");
                conn.Close();
            }
        }

        protected void GetAccountInfo(SqlConnection conn, string user)
        {
            SqlCommand cmd = new SqlCommand("get_account_info", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);

            SqlDataReader myReader = cmd.ExecuteReader();
            myReader.Read();
            firstName.Text = myReader.GetString(0);
            lastName.Text = myReader.GetString(1);
            sin.Text = myReader.GetString(2);
            city.Text = myReader.GetString(3);
            number.Text = myReader.GetString(4);
            street.Text = myReader.GetString(5);
            province.Text = myReader.GetString(6);
            postal.Text = myReader.GetString(7);
            myReader.Close();
        }

        protected void UpdatePrimaryAccountInfo(object sender, EventArgs e)
        {
            string user = "keysc3";
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update_primary_account_info", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);
            cmd.Parameters.AddWithValue("@FName", firstName.Text);
            cmd.Parameters.AddWithValue("@LName", lastName.Text);
            cmd.Parameters.AddWithValue("@SIN", sin.Text);
            cmd.ExecuteNonQuery();

        }

        protected void UpdateSecondaryAccountInfo(object sender, EventArgs e)
        {
            string user = "keysc3";
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update_secondary_account_info", conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", user);
            cmd.Parameters.AddWithValue("@city", city.Text);
            cmd.Parameters.AddWithValue("@num", number.Text);
            cmd.Parameters.AddWithValue("@street", street.Text);
            cmd.Parameters.AddWithValue("@prov", province.Text);
            cmd.Parameters.AddWithValue("@postal", postal.Text);
            cmd.ExecuteNonQuery();
        }
    }
}