using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NegociacaoAdm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Checkservic_Clicked(object sender, EventArgs e)
    {
        

        //Como Atribuir esta classe
    }

    protected void btnLead_Click(object sender, EventArgs e)
    {

        //Informação do Lead
        String nome = txtNome.Text;
        String email = txtEmail.Text;
        String senha = txtSenha.Text;
        String telefone = txtTelefone.Text;
        String descricao = txtDescricao.Text;

        //Informações do contrato
        String observacaoContrato = txtObservacaoContrato.Text;
        String status = txtStatus.Text;
        String dataFechamento = txtDiaFechamento.Text;
        String linkTrello = txtLinkTrello.Text;
        String gMail = txtGmail.Text;
        String gSenha = txtGSenha.Text;
        String valor = txtValorAcordado.Text;
        String estrategiaCobranca = txtEstrategiaDecobranca.Text;

        //Informação do serviço
        
        //Como fazer

        //Informação da Forma de Pagamento
        String formaPagamento = txtFormaDePagamento.Text;
        String observacaoFop = txtObservacaoFop.Text;


        //Informação Tipo de Contrato

        String tipoContrato = dpdTipoContrato.Text;
        String observacaoTipoContrato = txtObservacaoTipoContrato.Text;

        Response.Redirect("ListaSolicitacao.aspx");
    }
}