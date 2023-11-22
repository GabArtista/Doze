using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListarMidia : System.Web.UI.Page
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
    /// <summary>
    /// Metodo que é ativado quando aperta o botão "Criar"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnCriar_Click(object sender, EventArgs e)
    {


        Response.Redirect("CriarMidia.aspx");

    }
    /// <summary>
    /// Metodo que é ativado quando aperta o botão "Votlar"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ADM.aspx");

    }
    /// <summary>
    /// Solicitar carregamento de lista de Contratos para a classe de conexão com o banco de dados
    /// </summary>
    void LoadGrid()
    {
        DataSet ds = MidiaBD.ListarMidias();
        Funcoes.FillGrid(gdvMidia, ds, lblMsg);
    }
    
    /// <summary>
    /// Metodo responsavel por atribuir funcionalidade para os botões gerados com as tabelas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void gdvMidia_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = Convert.ToInt32(e.CommandArgument.ToString());

        //Se o comando Encaminhar for precionado 
        if (e.CommandName == "Encaminhar")
        {
            Response.Redirect("http://localhost:49677/EditarMidia.aspx?cnt=" + codigo);

        }

    }
}   