using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.ServiceModel.Channels;

/// <summary>
/// Descrição resumida de ConexaoBD
/// </summary>
public static class ConexaoBD
{
    //Metodos:

    //Conexão com o banco de dados -> MySQL
    //String de Conexão

    /// <summary>
    /// Metodo responsavel por abrir a conexão com o banco de dados MySQL 
    /// Utilizando a "string de consexão" presente no Web.Config (AppSettings)
    /// </summary>
    /// <returns></returns>
    public static IDbConnection Conexao()
    {

        MySqlConnection conexaoMySQL = new MySqlConnection(ConfigurationManager.AppSettings["stringConexaoBD"]);

        conexaoMySQL.Open();
        return conexaoMySQL;
        
    }


    //Execultar comandos (SQL)

    /// <summary>
    /// Metodo responsavel por execultar um comando SQL
    /// </summary>
    /// <param sql="sql">Comando a ser execultado</param>
    /// <param conexao="conexao">Conexão Válida para a execução</param>
    /// <returns>Retorna um comando válido SQL</returns>
    public static IDbCommand Comando(string sql, IDbConnection conexao)
    {
        IDbCommand comando = conexao.CreateCommand();
        comando.CommandText = sql;
        return comando;
    }

    /// <summary>
    /// Metodo responsavel por coletar uma lista do D e "passar" a um Cont. de dados (ex. DS)
    /// </summary>
    /// <param name="comando">Comando validado para ser execultado</param>
    /// <returns>Retorna o Objeto para preenchimento dos dados</returns>
    //Container de Dados (DataSet)
    public static IDataAdapter Adapter(IDbCommand comando)
    {
        IDbDataAdapter adapter = new MySqlDataAdapter();
        adapter.SelectCommand = comando;
        return adapter;
    }

    //Parametros -> Para evitar SQL INJ / XSS

    /// <summary>
    /// Metodo responsavel por ajudar a prevenção de SQL Injection e XSS
    /// </summary>
    /// <param name="nomeParametro">Nome do parametro que virá do método de execução do sql</param>
    /// <param name="valorParametro">True or False para o parametro</param>
    /// <returns></returns>

    public static IDbDataParameter Parametro(string nomeParametro, object valorParametro)
    {
        return new MySqlParameter(nomeParametro, valorParametro);
    }



}