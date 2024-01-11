using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditarContrato : System.Web.UI.Page
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
        TipoDeContrato cnt = new TipoDeContrato();
        int cntID = Convert.ToInt32(Session["TIPODECONTRATO"]);
        cnt._cntID = cntID;
        TipoDeContratoBD.SelecionarTipoDeContrato(cnt._cntID);
        cnt._cntNome = txtNomeCtr.Text;
        cnt._cntObservacao = txtObservacaoCtr.Text;

        Boolean temerro = false;
        if (cnt._cntNome == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Nome não pode ser vazio.');", true);
        }

        if (cnt._cntObservacao == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Email não pode ser vazio.');", true);
        }

        if (temerro == false)
        {
            TipoDeContratoBD.Update(cnt);
            Response.Redirect("ListarContrato.aspx");
        }
        

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarContrato.aspx");

    }
}