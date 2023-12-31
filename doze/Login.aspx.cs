﻿using System;
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
            String senha = txtSenha.Text;
            Usuario u1 = UsuarioBD.AuthenticaUsuarioV2(email, Funcoes.HashSHA512(senha));

            if (u1 != null)
            {
                                
                //Sessão: Partição de memoria (cache ou Coockie) no servidor
                //Colocando ID do Usuario Logado em Sessao
                
                Session["USUARIO"] = u1;//Guardando e-mail e senha do usuario logado

                Response.Redirect("ADM.aspx?emailsembase=" + u1._usuEmail + "&emailcombase=" + Funcoes.HashBase64(u1._usuEmail));
            }
            else if(u1 == null)
            {
                Response.Redirect("Home.aspx");
            }
        }




    }
}