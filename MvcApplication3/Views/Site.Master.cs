﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace SampleFacebook.Views
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConnectDB();
        }
        public void ConnectDB()
        {
            SqlConnection con = new SqlConnection(
                WebConfigurationManager.ConnectionStrings["SampleFacebookDBConn"].ConnectionString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                DisplayMessage(this, "Connection to the database Successful");
            }
        }
        static public void DisplayMessage(Control page, string msg)
        {
            string myScript = String.Format("alert('{0}')", msg);
            ScriptManager.RegisterStartupScript(page, page.GetType(), "myScript", myScript, true);
        }
    }
}