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

    FormaDePagamento fopglob = new FormaDePagamento();
    TipoDeContrato cntglob = new TipoDeContrato();
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


                    Solicitacao solicitacao = SolicitacaoBD.SelecionaSolicitacao(codigo); //INNER JOIN
                    txtDescricao.Text = solicitacao._slcDescricao.ToString();
                    txtDiaFechamento.Text = solicitacao._slcDataFechamento.ToShortDateString();
                    txtLinkTrello.Text = solicitacao._slcLinkTrello;
                    txtStatus.Text = solicitacao._slcStatusSolicitacao;
                    txtGmail.Text = solicitacao._slcGmail;
                    txtGSenha.Text = solicitacao._slcGsenha.ToString();
                    txtValorAcordado.Text = solicitacao._slcValorAcordado.ToString();
                    txtObservacaoContrato.Text = solicitacao._slcObservacao;
                    txtEstrategiaDecobranca.Text = solicitacao._slcEstrategiaCobranca.ToString();

                    //carregar forma de pagamento
                    LoadGrid();

                    //Carregando serviços
                    CriarChecks();

                    fopglob = solicitacao.fop;
                    ddnFormaDePagamento.SelectedValue = Convert.ToString(fopglob._fopID);
                    cntglob = solicitacao.tdc;
                    ddnTipoContrato.SelectedValue = Convert.ToString(cntglob._cntID);


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






    }

    /// <summary>
    /// Metodo para Solicitar o Carregamento da Lista de Solicitações a classe de banco de dados
    /// </summary>
    void LoadGrid()
    {
        Label lblMsg = null;
        DataSet ds = FormaDePagamentoBD.ListarFormasDePagamentos();
        Funcoes.ddnGrid(ddnFormaDePagamento, ds, lblMsg, "NomeFop", "IDFop");
        LoadDropDown(ds, ddnFormaDePagamento);

        DataSet ds2 = TipoDeContratoBD.ListarTiposDeContratos();
        Funcoes.ddnGrid(ddnTipoContrato, ds2, lblMsg, "NomeCnt", "IDCnt");
        LoadDropDown(ds2, ddnTipoContrato);
    }
    /// <summary>
    /// Metodo que Mostra as informações do Banco para o Dropdown.
    /// </summary>
    /// <param name="ds"></param>
    /// <param name="ddn"></param>
    void LoadDropDown(DataSet ds, DropDownList ddn)
    {
        int qtd = Funcoes.CountDataSet(ds);
        if (qtd > 0)
        {
            ddn.DataSource = ds.Tables[0].DefaultView;
            ddn.DataBind();


        }
    }

    /// <summary>
    /// Metodo que Mostra as informações do Banco para o CheckBox.
    /// </summary>
    /// <param name="ds"></param>
    /// <param name="ddn"></param>
    void CriarChecks()
    {
        DataSet ds = ServicoBD.ListarServicos();
        int qtd = Funcoes.CountDataSet(ds);
        if (qtd > 0)
        {

            checkBoxListSvc.DataSource = ds.Tables[0].DefaultView;
            checkBoxListSvc.DataTextField = "NomeSvc";
            checkBoxListSvc.DataValueField = "IDSvc";
            checkBoxListSvc.DataBind();
        }

    }

    protected void btnPegarCheck_Click(object sender, EventArgs e)
    {
        foreach (ListItem item in checkBoxListSvc.Items)
        {
            if (item.Selected) {
                //lblChecks.Text += item.Value + " - " + item.Text;
            }
        }
    }
    protected void Checkservic_Clicked(object sender, EventArgs e)
    {


        //Como Atribuir esta classe
    }
    protected void ddnFormaDePagamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Guarde o valor do ID selecionado


        // Faça algo com o valor
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

            slc._slcID = Convert.ToInt32(Request.QueryString["slc"]);
            slc._slcDescricao = descricao;
            slc._slcGmail = gMail;
            slc._slcGsenha = gSenha;
            slc._slcLinkTrello = linkTrello;
            slc._slcObservacao = observacaoContrato;
            slc._slcStatusSolicitacao = status;
            slc._slcValorAcordado = Convert.ToDouble(valor);
            slc._slcEstrategiaCobranca = estrategiaCobranca;
            slc._slcDataFechamento = Convert.ToDateTime(dataFechamento);



            //Informação do serviço

            //Como fazer

            //FORMA DE PAGAMENTO
            //Informação da Forma de Pagamento

            String observacaoFop = txtObservacaoFop.Text;
            //int idfop = Convert.ToInt32(ddnFormaDePagamento.SelectedValue);
            fopglob._fopID = Convert.ToInt32(ddnFormaDePagamento.SelectedValue.ToString());
            slc.fop = FormaDePagamentoBD.SelecionarFormaDePagamento2(fopglob._fopID);
            //CONTRATO
            //Informação Tipo de Contrato

            String observacaoTipoContrato = txtObservacaoTipoContrato.Text;
            cntglob._cntID = Convert.ToInt32(ddnTipoContrato.SelectedValue.ToString());
            slc.tdc = TipoDeContratoBD.SelecionarTipoDeContrato(cntglob._cntID);



            //CASOS DE ERROS

            Boolean temerro = false;
            if (usu._usuNome == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Nome não pode ser vazio.');", true);
            }

            if (usu._usuEmail == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Email não pode ser vazio.');", true);
            }

            if (usu._usuTelefone == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Telefone não pode ser vazio.');", true);
            }


            if(slc._slcDescricao == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Decrição não pode ser vazio.');", true);
            }

            if (slc._slcDataFechamento == null)
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Data Fechamento não pode ser vazio.');", true);
            }

            if (slc._slcEstrategiaCobranca == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Estratégia de Cobrança não pode ser vazio.');", true);
            }

            if (slc._slcGmail == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Gmail não pode ser vazio.');", true);
            }

            if (slc._slcObservacao == "")
            {
                temerro = true;
                Page.ClientScript.RegisterStartupScript(GetType(), "name", "alert('Campo de Texto Observação não pode ser vazio.');", true);
            }

            



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




                }
            }



            if (temerro == false)
            {
                //Atualizar Solicitação
                if (SolicitacaoBD.Update(slc) == 0)
                {
                    Response.Redirect("ListaSolicitacao.aspx");
                }
            }
            



        }






    }
}
