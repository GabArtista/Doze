﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditarFormaPagamento : System.Web.UI.Page
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
    protected void btnEditar_Click(object sender, EventArgs e)
    {
        FormaDePagamentoBD FormaDePagamentoBD = new FormaDePagamentoBD();
        FormaDePagamento fop = new FormaDePagamento();
        // Pega o valor da sessão.
        int fop1 = Convert.ToInt32(Session["FORMAPAGAMENTO"]);
        fop._fopID = fop1;
        FormaDePagamentoBD.SelecionarFormaPagamento(fop);
        fop._fopNome = txtNomeFop.Text;
        fop._fopObservacao = txtObservacaoFop.Text;
        fop._fopStatusAtivacao = false;
        if (_statusAtivacao == 1)
        {
            fop._fopStatusAtivacao = true;
        }else if(_statusAtivacao == 0)
        {
            fop._fopStatusAtivacao = false;
        }


        Boolean temerro = false;
        if (fop._fopNome == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Nome não pode ser vazio.');", true);
        }
        if (fop._fopObservacao == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Observação não pode ser vazio.');", true);
        }
        if (temerro == false)
        {
            FormaDePagamentoBD.Update(fop);
            Response.Redirect("ListarFormaPagamento.aspx");
        }

        

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {


        Response.Redirect("ListarFormaPagamento.aspx");

    }
}