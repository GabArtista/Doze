using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CriarFormaPagamento : System.Web.UI.Page
{
    // Variavel para passar Satus de ativação de uma classe para outra
    private int _statusAtivacao = 0;
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
    }

    protected void chbStatusAtivacao_Click(object sender, EventArgs e)
    {
        _statusAtivacao = chbStatusAtivacaoFop.Checked ? 1 : 0;
    }
    protected void btnCriar_Click(object sender, EventArgs e)
    {
        FormaDePagamento fop = new FormaDePagamento();

        fop._fopNome = txtNomeFop.Text;
        fop._fopObservacao = txtObservacaoFop.Text;

        //Status de ativação apartir da criação sempre sera True
        fop._fopStatusAtivacao = true; 
        /* Desnecessario
        if (_statusAtivacao == 1)
        {
            fop._fopStatusAtivacao = true;
        }
        */
        

        FormaDePagamentoBD.Insert(fop);

        //Se o cadastro for sussedido:
        Response.Redirect("ListarFormaPagamento.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarFormaPagamento.aspx");

    }
}