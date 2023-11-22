using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Classe de conexão da Classe FormaDePagamento com o Banco de Dados
/// </summary>
public class FormaDePagamentoBD
{
    /// <summary>
    /// Metodo responsavel por cadastrar uma nova Forma de Pagamento no BD MYSQL
    /// </summary>
    /// <param name="formadepagamento">Instancia de objeto FormaDePagamento Preenchido (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(FormaDePagamento formadepagamento)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO FormaDePagamento (NomeFop ,ObservacaoFop , StatusAtivacaoFop) VALUES ( ?NomeFop, ?ObservacaoFop, ?StatusAtivacaoFop);";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?NomeFop", formadepagamento._fopNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?ObservacaoFop", formadepagamento._fopObservacao));


            cmd.Parameters.Add(ConexaoBD.Parametro("?StatusAtivacaoFop", formadepagamento._fopStatusAtivacao));

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
    /// Metodo responsavel por atualizar os registros de Forma De Pagamento do banco de dados
    /// </summary>
    /// <param name="formadepagamento"></param>
    /// <returns></returns>
    public static int Update(FormaDePagamento formadepagamento)
    {
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE formadepagamento SET NomeFop=?Nome, ObservacaoFop=?Observacao, StatusAtivacaoFop=?StatusAtivacao WHERE IDFop=?ID;";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?ID", formadepagamento._fopID));
            cmd.Parameters.Add(ConexaoBD.Parametro("?Nome", formadepagamento._fopNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?Observacao", formadepagamento._fopObservacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?StatusAtivacao", formadepagamento._fopStatusAtivacao));


            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
            conn.Dispose();

            return 1;
        }
        catch (Exception e)
        {
            return -2;
        }
        return 0;
    }
    /// <summary>
    /// Select com dataset
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarFormasDePagamentos()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM formadepagamento";
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
    /// selecionar um usuario especifico
    /// </summary>
    /// <returns></returns>
    public static DataSet SelecionarFormaPagamento(FormaDePagamento Fop)
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM formadepagamento WHARE IDFop = ?ID";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            cmd.Parameters.Add(ConexaoBD.Parametro("?ID", Fop._fopID));
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
    /// Metodo responsavel por mudar o status de ativação de uma determinada Forma de pagamento
    /// </summary>
    /// <param name="codeUser"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ActiveInFormaDePagamento(int codeUser, int value)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE formadepagamento SET StatusAtivacaoFop = ?VALUE WHERE IDFop= ?CODIGO";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?VALUE", value));
            cmd.Parameters.Add(ConexaoBD.Parametro("?CODIGO", codeUser));
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
    /// Select sem Dataset
    /// </summary>
    /// <returns></returns>
    public static FormaDePagamento Select()
    {
        FormaDePagamento fop = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT * FROM formadepagamento;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            fop = new FormaDePagamento();
            fop._fopID = Convert.ToInt32(dr["IDFop"].ToString());
            fop._fopNome = dr["NomeFop"].ToString();
            fop._fopObservacao = dr["ObservacaoFop"].ToString();
        }

        return fop;
    }
}