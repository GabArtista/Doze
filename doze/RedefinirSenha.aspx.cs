using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RedefinirSenha : System.Web.UI.Page
{


    //Page Load é execultado quando a pagina é carregada!
    protected void Page_Load(object sender, EventArgs e)
    {
        //Roda quando carrega a pagina
        //1- Nativa: Pela URL
        //1- Nativa: Refresh(F5)
        //2- Postback: Componente HTML
    }

    protected void btnRedefinir_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtSenha.Text))
        {

            String email = txtEmail.Text;
            String senha = txtSenha.Text;
            Usuario u1 = UsuarioBD.SelecionaUsuarioPorEmail(email);
            
            if (u1 != null)
            {
                String senhaUsu = u1._usuSenha;
                if (Funcoes.HashSHA512(senha) != senhaUsu)
                {
                    u1._usuSenha = Funcoes.HashSHA512(senha);
                    UsuarioBD.Update(u1);
                }
                
            }
            else if (u1 == null)
            {
                Response.Redirect("Home.aspx");
            }
        }

    }

}