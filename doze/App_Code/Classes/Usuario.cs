using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descrição resumida de Usuario
/// </summary>
public class Usuario
{

    public int _usuID { set; get; }
    public string _usuNome { set; get; }
    public string _usuTelefone { set; get; }
    public string _usuEmail { set; get; }
    public string _usuSenha { set; get; }
    public string _usuTipoUsuario { set; get; }
    public DateTime _usuDataCadastro { set; get; }
    public Boolean _usuStatusConexao { set; get; }
    public string _usuStatusAtivacao { set; get; }

}