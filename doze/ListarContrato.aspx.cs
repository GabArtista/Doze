using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarContrato : System.Web.UI.Page
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

        Response.Redirect("EditarContrato.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ADM.aspx");

    }

    protected void btnCriar_Click(object sender, EventArgs e)
    {


        Response.Redirect("CriarContrato.aspx");

    }
    
    /// <summary>
    /// Solicitar carregamento de lista de Contratos para a classe de conexão com o banco de dados
    /// </summary>
    void LoadGrid()
    {
        DataSet ds = TipoDeContratoBD.ListarTiposDeContratos();
        Funcoes.FillGrid(gdvContratos, ds, lblMsg);
    }
}