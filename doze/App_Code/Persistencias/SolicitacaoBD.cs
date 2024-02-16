using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Descrição resumida de SolicitacaoBD
/// </summary>
public class SolicitacaoBD
{
    /// <summary>
    /// Metodo responsavel por cadastrar uma nova Solicitação no BD MYSQL
    /// </summary>
    /// <param name="Solicitacao">Instancia de objeto Solicitação Preenchido (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(Solicitacao solicitacao, int idUsu)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO solicitacao (IDUsu, IDCnt, IDFop, DataSlc, DescricaoSlc, ObservacaoSlc, DataFechamentoSlc, LinkTrelloSlc, StatusSlc, GMailSlc, GSenhaSlc, ValorAcordadoSlc, EstrategiacobrancaSlc, IDadm) VALUES (" + idUsu + ",1,1, ?data, ?descricao, 'Aguardando..', '2023-07-20','Aguardando..', 'Aguardando..', 'Aguardando..', 'Aguardando..', 0, 'Aguardando..', 0);";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?data", solicitacao._slcData));
            cmd.Parameters.Add(ConexaoBD.Parametro("?descricao", solicitacao._slcDescricao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?observacao", solicitacao._slcObservacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?dataFechamento", solicitacao._slcDataFechamento));
            cmd.Parameters.Add(ConexaoBD.Parametro("?linkTrelo", solicitacao._slcLinkTrello));
            cmd.Parameters.Add(ConexaoBD.Parametro("?status", solicitacao._slcStatusSolicitacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?gMail", solicitacao._slcGmail));
            cmd.Parameters.Add(ConexaoBD.Parametro("?gSenha", solicitacao._slcGsenha));
            cmd.Parameters.Add(ConexaoBD.Parametro("?valorAcordado", solicitacao._slcValorAcordado));
            cmd.Parameters.Add(ConexaoBD.Parametro("?estrategiaCobranca", solicitacao._slcEstrategiaCobranca));
            cmd.Parameters.Add(ConexaoBD.Parametro("?idAdm", solicitacao._slcIDAdm));
            cmd.ExecuteNonQuery(); // Só par DML (Comandos SQL que não retornam valores como resposta)
            conn.Close();
            conn.Dispose(); //Limpar cach
            cmd.Dispose(); //Limpar cach
        }
        catch (Exception ex)
        {
            retorno = -2;
        }
        return retorno;
    }

    /// <summary>
    /// Metodo para Listar as Solicitações que chegaram
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarSolicitacoes()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM solicitacao";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            adp.Fill(ds);
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return ds;

        }
        catch (Exception ex)
        {
            return null;
        }

    }

    /// <summary>
    /// Metodo para Listar as Solicitações que chegaram
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarSolicitacoesEUsuarios()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT solicitacao.IDSlc, usuario.nomeUsu, solicitacao.DescricaoSlc, solicitacao.DataSlc, solicitacao.StatusSlc FROM solicitacao INNER JOIN usuario ON solicitacao.idUsu = usuario.idUsu; ";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            adp.Fill(ds);
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            return ds;

        }
        catch (Exception ex)
        {
            return null;
        }

    }
    /// <summary>
    /// Metodo para Listar as Solicitações que correspondem a um certo usuario
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarSolicitacoesDeUsuarios(int id)
    {
        DataSet ds = new DataSet();
        try
        {

            
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM solicitacao WHERE IDUsu = ?id;";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?id", id));
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            adp.Fill(ds);
            cmd.Dispose();
            conn.Close();
            conn.Dispose();
            

        }
        catch (Exception ex)
        {
            return null;
        }
        return ds;
    }


    /// <summary>
    /// Metodo responsavel por atualizar os registros de Solicitação do banco de dados
    /// </summary>
    /// <param name="Solicitacao"></param>
    /// <returns></returns>
    public static int Update(Solicitacao solicitacao)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE solicitacao SET IDCnt = ?idCnt, IDFop = ?idFop, DataSlc = ?data, DescricaoSlc = ?descricao, ObservacaoSlc = ?observacao, DataFechamentoSlc = ?dataFechamento, LinkTrelloSlc = ?linkTrello, StatusSlc = ?status, GMailSlc = ?gMail, GSenhaSlc = ?gSenha, ValorAcordadoSlc = ?valorAcordado, EstrategiaCobrancaSlc = ?estrategiaCobranca  WHERE IDSlc = ?id";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?id", solicitacao._slcID));
            cmd.Parameters.Add(ConexaoBD.Parametro("?data", solicitacao._slcData));
            cmd.Parameters.Add(ConexaoBD.Parametro("?descricao", solicitacao._slcDescricao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?observacao", solicitacao._slcObservacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?dataFechamento", solicitacao._slcDataFechamento));
            cmd.Parameters.Add(ConexaoBD.Parametro("?linkTrello", solicitacao._slcLinkTrello));
            cmd.Parameters.Add(ConexaoBD.Parametro("?status", solicitacao._slcStatusSolicitacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?gMail", solicitacao._slcGmail));
            cmd.Parameters.Add(ConexaoBD.Parametro("?gSenha", solicitacao._slcGsenha));
            cmd.Parameters.Add(ConexaoBD.Parametro("?valorAcordado", solicitacao._slcValorAcordado));
            cmd.Parameters.Add(ConexaoBD.Parametro("?estrategiaCobranca", solicitacao._slcEstrategiaCobranca));
            cmd.Parameters.Add(ConexaoBD.Parametro("?idAdm", solicitacao._slcIDAdm));

            //Atualizando tipo de contrato
            //pegar id do obj
            TipoDeContrato cnt = new TipoDeContrato();
            cnt = solicitacao.tdc;
            //Atualizando tipo de contrato
            //pegar id do obj
            FormaDePagamento fop = new FormaDePagamento();
            fop = solicitacao.fop;
            cmd.Parameters.Add(ConexaoBD.Parametro("?idCnt", cnt._cntID));
            cmd.Parameters.Add(ConexaoBD.Parametro("?idFop", fop._fopID));

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            error = -2;
        }
        return error;

    }
    /// <summary>
    /// Metodo responsavel por Cadastrar o id do ADM que abriu a Solcitação na colina IDADM
    /// </summary>
    /// <param name="Solicitacao"></param>
    /// <returns></returns>
    public static int admResponsavel(int idAdm, int idSlc)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE solicitacao SET IDAdm = ?idAdm  WHERE IDSlc = ?id";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?idAdm", idAdm));
            cmd.Parameters.Add(ConexaoBD.Parametro("?id", idSlc));

            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
            cmd.Dispose();
        }
        catch (Exception ex)
        {
            error = -2;
        }
        return error;
    }
    /// <summary>
    /// Selecionar uma solicitação especifica
    /// </summary>
    /// <returns></returns>
    public static Solicitacao SelecionaSolicitacao(string id)
    {
        Solicitacao slc = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT solicitacao.IDCnt, formadepagamento.NomeFop, formadepagamento.ObservacaoFop, formadepagamento.StatusAtivacaoFop, tipodecontrato.NomeCnt, tipodecontrato.ObservacaoCnt, tipodecontrato.StatusAtivacaoCnt, solicitacao.IDFop, solicitacao.IDSlc, solicitacao.DescricaoSlc, solicitacao.DataFechamentoSlc, solicitacao.DataSlc, solicitacao.EstrategiaCobrancaSlc, solicitacao.GMailSlc, solicitacao.GSenhaSlc, solicitacao.LinkTrelloSlc, solicitacao.ObservacaoSlc, solicitacao.StatusSlc, solicitacao.ValorAcordadoSlc, usuario.IDUsu, usuario.NomeUsu, usuario.EmailUsu, usuario.SenhaUsu, usuario.TelefoneUsu FROM solicitacao INNER JOIN usuario ON solicitacao.IDUsu = usuario.IDUsu INNER JOIN tipodecontrato ON solicitacao.IDCnt = tipodecontrato.IDCnt INNER JOIN formadepagamento ON solicitacao.IDFop = formadepagamento.IDFop WHERE IDSlc = " + id;
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?id", id));

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            slc = new Solicitacao();
            slc._slcID = Convert.ToInt32(dr["IDSlc"].ToString());
            slc._slcDescricao = dr["DescricaoSlc"].ToString();
            slc._slcData = Convert.ToDateTime(dr["DataSlc"].ToString());
            slc._slcObservacao = dr["ObservacaoSlc"].ToString();
            slc._slcDataFechamento = Convert.ToDateTime(dr["DataFechamentoSlc"].ToString()); 
            slc._slcLinkTrello = dr["LinkTrelloSlc"].ToString();
            slc._slcStatusSolicitacao = dr["StatusSlc"].ToString();
            slc._slcGmail = dr["GMailSlc"].ToString();
            slc._slcGsenha= dr["GSenhaSlc"].ToString();
            slc._slcValorAcordado = Convert.ToInt32(dr["ValorAcordadoSlc"].ToString());
            slc._slcEstrategiaCobranca = dr["EstrategiaCobrancaSlc"].ToString();

            Usuario usuario = new Usuario();
            usuario._usuID = Convert.ToInt32(dr["IDUsu"].ToString());
            usuario._usuNome = dr["NomeUsu"].ToString();
            usuario._usuEmail = dr["EmailUsu"].ToString();
            usuario._usuSenha = dr["SenhaUsu"].ToString();
            usuario._usuTelefone = dr["TelefoneUsu"].ToString();

            slc.usu = usuario;

            FormaDePagamento forma = new FormaDePagamento();
            forma._fopID = Convert.ToInt32(dr["IDFop"].ToString());
            forma._fopNome = dr["NomeFop"].ToString();
            forma._fopObservacao = dr["ObservacaoFop"].ToString();
            forma._fopStatusAtivacao = (bool) Convert.ToBoolean(Convert.ToInt32(dr["StatusAtivacaoFop"].ToString()));

            slc.fop = forma;

            TipoDeContrato contrato = new TipoDeContrato();
            contrato._cntID = Convert.ToInt32(dr["IDCnt"].ToString());
            contrato._cntNome = dr["NomeCnt"].ToString();
            contrato._cntObservacao = dr["ObservacaoCnt"].ToString();
            contrato._cntStatusAtivacao = (bool) Convert.ToBoolean(Convert.ToInt32(dr["StatusAtivacaoCnt"].ToString()));

            slc.tdc = contrato;

        }

        return slc;
    }
}