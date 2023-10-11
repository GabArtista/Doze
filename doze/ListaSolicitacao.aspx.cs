using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListaSolicitacao : System.Web.UI.Page
{
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
}