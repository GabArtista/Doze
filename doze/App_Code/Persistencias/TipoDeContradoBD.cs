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
            cmd.Dispose(); //Limpar cach
            conn.Close();
            conn.Dispose(); //Limpar cach
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
            conn.Dispose(); //Limpar cach
            cmd.Dispose(); //Limpar cach
        }
        catch (Exception ex)
        {
            error = -2;
        }
        return error;

    }
}