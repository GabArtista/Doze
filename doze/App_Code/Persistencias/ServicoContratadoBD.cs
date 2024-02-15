using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
/// <summary>
/// Descrição resumida de ServicoContratado
/// </summary>
public class ServicoContratadoBD
{

    //Criar
    /// <summary>
    /// Metodo responsavel por cadastrar um novo Serviço na Solicitação. No BD MYSQL.
    /// </summary>
    /// <param name="midia">Instancia de objeto ServicoContratado (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(ServicoContratado servicoContratado)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "INSERT INTO ServicoContratado (IDSlc ,IDSvc) VALUES ( ?IDSlc, ?IDSvc);";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?IDSvc", servicoContratado._Svc));
            cmd.Parameters.Add(ConexaoBD.Parametro("?IDSlc", servicoContratado._Slc));
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
    /// Selecionar uma solicitação especifica
    /// </summary>
    /// <returns></returns>
    public static int[] SelecionaServcoContratado(int IDSlc)
    {
        
        IDbConnection conn = ConexaoBD.Conexao();

        IDataReader dr;
        string sql = "SELECT servicoContratado.IDSvc FROM servicoContratado WHERE servicoContratado.IDSlc = ?IDSlc;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?IDSlc", IDSlc));
        dr = comm.ExecuteReader();

        IDbConnection connCount = ConexaoBD.Conexao();
        IDataReader drCount;
        string sqlCount = "SELECT COUNT(*) servicoContratado FROM servicoContratado WHERE servicoContratado.IDSlc = ?IDSlc;";
        IDbCommand commCount = ConexaoBD.Comando(sqlCount, connCount);
        commCount.Parameters.Add(ConexaoBD.Parametro("?IDSlc", IDSlc));
        drCount = commCount.ExecuteReader();


        drCount.Read();
        int quantidadeRegistros = drCount.GetInt32(0);

        int[] sct = new int[quantidadeRegistros];

        int i = 0;
        while (dr.Read())
        {
            //Transformar dado do banco em um array  
            sct[i] = dr.GetInt32(0); // Armazena o ID na posição atual do array
            i++;
        }

        return sct;
    }
    //Editar

    //Apagar
    /// <summary>
    /// Metodo responsavel por Deletar um Serviço da Solicitação, no BD MYSQL.
    /// </summary>
    /// <param name="midia">Instancia de objeto ServicoContratado (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Delete(ServicoContratado servicoContratado)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            IDbCommand cmd;
            string sql = "DELETE FROM ServicoContratado WHERE IDSlc = ?IDSlc AND IDSvc = ?IDSvc;";


            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?IDSvc", servicoContratado._Svc));
            cmd.Parameters.Add(ConexaoBD.Parametro("?IDSlc", servicoContratado._Slc));
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

    //-----------------


    //Listar Serviços de uma determinada Solicitação.




}