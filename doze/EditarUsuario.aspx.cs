using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditarUsuario : System.Web.UI.Page
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

    protected void chbStatusAtivacao_Click(object sender, EventArgs e)
    {

    }
    protected void btnEditar_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();
        int usuID = Convert.ToInt32(Session["USUARIOID"]);
        usu._usuID = usuID;
        UsuarioBD.SelecionaUsuario(Convert.ToString(usu._usuID));
        usu._usuNome = txtNomeUsu.Text;
        usu._usuEmail = txtEmailUsu.Text;
        usu._usuSenha = txtSenhaUsu.Text;
        usu._usuTelefone = txtTelefoneUsu.Text;
        usu._usuTipoUsuario = txtTipoUsuarioUsu.Text;

        Boolean temerro = false;
        if(usu._usuNome == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Nome não pode ser vazio.');", true);
        }

        if(usu._usuEmail == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Email não pode ser vazio.');", true);
        }

        if(usu._usuTelefone == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Telefone não pode ser vazio.');", true);
        }

        if(temerro == false)
        {
            UsuarioBD.Update(usu);
            Response.Redirect("ListarUsuario.aspx");
        }
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarUsuario.aspx");

    }
}