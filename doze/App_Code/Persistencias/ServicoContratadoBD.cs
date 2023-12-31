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
    public static ServicoContratado SelecionaServcoContratado(int IDSlv)
    {
        ServicoContratado sct = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT servicoContratado.IDSlc,servicoContratado.IDSvc FROM servicoContratado WHERE servicoContratado.IDSlc =  ?IDSlc;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?IDSlc", IDSlv));

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            sct = new ServicoContratado();

            sct._Svc = Convert.ToInt32(dr["IDsvc"].ToString());    
        }

        return sct;
    }
    //Editar

    //Apagar


    //-----------------


    //Listar Serviços de uma determinada Solicitação.




}