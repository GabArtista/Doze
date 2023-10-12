 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Descrição resumida de UsuarioBD
/// </summary>
public class UsuarioBD
{
    /// <summary>
    /// Metodo responsavel por cadastrar um novo usuario no BD MYSQL
    /// </summary>
    /// <param name="usuario">Instancia de objeto Usuario Preenchido (NEW) </param>
    /// <returns> If retorno = 0 then Sucesso else ERRO (-1) </returns>
    public static int Insert(Usuario usuario)
    {
        int retorno = 0;
        try
        {
            IDbConnection conn;
            IDbCommand cmd;
            string sql = "INSERT INTO usuario ( NomeUsu, TelefoneUsu, EmailUsu, SenhaUsu, TipoUsu, StatusConexaoUsu, StatusAtivacaoUsu) VALUES ( ?nomeUsu, ?telefoneUsu, ?emailUsu, ?senhaUsu, ?tipo, ?statusConexao, ?statusAtivacao);";

            conn = ConexaoBD.Conexao();
            cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?nomeUsu", usuario._usuNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?telefoneUsu", usuario._usuTelefone));
            cmd.Parameters.Add(ConexaoBD.Parametro("?emailUsu", usuario._usuEmail));
            cmd.Parameters.Add(ConexaoBD.Parametro("?senhaUsu", usuario._usuSenha));
            cmd.Parameters.Add(ConexaoBD.Parametro("?tipo", usuario._usuTipoUsuario));
            cmd.Parameters.Add(ConexaoBD.Parametro("?statusConexao", usuario._usuStatusConexao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?statusAtivacao", usuario._usuStatusAtivacao));
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
    public static DataSet ListarUsuarios()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM usuario";
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
    /// <param name="usuario"></param>
    /// <returns></returns>
    public static int Update(Usuario usuario)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE usuario SET NomeUsu = ?nome, TelefoneUsu = ?telefone, EmailUsu = ?email, SenhaUsu = ?senha, TipoUsu = ?tipo, StatusConexaoUsu = ?statusConexao, StatusAtivacaoUsu = ?statusAtivacao WHERE IDUsu = ?id";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            cmd.Parameters.Add(ConexaoBD.Parametro("?id", usuario._usuID));
            cmd.Parameters.Add(ConexaoBD.Parametro("?nome", usuario._usuNome));
            cmd.Parameters.Add(ConexaoBD.Parametro("?telefone", usuario._usuTelefone));
            cmd.Parameters.Add(ConexaoBD.Parametro("?email", usuario._usuEmail));
            cmd.Parameters.Add(ConexaoBD.Parametro("?senha", usuario._usuSenha));
            cmd.Parameters.Add(ConexaoBD.Parametro("?tipo", usuario._usuTipoUsuario));
            cmd.Parameters.Add(ConexaoBD.Parametro("?statusConexao", usuario._usuStatusConexao));
            cmd.Parameters.Add(ConexaoBD.Parametro("?statusAtivacao", usuario._usuStatusAtivacao));
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