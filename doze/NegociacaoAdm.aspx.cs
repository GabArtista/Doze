using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NegociacaoAdm : System.Web.UI.Page
{

    //Pegar ID, Status Conexão e Status Ativação do Usuario que esta para ser editado, Usar esta ID, Status Conexão e Status Ativação no Botão responsavel por Etidar o Usuario
    int ID = 0;
    Boolean StatusAtivacao;
    Boolean StatusConexao;
    string TipoDeUsuario;
    protected void Page_Load(object sender, EventArgs e)
    {



        //Colocando valor nos campos de texto
        if (Request.QueryString["slc"] != null)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["slc"].ToString()))
            {

                if (!Page.IsPostBack)
                {




                    string codigo = Request.QueryString["slc"].ToString();
                    //Pegar Objeto da Session:
                    //Usuario usuAdm = (Usuario)Session["USUARIO"];


                    Solicitacao solicitacao = SolicitacaoBD.SelecionaSolicitacao(codigo);
                    txtDescricao.Text = solicitacao._slcDescricao.ToString();
                    txtDiaFechamento.Text = solicitacao._slcDataFechamento.ToString();
                    txtEstrategiaDecobranca.Text = solicitacao._slcEstrategiaCobranca;
                    txtLinkTrello.Text = solicitacao._slcLinkTrello;
                    txtStatus.Text = solicitacao._slcStatusSolicitacao;
                    txtGmail.Text = solicitacao._slcGmail;
                    txtGSenha.Text = solicitacao._slcGsenha;
                    txtEstrategiaDecobranca.Text = solicitacao._slcEstrategiaCobranca;
                    txtValorAcordado.Text = solicitacao._slcValorAcordado.ToString();
                    txtObservacaoContrato.Text = solicitacao._slcObservacao;


                    Usuario usuario = new Usuario();
                    usuario = solicitacao.usu;

                    //Colocar ID, Status Conexão e Status Ativação na variavel global para tratar no metodo do botão editar
                    Session["USUARIOCODIGO"] = usuario._usuID;
                    StatusAtivacao = usuario._usuStatusAtivacao;
                    StatusConexao = usuario._usuStatusConexao;

                    txtNome.Text = usuario._usuNome;
                    txtEmail.Text = usuario._usuEmail;
                    //Guardando e-mail original do usuario para nao perder. Caso o email não sofrer alteração, fornecer o mesmo email novamente!!!
                    Session["USUARIOEMAIL"] = usuario._usuEmail;
                    txtTelefone.Text = usuario._usuTelefone;

                    //Guardando senha original do usuario para não perder. Caso a senha não sofrer alteração, fornecer a mesma senha novamente
                    Session["USUARIOSENHA"] = usuario._usuSenha;



                }


            }
        }



        //carregar forma de pagamento
        LoadGrid();


    }

    /// <summary>
    /// Metodo para Solicitar o Carregamento da Lista de Solicitações a classe de banco de dados
    /// </summary>
    void LoadGrid()
    {
        Label lblMsg = null;
        DataSet ds = FormaDePagamentoBD.ListarFormasDePagamentos();
        Funcoes.ddnGrid(ddnFormaDePagamento, ds, lblMsg);
        LoadDropDown(ds);

    }

    void LoadDropDown(DataSet ds)
    {
        int qtd = Funcoes.CountDataSet(ds);
        if (qtd > 0)
        {
            ddnFormaDePagamento.DataSource = ds.Tables[0].DefaultView;
            ddnFormaDePagamento.DataBind();
        }
    }

    protected void Checkservic_Clicked(object sender, EventArgs e)
    {


        //Como Atribuir esta classe
    }
    /// <summary>
    /// Botão que atualiza os dados no banco de dados
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLead_Click(object sender, EventArgs e)
    {

        if (!String.IsNullOrEmpty(Session["USUARIOCODIGO"].ToString()))
        {
            //USUARIO
            //Informação do Lead
            String nome = txtNome.Text;
            String email = txtEmail.Text;
            String senha = txtSenha.Text;
            String telefone = txtTelefone.Text;
            

            //Criando usuario com a informação nas TextBox do Font End
            Usuario usu = new Usuario();
            //A ID vem do metodo LoadPage
            usu._usuID = Convert.ToInt32(Session["USUARIOCODIGO"].ToString());
            usu._usuNome = nome;
            usu._usuTelefone = telefone;
            usu._usuStatusAtivacao = StatusAtivacao;
            usu._usuStatusConexao = StatusConexao;
            usu._usuTipoUsuario = TipoDeUsuario;






            //SOLICITAÇÃO

            //Informações do contrato
            String observacaoContrato = txtObservacaoContrato.Text;
            String status = txtStatus.Text;
            String dataFechamento = txtDiaFechamento.Text;
            String linkTrello = txtLinkTrello.Text;
            String gMail = txtGmail.Text;
            String gSenha = txtGSenha.Text;
            String valor = txtValorAcordado.Text;
            String estrategiaCobranca = txtEstrategiaDecobranca.Text;
            String descricao = txtDescricao.Text;

            Solicitacao slc = new Solicitacao();

            slc._slcDescricao = descricao;
            slc._slcGmail = gMail;
            slc._slcGsenha = gSenha;
            slc._slcLinkTrello = linkTrello;
            slc._slcObservacao = observacaoContrato;
            slc._slcStatusSolicitacao = status;
            slc._slcValorAcordado = Convert.ToDouble(valor);
            

            //Informação do serviço

            //Como fazer

            //FORMA DE PAGAMENTO
            //Informação da Forma de Pagamento
            String formaPagamento = ddnFormaDePagamento.Text;
            String observacaoFop = txtObservacaoFop.Text;

            //CONTRATO
            //Informação Tipo de Contrato

            String tipoContrato = dpdTipoContrato.Text;
            String observacaoTipoContrato = txtObservacaoTipoContrato.Text;






            //TODOS ESSES IF'S DEVEM PERTENCER A CONCLUSÃO DA ATUALIZAÇÃO COMO UM TODO, E NAO COMO UMA CONDIÇÃO INDIVIDUAL. POIS A CLONCUSÃO DA ATUALIZÃÇÃO DEPENDE DESSES IF'S


            //Verificar se o Email que esta sendo fornecido ja existe nos cadastros dos usuarios



            if (UsuarioBD.SelecionaUsuarioPorEmail(email) == null)
            {
                usu._usuEmail = email;
            }
            else if (UsuarioBD.SelecionaUsuarioPorEmail(email) != null)
            {

                usu._usuEmail = Session["USUARIOEMAIL"].ToString();

            }

            //Verificar se a o campo senha foi preenchido, se sim, subistituir senha no banco
            if (!String.IsNullOrEmpty(txtSenha.Text))
            {

                //Verificar se a senha que deve ser atualizada é igual a antiga senha ja cadastrada
                if (Session["USUARIOSENHA"].ToString() == Funcoes.HashSHA512(txtSenha.Text))
                {
                    // Registra um script de inicialização
                    usu._usuSenha = Session["USUARIOSENHA"].ToString();
                    Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Esta senha é igual a senha anterios! Use uma senha Diferente');", true);

                }
                else
                {
                    usu._usuSenha = Funcoes.HashSHA512(senha);
                    //atualizar usuario
                    UsuarioBD.Update(usu);
                    //Response.Redirect("ListaSolicitacao.aspx");
                }
            }





        }






    }
}
