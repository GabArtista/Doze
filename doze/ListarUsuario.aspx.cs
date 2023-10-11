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


    void LoadGrid()
    {
        DataSet ds = UsuarioBD.ListarUsuarios();
        Funcoes.FillGrid(gdvUsuarios, ds, lblMsg);
        LoadRepeat(ds);
    }

    void LoadRepeat(DataSet ds)
    {
        int qtd = Funcoes.CountDataSet(ds);
        if(qtd > 0)
        {
            rptUsuarios.DataSource = ds.Tables[0].DefaultView;
            rptUsuarios.DataBind();
        }
    }

    void LoadManualGrid(DataSet ds)
    {
        int qtd = Funcoes.CountDataSet(ds);
        if (qtd > 0)
        {
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                lblLinhas.Text += "<tr><tb>" + dr["IDUsu"].ToString() + "<tr/><tr/>" + "<tr><tb>" + dr["EmailUsu"].ToString() + "<tr/><tr/>" + "<tr><tb>" + dr["_usuEmail"].ToString() + "<tr/><tr/>" + "<tr><tb>" + dr["_usuTelefone"].ToString() + "<tr/><tr/>";
            }
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