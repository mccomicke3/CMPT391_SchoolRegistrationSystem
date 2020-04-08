﻿using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using schoolreg.Models;
using System.Data.SqlClient;

namespace schoolreg.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
        }

        protected void LogIn(object sender, EventArgs e)
        {
            //Connect to Databse
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3CQFTT1;Initial Catalog=StudentRegistrationSystem;Integrated Security=True;MultipleActiveResultSets=true");
            conn.Open();

            //Create query string and parameters
            //string query = "select UserID from [Users] where UserID = @username and PasswordHash = @password";
            SqlCommand getUser = new SqlCommand("getUser", conn);
            getUser.CommandType = System.Data.CommandType.StoredProcedure;
            getUser.Parameters.AddWithValue("@username", Email.Text);
            getUser.Parameters.AddWithValue("@password", Password.Text);
            //FailureText.Text = Password.Text;
            //ErrorMessage.Visible = true;
            //Execute Query
            SqlDataReader userReader = getUser.ExecuteReader();

            //If a user was found, check for admin or recepionist
            while (userReader.Read())
            {
                string role = IsInRole(conn, userReader);
                if (role.Equals("Student"))
                {
                    conn.Close();
                    userReader.Close();
                    Response.Redirect("/Student/Screens/Home.aspx?ID=" + Email.Text);
                }
                else if (role.Equals("Instructor"))
                {
                    conn.Close();
                    userReader.Close();
                    Response.Redirect("/Instructor/Screens/Default.aspx");
                }
                else
                {
                    //Admin Screen
                }
                return;
            }

            //Invalid login
            FailureText.Text = "Invalid username or password";
            ErrorMessage.Visible = true;
            conn.Close();
            return;
        }

        protected String IsInRole(SqlConnection conn, SqlDataReader userReader)
        {
            string UserID = userReader.GetString(0);
            userReader.Close();
            //string query = "select Name from [Roles] where ID in (select RoleID from UserRoles1 where UserID = @username)";
            SqlCommand getRole = new SqlCommand("getUserRole", conn);
            getRole.CommandType = System.Data.CommandType.StoredProcedure;
            getRole.Parameters.AddWithValue("@username", UserID);
            //Execute Query
            SqlDataReader roleReader = getRole.ExecuteReader();
            roleReader.Read();
            string roleName = roleReader.GetString(0);
            roleReader.Close();
            return roleName;
        }
    }
}