using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditarServico : System.Web.UI.Page
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
    }

    protected void chbStatusAtivacao_Click(object sender, EventArgs e)
    {

    }
    protected void btnEditar_Click(object sender, EventArgs e)
    {

        ServicoBD Servico = new ServicoBD();
        Servico svc = new Servico();
        // Pega o valor da sessão.
        int svc1 = Convert.ToInt32(Session["SERVICO"]);
        svc._svcID = svc1;
        ServicoBD.SelecionarServico(svc);
        svc._svcNome = txtNomeSvc.Text;
        svc._svcObservacao = txtObservacaoSvc.Text;
        svc._svcPreco = Convert.ToDouble(txtPrecoSvc.Text);
        svc._svcStatusAtivacao = true;
        


        Boolean temerro = false;
        if (svc._svcNome == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Nome não pode ser vazio.');", true);
        }
        if (svc._svcObservacao == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Observação não pode ser vazio.');", true);
        }
        if (svc._svcPreco == 0)
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Preço não pode ser vazio.');", true);
        }
        if (temerro == false)
        {
            ServicoBD.Update(svc);
            Response.Redirect("ListarServico.aspx");
        }

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarServico.aspx");

    }
}