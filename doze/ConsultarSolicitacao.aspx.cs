using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConsultarSolicitacao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Checkservic_Clicked(object sender, EventArgs e)
    {


        //Como Atribuir esta classe
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarSolicitacaoUsuario.aspx");

    }
}