using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// Descrição resumida de MidiaBD
/// </summary>
public class MidiaBD
{
    //Criar
    /// <summary>
    /// Metodo responsavel por cadastrar uma nova Midia no BD MYSQL
    /// </summary>
    /// <param name="midia">Instancia de objeto Midia Preenchido (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(Midia midia)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO Midia (Midiamda ,ObservacaoMda) VALUES ( ?Midiamda, ?ObservacaoMda);";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?Midiamda", midia._mdaMidia));
            cmd.Parameters.Add(ConexaoBD.Parametro("?ObservacaoMda", midia._mdaObservacao));
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

    //Listar
    /// <summary>
    /// Lista todos os usuarios e todas as informaçoes
    /// </summary>
    /// <returns></returns>
    public static DataSet ListarMidias()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM midia";
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
    //Apagar

    //Editar
}