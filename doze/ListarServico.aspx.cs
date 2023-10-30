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
        DataSet ds = ServicoBD.ListarServicos();
        Funcoes.FillGrid(gdvServicos, ds, lblMsg);
    }
    /// <summary>
    /// Metodo responsavel por colocar icone e trocar ele de acordo com o click do usuario
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvServicos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //Verificar se o componente que nós precisamos é uma linha válida
        //body
        LinkButton lb = (LinkButton)e.Row.Cells[5].FindControl("lkb_ativar");

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.Cells[4].Text == "0")
            {
                e.Row.Cells[4].Text = "<i class='fa fa-times text-danger' />";
                lb.CommandName = "Ativar";
                lb.Text = "<i class='fa fa-check text-success'> </i>";
            }
            else
            {
                e.Row.Cells[4].Text = "<i class='fa fa-check text-success' />";
                lb.CommandName = "Inativar";
                lb.Text = "<i class='fa fa-times text-danger'> </i>";
            }

        }



    }
    /// <summary>
    /// Metodo responsavel por atribuir funcionalidade para os botões gerados com as tabelas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvServicos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int ativacao = 0;
        int codigo = Convert.ToInt32(e.CommandArgument.ToString());

        //Se o comando Encaminhar for precionado 
        if (e.CommandName == "Encaminhar")
        {
            Response.Redirect("http://localhost:49677/EditarServico.aspx?svc=" + codigo);

        }

        //Se o comando Ativar/Desativar sor pressionado
        if (e.CommandName == "Ativar")
        {
            ativacao = 1;


        }

        //Recarregar Grid se a atualização do Status de Atividade for concluido com sucesso
        if (ServicoBD.ActiveInServico(codigo, ativacao) == 0)
        {
            LoadGrid();
        }
    }
}