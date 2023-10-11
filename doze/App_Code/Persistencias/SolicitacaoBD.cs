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
    public static int Insert(Solicitacao solicitacao)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO solicitacao (IDUsu, IDCnt, IDFop, DataSlc, DescricaoSlc, ObservacaoSlc, DataFechamentoSlc, LinkTrelloSlc, StatusSlc, GMailSlc, GSenha, ValorAcordado, Estrategiacobranca, IDadm) VALUES (1,1,1, ?data, ?descricao, 'Aguardando..', '2023-07-20','Aguardando..', 'Aguardando..', 'Aguardando..', 'Aguardando..', 0, 'Aguardando..', 0);";
            
            
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
            conn.Dispose();
            cmd.Dispose();
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
            string sql = "SELECT solicitacao.IDSlc, usuario.nomeUsu, solicitacao.DescricaoSlc, solicitacao.DataSlc FROM solicitacao INNER JOIN usuario ON solicitacao.idUsu = usuario.idUsu; ";
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
            string sql = "UPDATE solicitacao SET DataSlc = ?data, DescricaoSlc = ?descricao, ObservacaoSlc = ?observacao, DataFechamentoSlc = ?dataFechamento, LinkTrelloSlc = ?linkTrelo, StatusSlc = ?status, GMailSlc = ?gMail, GSenhaSlc = ?gSenha, ValorAcordadoSlc = ?valorAcordado, EstrategiaCobrancaSlc = ?estrategiaCobranca, IDAdm = ?idAdm  WHERE IDSlc = ?id";
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
}