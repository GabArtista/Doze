using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarUsuario : System.Web.UI.Page
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

        //Carregar Lista
        if (!Page.IsPostBack)
        {
            LoadGrid();
        }
    }

    /// <summary>
    /// Carrega o grid para a função que monta os atributos da classe na tabela 
    /// </summary>
    void LoadGrid()
    {
        DataSet ds = UsuarioBD.ListarUsuarios();
        Funcoes.FillGrid(gdvUsuarios, ds, lblMsg);
        LoadManualGrid(ds);
    }

    /// <summary>
    /// Carrega o grid para a função que conta a quantidade de linhas que a tabela vai ter 
    /// </summary>
    /// <param name="ds"></param>
    void LoadManualGrid(DataSet ds)
    {
        int qtd = Funcoes.CountDataSet(ds);

    }
    void LoadRepeat(DataSet ds)
    {
        int qtd = Funcoes.CountDataSet(ds);
        if(qtd > 0)
        {
            gdvUsuarios.DataSource = ds.Tables[0].DefaultView;
            gdvUsuarios.DataBind();
        }
    }

    

    protected void btnEditar_Click(object sender, EventArgs e)
    {

        Response.Redirect("EditarUsuario.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ADM.aspx");

    }

    protected void btnCriar_Click(object sender, EventArgs e)
    {


        Response.Redirect("CriarUsuario.aspx");

    }
}