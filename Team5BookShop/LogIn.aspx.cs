﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    UserBusinessLogic userBusinessLogic = new UserBusinessLogic();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string userName = TextBox1.Text;
        string password = Password1.Value;
        bool isValid = userBusinessLogic.LoginVerification(userName, password);

        if(isValid)
        {
            Session["userId"] = userBusinessLogic.GetUserIDByUserName(userName);
            Label3.Text = "Success User";
            Response.Redirect("~/Main.aspx");
        }
        else
        {
            Label3.Text = "Invalid User";
        }    
    }

}