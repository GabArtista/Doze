using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["emailsemabase"] != null && Request.QueryString["emailcombase"] != null)
        {
            string emailsemabase = Request.QueryString["emailsemabase"].ToString();
            string emailcombase = Request.QueryString["emailcombase"].ToString();
        }

    }

    protected void btnLead_Click(object sender, EventArgs e)
    {
        Usuario usu = new Usuario();
        
        usu._usuNome = txtNome.Text;
        usu._usuEmail = txtEmail.Text;
        usu._usuSenha = txtSenha.Text;
        usu._usuTelefone = txtTelefone.Text;
        usu._usuTipoUsuario = "Cliente";
        usu._usuStatusConexao = false;
        //status ativação sempre True apartir da criação. Atribuição e validação desnecessaria 
        usu._usuStatusAtivacao = true;


        Solicitacao slc = new Solicitacao();
        //Pegar Data hora to sistema
        DateTime dataHoraAtual = DateTime.Now;
        
        slc._slcData = dataHoraAtual;
        slc._slcDescricao = txtDescricao.Text;
        slc._slcObservacao = "Em Andamento...";
        slc._slcDataFechamento = dataHoraAtual; // Iniciar esta data manualmente zerada
        slc._slcLinkTrello = "Em Andamento";
        slc._slcStatusSolicitacao = "Em Andamento...";
        slc._slcGmail = "Em Andamento...";
        slc._slcGsenha = "Em Andamento...";
        slc._slcValorAcordado = 0;
        slc._slcEstrategiaCobranca = "Em Andamento...";
        slc._slcIDAdm = 0;

        

        UsuarioBD.Insert(usu);
        SolicitacaoBD.Insert(slc);

    }


}