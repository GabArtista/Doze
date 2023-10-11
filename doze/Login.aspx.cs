using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{

    //Page Load é execultado quando a pagina é carregada!
    protected void Page_Load(object sender, EventArgs e)
    {
        //Roda quando carrega a pagina
        //1- Nativa: Pela URL
        //1- Nativa: Refresh(F5)
        //2- Postback: Componente HTML
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtSenha.Text))
        {

            String email = txtEmail.Text;
            String senha = Funcoes.HashSHA512(txtSenha.Text);
            
            if (UsuarioBD.AuthenticaUsuario(email, senha) != null)
            {

                Usuario u1 = new Usuario();
                u1._usuEmail = txtEmail.Text;
                u1._usuSenha = Funcoes.HashSHA512(txtSenha.Text);


                //Sessão: Partição de memoria (cache ou Coockie) no servidor
                Session["USUARIO"] = u1;

                Response.Redirect("ADM.aspx?emailsembase=" + u1._usuEmail + "&emailcombase=" + Funcoes.HashBase64(u1._usuEmail));
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }




    }
}