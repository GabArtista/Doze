using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Classe de conexão da Classe Serviço com o Banco de Dados
/// </summary>
public class ServicoBD
{
    /// <summary>
    /// Metodo responsavel por cadastrar um novo Serviço no BD MYSQL
    /// </summary>
    /// <param name="Serviço">Instancia de objeto Solicitação Preenchido (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(Servico servico)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO Servico (NomeSvc, PrecoSvc, ObservacaoSvc, StatusAtivacaoSvc) VALUES ( ?NomeSvc, ?PrecoSvc, ?ObservacaoSvc, ?StatusAtivacaoSvc);";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?NomeSvc", servico._svcNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?PrecoSvc", servico._svcPreco));
            cmd.Parameters.Add(ConexaoBD.Parametro("?ObservacaoSvc", servico._svcObservacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?StatusAtivacaoSvc", servico._svcStatusAtivacao));
           
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
    /// Metodo responsavel por atualizar os registros de Serviços do banco de dados
    /// </summary>
    /// <param name="Servico"></param>
    /// <returns></returns>
    public static int Update(Servico servico)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE servico SET NomeSvc = ?nome, PrecoSvc = ?preco, ObservacaoSvc = ?observacao, StatusAtivacaoSvc = ?statusAtivacao WHERE IDSvc = ?id";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?id", servico._svcID));
            cmd.Parameters.Add(ConexaoBD.Parametro("?nome", servico._svcNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?preco", servico._svcPreco));
            cmd.Parameters.Add(ConexaoBD.Parametro("?observacao", servico._svcObservacao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?statusAtivacao", servico._svcStatusAtivacao));
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
    /// Lista todos os usuarios e todas as informaçoes
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarServicos()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM Servico";
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
    /// Metodo responsavel por mudar o status de ativação de um determinado usuario
    /// </summary>
    /// <param name="codeUser"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ActiveInServico(int codeUser, int value)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE Servico SET StatusAtivacaoSvc = ?VALUE WHERE IDSvc = ?CODIGO";
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
}