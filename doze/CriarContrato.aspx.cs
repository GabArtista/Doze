using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CriarContrato : System.Web.UI.Page
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
    //Se cliecar no checkbox
    protected void chbStatusAtivacao_Click(object sender, EventArgs e)
    {
        _statusAtivacao = chbStatusAtivacaoCnt.Checked ? 1 : 0;
    }
    protected void btnCriar_Click(object sender, EventArgs e)
    {
        TipoDeContrato cnt = new TipoDeContrato();

        cnt._cntNome = txtNomeCnt.Text;
        cnt._cntObservacao = txtObservacaoCnt.Text;

        //Status de ativação apartir da criação sempre sera True
        cnt._cntStatusAtivacao = true;
        /* Desnecessario
        if (_statusAtivacao == 1)
        {
            cnt._fopStatusAtivacao = true;
        }
        */


        TipoDeContratoBD.Insert(cnt);

        //Se o cadastro for sussedido:
        Response.Redirect("ListarContrato.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarContrato.aspx");

    }
}