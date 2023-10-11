using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarServico : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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

    protected void btnEditar_Click(object sender, EventArgs e)
    {

        Response.Redirect("EditarServico.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ADM.aspx");

    }

    protected void btnCriar_Click(object sender, EventArgs e)
    {


        Response.Redirect("CriarServico.aspx");

    }
    /// <summary>
    /// Metodo para solicitar a listagem de contratos para a classe de conexao com o banco de dados
    /// </summary>
    void LoadGrid()
    {
        DataSet ds = TipoDeContratoBD.ListarTiposDeContratos();
        Funcoes.FillGrid(gdvSolicitacao, ds, lblMsg);
    }
}