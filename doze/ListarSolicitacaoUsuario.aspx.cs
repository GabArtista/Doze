using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarSolicitacaoUsuario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Sucesso! Agora é só aguardar que nossa equipe vai entrar em contato! ');", true);

        //lblUrl.Text = Request.QueryString["email"].ToString();
        if ((Session["USUARIO"] != null))
        {

            Usuario usu = (Usuario)Session["USUARIO"];
            if (!Page.IsPostBack)
            {
                LoadGrid();
                
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("Home.aspx");

    }

    /// <summary>
    /// Metodo para Solicitar o Carregamento da Lista de Solicitações a classe de banco de dados
    /// </summary>
    void LoadGrid()
    {
        Usuario usu = (Usuario)Session["USUARIO"];
        DataSet ds = SolicitacaoBD.ListarSolicitacoesDeUsuarios(usu._usuID);


        Funcoes.FillGrid(gdvSolicitacoesUsuario, ds, lblMsg);
    }
    /// <summary>
    /// Classe que aciona o botão editar na tabela de listagem das solicitações recebidas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvSolicitacao_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = Convert.ToInt32(e.CommandArgument.ToString());

        //Se o comando Encaminhar for precionado 
        if (e.CommandName == "Encaminhar")
        {

            //Usuario usu = (Usuario)Session["USUARIO"];
            SolicitacaoBD.admResponsavel(Convert.ToInt32(Session["USUARIOID"]), codigo);
            Response.Redirect("http://localhost:49677/ConsultarSolicitacao.aspx?slc=" + codigo);
        }

    }
}