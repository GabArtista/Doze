﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormaPagamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //lblUrl.Text = Request.QueryString["email"].ToString();
        if ((Session["USUARIO"] != null))
        {

            Usuario usu = (Usuario)Session["USUARIO"];
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ADM.aspx");

    }
}