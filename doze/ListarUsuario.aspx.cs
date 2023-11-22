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
        if (Session["USUARIO"] != null)
        {

            Usuario usu = (Usuario)Session["USUARIO"];

            //Preencher os campos do Formulario dessa foram:

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

        //Cria um script facilmente:
        //Page.ClientScript.RegisterStartupScript(GetType(), "alerta", "alert('Olá');", true);
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


   

    

    
    /// <summary>
    /// Metodo responsavel por colocar icone e trocar ele de acordo com o click do usuario
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //Verificar se o componente que nós precisamos é uma linha válida
        //body
        LinkButton lb = (LinkButton)e.Row.Cells[7].FindControl("lkb_ativar");

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.Cells[6].Text == "0")
            {
                e.Row.Cells[6].Text = "<i class='fa fa-times text-danger' />";
                lb.CommandName = "Ativar";
                lb.Text = "<i class='fa fa-check text-success'> </i>";
            }
            else
            {
                e.Row.Cells[6].Text = "<i class='fa fa-check text-success' />";
                lb.CommandName = "Inativar";
                lb.Text = "<i class='fa fa-times text-danger'> </i>";
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

    protected void gdvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int ativacao = 0;
        int codigo = Convert.ToInt32(e.CommandArgument.ToString());

        //Se o comando Encaminhar for precionado 
        if (e.CommandName == "Encaminhar")
        {
            Session["USUARIOID"] = codigo;
            Response.Redirect("http://localhost:49677/EditarUsuario.aspx?usu=" + codigo);

        }

        //Se o comando Ativar/Desativar sor pressionado
        if (e.CommandName == "Ativar")
        {
            ativacao = 1;

            
        }

        //Recarregar Grid se a atualização do Status de Atividade for concluido com sucesso
        if (UsuarioBD.ActiveInUser(codigo, ativacao) == 0)
        {
            LoadGrid();
        }
    }
}