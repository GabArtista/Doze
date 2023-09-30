using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoginSor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Roda quando carrega a pagina
        //1- Nativa: Pela URL
        //1- Nativa: Refresh(F5)
        //2- Postback: Componente HTML
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        String email = txtemail.Text;
        String senha = txtSenha.Text;
    }
}