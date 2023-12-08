using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    /// <summary>
    /// Metodo que carrega quando abre a pagina
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["emailsemabase"] != null && Request.QueryString["emailcombase"] != null)
            {
                string emailsemabase = Request.QueryString["emailsemabase"].ToString();
                string emailcombase = Request.QueryString["emailcombase"].ToString();
            }
        }
    }
    /// <summary>
    /// Botão que cria a primeira solicitação do cliente.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLead_Click(object sender, EventArgs e)
    {
        

        //Validar se o e-mail ja esta cadastrado
        //Se sim, Perguntar se a conta pertence ao usuario (Como: Solicitando a senha) Jogar ele para a pagina dele. Notificar.
        Usuario usu = new Usuario();
        
        usu._usuNome = txtNome.Text;
        usu._usuEmail = txtEmail.Text;
        usu._usuSenha = Funcoes.HashSHA512(txtSenha.Text);
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
        slc._slcDataFechamento = dataHoraAtual; // Fazer: Iniciar esta data manualmente zerada
        slc._slcLinkTrello = "Em Andamento";
        slc._slcStatusSolicitacao = "Em Andamento...";
        slc._slcGmail = "Em Andamento...";
        slc._slcGsenha = "Em Andamento...";
        slc._slcValorAcordado = 0;
        slc._slcEstrategiaCobranca = "Em Andamento...";
        slc._slcIDAdm = 0;

        Boolean temerro = false;
        //Verificando se todos os campos fotam preenchidos:
        if (usu._usuNome == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Nome não pode ser vazio.');", true);
        }

        if (usu._usuEmail == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: E-mail não pode ser vazio.');", true);
        }

        if (usu._usuTelefone == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Telefone não pode ser vazio.');", true);
        }

        if (usu._usuSenha == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Senha não pode ser vazio');", true);
        }

        if (slc._slcDescricao == "")
        {
            temerro = true;
            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto: Descricao não pode ser vazio');", true);
        }

        if(temerro == false)
        {
            UsuarioBD.Insert(usu);//Cria usuario
            int idUsu;
            idUsu = UsuarioBD.puxarIDUsuarioCadastrado();//Puchando o ID do Ultimo Usuario Cadastrado
            SolicitacaoBD.Insert(slc, idUsu);// Cria Solicitação

            Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Sucesso!');", true);
        }
        
            
    }


}