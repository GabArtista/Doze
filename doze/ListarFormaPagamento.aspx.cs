using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class ListarFormaPagamento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Metodo que ativa quando a pagina carrega
        //lblUrl.Text = Request.QueryString["email"].ToString();
        if ((Session["USUARIO"] != null))
        {

            Usuario usu = (Usuario)Session["USUARIO"];


            if (usu != null)
            {
                if (!Page.IsPostBack)
                {
                    LoadGrid();
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }
    /// <summary>
    /// Metodo que carrega a lista de forma de pagamento
    /// </summary>
    void LoadGrid()
    {
        DataSet ds = FormaDePagamentoBD.ListarFormasDePagamentos();
        Funcoes.FillGrid(gdvFormasDePagamentos, ds, lblMsg);
    }
    /// <summary>
    /// Metodo que ativa o botão na lista da tabela
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvFormaPagamento_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //Verificar se o componente que nós precisamos é uma linha válida
        //body
        LinkButton lb = (LinkButton)e.Row.Cells[4].FindControl("lkb_ativar");

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.Cells[3].Text == "0")
            {
                e.Row.Cells[3].Text = "<i class='fa fa-times text-danger' />";
                lb.CommandName = "Ativar";
                lb.Text = "<i class='fa fa-check text-success'> </i>";
            }
            else
            {
                e.Row.Cells[3].Text = "<i class='fa fa-check text-success' />";
                lb.CommandName = "Inativar";
                lb.Text = "<i class='fa fa-times text-danger'> </i>";
            }

        }



    }
   

    protected void btnEditar_Click(object sender, EventArgs e)
    {

        Response.Redirect("EditarFormaPagamento.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ADM.aspx");

    }

    protected void btnCriar_Click(object sender, EventArgs e)
    {


        Response.Redirect("CriarFormaPagamento.aspx");

    }

    /// <summary>
    /// Classe que aciona o botão editar na tabela de listagem das solicitações recebidas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvFormaPagamento_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int ativacao = 0;
        int codigo = Convert.ToInt32(e.CommandArgument.ToString());

        //Se o comando Encaminhar for precionado 
        if (e.CommandName == "Encaminhar")
        {
            FormaDePagamento fop1 = new FormaDePagamento();
            fop1._fopID = codigo;
            


            //Sessão: Partição de memoria (cache ou Coockie) no servidor
            Session["FORMAPAGAMENTO"] = fop1;
            Response.Redirect("http://localhost:49677/EditarFormaPagamento.aspx?" + codigo);

        }

        //Se o comando Ativar/Desativar sor pressionado
        if (e.CommandName == "Ativar")
        {
            ativacao = 1;


        }
        //Recarregar Grid se a atualização do Status de Atividade for concluido com sucesso
        if (FormaDePagamentoBD.ActiveInFormaDePagamento(codigo, ativacao) == 0)
        {
            LoadGrid();
        }

    }
}