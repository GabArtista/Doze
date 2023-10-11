using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CriarServico : System.Web.UI.Page
{
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

        _statusAtivacao = chbStatusAtivacaoSvc.Checked ? 1 : 0;
    }


    protected void btnCriar_Click(object sender, EventArgs e)
    {
        Servico svc = new Servico();

        svc._svcNome = txtNomeSvc.Text;
        svc._svcPreco = Convert.ToInt32(txtPrecoSlv.Text);
        svc._svcObservacao = TxtObservacao.Text;

        //Status adivação sempre sera True apartir da criação
        svc._svcStatusAtivacao = true;
        /* Desnecessario
        if (_statusAtivacao == 1)
        {
            svc._svcStatusAtivacao = true;
        }
        */
         




        ServicoBD.Insert(svc);

        //Se o cadastro for sussedido:
        Response.Redirect("ListarServico.aspx");

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarServico.aspx");

    }
}