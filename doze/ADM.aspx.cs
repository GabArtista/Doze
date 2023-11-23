using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ADM : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if ((Session["USUARIO"] != null))
        {

            Usuario usu = (Usuario)Session["USUARIO"];

            if (Request.QueryString["emailsembase"] != null && Request.QueryString["emailcombase"] != null)
            {
                string emailsembase = Request.QueryString["emailsembase"].ToString();
                string emailcombase = Request.QueryString["emailcombase"].ToString();
                string emailBaseRetorno = Funcoes.HashBase64Returns(emailcombase);
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        Session["USUARIO"] = null;
        Response.Redirect("Login.aspx");
    }


}