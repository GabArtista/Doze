using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListaSolicitacao : System.Web.UI.Page
{
    /// <summary>
    /// Metodo que carrega quando a pagina abre
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //lblUrl.Text = Request.QueryString["email"].ToString();
        if ((Session["USUARIO"] != null)) { 
            
            Usuario usu = (Usuario)Session["USUARIO"];
            if (!Page.IsPostBack)
            {
                LoadGrid();
            }
        }
        else { 
            Response.Redirect("Login.aspx");
        }
        
    }

    protected void btnEditar_Click(object sender, EventArgs e)
    {

        Response.Redirect("NegociacaoAdm.aspx");

    }
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        
        
        Response.Redirect("ADM.aspx");
        
    }

    /// <summary>
    /// Metodo para Solicitar o Carregamento da Lista de Solicitações a classe de banco de dados
    /// </summary>
    void LoadGrid()
    {

        DataSet ds = SolicitacaoBD.ListarSolicitacoesEUsuarios();


        Funcoes.FillGrid(gdvSolicitacoes, ds, lblMsg);
    }
    /// <summary>
    /// Classe que aciona o botão editar na tabela de listagem das solicitações recebidas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = Convert.ToInt32(e.CommandArgument.ToString());

        //Se o comando Encaminhar for precionado 
        if (e.CommandName == "Encaminhar")
        {
            Response.Redirect("http://localhost:49677/NegociacaoAdm.aspx?usu=" + codigo);

        }

    }
}