using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CriarUsuario : System.Web.UI.Page
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


        //Carregar listagem

        if (!Page.IsPostBack)
        {
            LoadGrid();
        }
    }

    protected void chbStatusAtivacao_Click(object sender, EventArgs e)
    {

    }
    protected void btnCriar_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();

        usu._usuNome = txtNomeUsu.Text;
        usu._usuEmail = txtEmailUsu.Text;
        usu._usuSenha = txtSenhaUsu.Text;
        usu._usuTelefone = txtTelefoneUsu.Text;
        usu._usuTipoUsuario = "Cliente";
        //status de Conexão sempre False, Provavelmente é um ADM Cadastrando um cliente.
        usu._usuStatusConexao = false;
        //status ativação sempre True apartir da criação. Atribuição e validação desnecessaria 
        usu._usuStatusAtivacao = true;
        UsuarioBD.Insert(usu);
        //Se ocorrer tudo bem:
        Response.Redirect("ListarUsuario.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarUsuario.aspx");

    }

    /// <summary>
    /// Buscar indormação para listar
    /// </summary>
    void LoadGrid()
    {
        DataSet ds = UsuarioBD.SelectAll();
        Funcoes.FillGrid(gdvUsuarios, ds, lblMsg);
    }
}