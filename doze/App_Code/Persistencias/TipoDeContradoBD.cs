using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Classe de conexão da Classe Tipo de Contrado com o Banco de Dados
/// </summary>
public class TipoDeContratoBD
{
    /// <summary>
    /// Metodo responsavel por cadastrar um novo Tipo de Pagamento no BD MYSQL
    /// </summary>
    /// <param name="tipodecontrato">Instancia de objeto TipoDeContato Preenchido (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(TipoDeContrato tipodecontrato)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO TipoDeContrato (NomeCnt ,ObservacaoCnt, StatusAtivacaoCnt) VALUES ( ?NomeCnt, ?ObservacaoCnt, ?StatusAtivacaoCnt);";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?NomeCnt", tipodecontrato._cntNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?ObservacaoCnt", tipodecontrato._cntObservacao));


            cmd.Parameters.Add(ConexaoBD.Parametro("?StatusAtivacaoCnt", tipodecontrato._cntStatusAtivacao));

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
    /// Lista todos os usuarios e todas as informaçoes
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarTiposDeContratos()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM tipodecontrato";
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
    /// Metodo responsavel por atualizar os registros de usuario do banco de dados
    /// </summary>
    /// <param name="TipoDeContrato"></param>
    /// <returns></returns>
    public static int Update(TipoDeContrato contrato)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE tipodecontrato SET NomeCnt = ?nome, ObservacaoCnt = ?observacao, StatusAtivacaoCnt = ?statusAtivacao WHERE IDCnt = ?id";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?id", contrato._cntID));
            cmd.Parameters.Add(ConexaoBD.Parametro("?nome", contrato._cntNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?observacao", contrato._cntObservacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?statusAtivacao", contrato._cntStatusAtivacao));
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
    /// Metodo responsavel por mudar o status de ativação de um determinado Contrato
    /// </summary>
    /// <param name="codeUser"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ActiveInContrato(int codeUser, int value)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE TipoDeContrato SET StatusAtivacaoCnt = ?VALUE WHERE IDCnt = ?CODIGO";
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
    /// selecionar um Tipo de Contrato especifico
    /// </summary>
    /// <returns></returns>
    public static TipoDeContrato SelecionarTipoDeContrato(int Cnt)
    {
        try
        {

            TipoDeContrato obj = null;
            IDbConnection conn = ConexaoBD.Conexao(); ;
            IDataReader dr;
            string sql = "SELECT * FROM tipodecontrato WHERE IDCnt = ?ID";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?ID", Cnt));
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                obj = new TipoDeContrato();
                obj._cntID = Convert.ToInt32(dr["IDCnt"].ToString());
                obj._cntNome = dr["NomeCnt"].ToString();
                obj._cntObservacao = dr["ObservacaoCnt"].ToString();
                obj._cntStatusAtivacao = Convert.ToBoolean(dr["StatusAtivacaoCnt"]);
 
            }

            return obj;

        }
        catch (Exception ex)
        {
            return null;
        }

    }


}