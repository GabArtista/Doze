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
    /// Retorna a ID do ultimo usuario cadastrado 
    /// </summary>
    /// <returns></returns>
    public static int puxarIDUsuarioCadastrado()
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT MAX(IDUsu) AS IDUsu FROM usuario;";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            adp.Fill(ds);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]); //Converte o retorno do banco em INT
            cmd.Dispose(); //Limpar cach
            conn.Close();
            conn.Dispose(); //Limpar cach
            return id;

        }
        catch (Exception ex)
        {
            return 0;
        }

    }

    /// <summary>
    /// Verificar se o usuario esta cadastrado
    /// NÃO USADO
    /// NÃO USADO
    /// NÃO USADO
    /// NÃO USADO
    /// NÃO USADO
    /// NÃO USADO
    /// </summary>
    /// <returns></returns>
    public static DataSet AuthenticaUsuario(String email, String senha)
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT * FROM usuario WHERE EmailUsu = '" + email + "' AND SenhaUsu = '" + senha + "';";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            adp.Fill(ds);
            int totalRegistros = ds.Tables[0].Rows.Count;
            cmd.Dispose();
            conn.Close();
            conn.Dispose();

            // Verifica se existe algum registro
            if (totalRegistros == 0)
            {
                // Não existe nenhum registro com o email e a senha informados
                // ...
                return null;
            }
            else
            {
                // Existe pelo menos um registro com o email e a senha informados
                // ...
                
                return ds;
            }
            
            

        }
        catch (Exception ex)
        {
            return null;
        }

    }
    /// <summary>
    /// Verificar se o usuario esta cadastrado
    /// </summary>
    /// <returns></returns>
    public static Usuario AuthenticaUsuarioV2(string email, string senha) {
        Usuario usu = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT * FROM Usuario WHERE EmailUsu = ?email AND SenhaUsu = ?senha;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?email", email));
        comm.Parameters.Add(ConexaoBD.Parametro("?senha", senha));

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            usu = new Usuario();
            usu._usuID = Convert.ToInt32(dr["IDUsu"].ToString());
            usu._usuEmail = dr["EmailUsu"].ToString();
            usu._usuSenha = dr["SenhaUsu"].ToString();
            usu._usuTipoUsuario = dr["TipoUsu"].ToString();
        }

        return usu;
        }
    /// <summary>
    /// Verificar se o usuario esta cadastrado
    /// </summary>
    /// <returns></returns>
    public static Usuario SelecionaUsuario(string id)
    {
        Usuario usu = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT * FROM Usuario WHERE IDUsu = ?id;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?id", id));

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            usu = new Usuario();
            usu._usuID = Convert.ToInt32(dr["IDUsu"].ToString());
            usu._usuNome = dr["NomeUsu"].ToString();
            usu._usuTelefone = dr["TelefoneUsu"].ToString();
            usu._usuEmail = dr["EmailUsu"].ToString();
            usu._usuSenha = dr["SenhaUsu"].ToString();
        }

        return usu;
    }
    /// <summary>
    /// Retorna a ID do usuario que esta fazendo login 
    /// </summary>
    /// <returns></returns>
    public static int puxarIDUsuarioConectado(String email, String senha)
    {
        try
        {

            DataSet ds = new DataSet();
            IDbConnection conn = ConexaoBD.Conexao(); ;
            string sql = "SELECT IDUsu FROM usuario WHERE EmailUsu = '" + email + "' AND SenhaUsu = '" + senha + "';";
            IDbCommand cmd = ConexaoBD.Comando(sql, conn);
            IDataAdapter adp = ConexaoBD.Adapter(cmd);
            adp.Fill(ds);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]); //Converte o retorno do banco em INT
            cmd.Dispose(); //Limpar cach
            conn.Close();
            conn.Dispose(); //Limpar cach
            return id;

        }
        catch (Exception ex)
        {
            return 0;
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
    /// <summary>
    /// Metodo responsavel por mudar o status de ativação de um determinado usuario
    /// </summary>
    /// <param name="codeUser"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int ActiveInUser(int codeUser, int value)
    {
        int error = 0;
        try
        {
            IDbConnection conn = ConexaoBD.Conexao();
            string sql = "UPDATE Usuario SET StatusAtivacaoUsu = ?VALUE WHERE IDUsu = ?CODIGO";
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
    /// Selecionar um Usuario especifica
    /// </summary>
    /// <returns></returns>
    public static Usuario SelecionaUsuarioESolicitacao(string id)
    {
        Usuario usu = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT solicitacao.IDSlc, solicitacao.DescricaoSlc, solicitacao.DataFechamentoSlc, solicitacao.DataSlc, solicitacao.EstrategiaCobranca, solicitacao.GMailSlc, solicitacao.GSenha, solicitacao.LinkTrelloSlc, solicitacao.ObservacaoSlc, solicitacao.StatusSlc, solicitacao.ValorAcordado, usuario.IDUsu, usuario.NomeUsu, usuario.EmailUsu, usuario.SenhaUsu, usuario.TelefoneUsu FROM solicitacao INNER JOIN usuario ON solicitacao.IDUsu = usuario.IDUsu;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?id", id));

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            usu = new Usuario();
            usu._usuID = Convert.ToInt32(dr["IDSlc"].ToString());
            usu._usuNome = dr["NomeUsu"].ToString();
            usu._usuEmail = dr["EmailUsu"].ToString();
            usu._usuSenha = dr["SenhaUsu"].ToString();
            usu._usuTelefone = dr["TelefoneUsu"].ToString();
        }

        return usu;
    }
    /// <summary>
    /// Verificar se o E-Mail fornecido ja esta cadastrado
    /// Usado em Redefinir Senha.
    /// </summary>
    /// <returns></returns>
    public static Usuario SelecionaUsuarioPorEmail(string email)
    {
        Usuario usu = null;
        IDbConnection conn = ConexaoBD.Conexao();
        IDataReader dr;
        string sql = "SELECT * FROM Usuario WHERE EmailUsu = ?email;";
        IDbCommand comm = ConexaoBD.Comando(sql, conn);
        comm.Parameters.Add(ConexaoBD.Parametro("?email", email));

        dr = comm.ExecuteReader();

        if (dr.Read())
        {
            usu = new Usuario();
            usu._usuID = Convert.ToInt32(dr["IDUsu"].ToString());
            usu._usuNome = dr["NomeUsu"].ToString();
            usu._usuTelefone = dr["TelefoneUsu"].ToString();
            usu._usuEmail = dr["EmailUsu"].ToString();
            usu._usuSenha = dr["SenhaUsu"].ToString();
        }

        return usu;
    }
}