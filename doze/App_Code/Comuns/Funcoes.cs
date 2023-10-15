using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descrição resumida de Funcoes
/// </summary>
public static class Funcoes
{
    /// <summary>
    /// Este método calcula o hash SHA-512 de um texto fornecido. 
    /// O hash SHA-512 é uma função de hash criptográfica que gera um 
    /// valor de hash de 512 bits a partir de um texto de qualquer tamanho. 
    /// O valor de hash é único para o texto fornecido e é muito difícil de falsificar.
    /// 
    /// Como:
    /// Cria uma instância da classe HashAlgorithm, especificando o algoritmo SHA-512.
    /// Calcula o hash do texto fornecido usando o método ComputeHash da classe HashAlgorithm.
    /// Converte o hash para uma string Base64 usando o método ToBase64String da classe Convert.
    /// Retorna a string Base64.
    /// </summary>
    /// <param name="texto"></param>
    /// <returns></returns>

    //Criptografando
    public static string HashSHA512(string texto)
    {
        HashAlgorithm hashAlgoritimo = HashAlgorithm.Create("SHA-512");
        byte[] hash = hashAlgoritimo.ComputeHash(Encoding.UTF8.GetBytes(texto));
        return Convert.ToBase64String(hash);
    }

    /// <summary>
    /// Este método calcula o hash Base64 de um texto fornecido. 
    /// O hash Base64 é uma função de codificação que converte dados 
    /// binários em uma string ASCII. 
    /// Isso é útil para armazenar ou transmitir dados binários de forma segura e eficiente.
    /// Como:
    /// Converte o texto fornecido para uma matriz de bytes usando o método GetBytes da classe Encoding.
    /// Codifica a matriz de bytes em uma string Base64 usando o método ToBase64String da classe Convert.
    /// Retorna a string Base64.
    /// </summary>
    /// <param name="texto"></param>
    /// <returns></returns>
    public static string HashBase64(string texto)
    {

        byte[] byteBase64 = new byte[texto.Length];
        byteBase64 = Encoding.UTF8.GetBytes(texto);
        string codifica = Convert.ToBase64String(byteBase64);


        return codifica;
    }

    /// <summary>
    /// Este método decodifica uma string Base64 para um texto.
    /// Como:
    /// Converte a string Base64 para uma matriz de bytes usando o método FromBase64String da classe Convert.
    /// Decodifica a matriz de bytes para um texto usando o método GetChars da classe UTF8Encoding.
    /// Retorna o texto decodificado.
    /// </summary>
    /// <param name="textoBase64"></param>
    /// <returns></returns>

    public static string HashBase64Returns(string textoBase64)
    {
        var encode = new UTF8Encoding();
        var utf8Decode = encode.GetDecoder();

        byte[] stringTextoBase64 = Convert.FromBase64String(textoBase64);
        int contador = utf8Decode.GetCharCount(stringTextoBase64, 0, stringTextoBase64.Length);
        char[] decodeContador = new char[contador];

        utf8Decode.GetChars(stringTextoBase64, 0, stringTextoBase64.Length, decodeContador, 0);
        string resultado = new String(decodeContador);
        return resultado;
    }


    /// <summary>
    /// Este método conta o número de linhas no primeiro DataTable de um DataSet fornecido.
    /// Como:
    /// Verifica se o DataSet fornecido é nulo. Se for, retorna 0.
    /// Retorna o número de linhas no primeiro DataTable do DataSet.
    /// </summary>
    /// <param name="ds"></param>
    /// <returns></returns>

    public static int CountDataSet(DataSet ds)
    {
        int count = 0;
        if(ds != null)
        {
            count = ds.Tables[0].Rows.Count;
        }
        return count;
    }

    /// <summary>
    /// Este método preenche um GridView com os dados de um DataSet fornecido.
    /// Como:
    /// Verifica se o DataSet fornecido é nulo. Se for, retorna.
    /// Verifica se o primeiro DataTable do DataSet tem alguma linha.Se não tiver, define o texto do Label fornecido para "Não há registros".
    /// Define o DataSource do GridView para o primeiro DataTable do DataSet.
    /// Chama o método DataBind do GridView.
    /// Define a propriedade HeaderRow.TableSection do GridView para TableRowSection.TableHeader.
    /// Define a propriedade Visible do GridView para true.
    /// </summary>
    /// <param name="gdv"></param>
    /// <param name="ds"></param>
    /// <param name="lbl"></param>
    public static void FillGrid(GridView gdv, DataSet ds, Label lbl)
    {
        if (ds != null)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                gdv.DataSource = ds.Tables[0].DefaultView;
                gdv.DataBind();
                gdv.HeaderRow.TableSection = TableRowSection.TableHeader;
                gdv.Visible = true;
            }
            else
            {
                lbl.Text = "Não há registros";
            }
        }
        else
        {
            gdv.Visible = false;
            lbl.Text = "Erro ao buscar registros";
        }
    }


    //TALVEZ USAREMOS ISSO


    /// <summary>
    /// Este método preenche um Repeater com os dados de um DataSet fornecido.
    /// Como:
    /// O método FillRtp não define a propriedade HeaderRow.TableSection do Repeater.
    /// O método FillRtp não verifica se o primeiro DataTable do DataSet tem alguma linha.Se não tiver, o Repeater simplesmente estará vazio.
    /// </summary>
    /// <param name="rpt"></param>
    /// <param name="ds"></param>
    /// <param name="lbl"></param>
    public static void FillRtp(Repeater rpt, DataSet ds, Label lbl)
    {
        if (ds != null)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.DataSource = ds.Tables[0].DefaultView;
                rpt.DataBind();
                rpt.Visible = true;
            }
            else
            {
                lbl.Text = "Não há registros";
            }
        }
        else
        {
            rpt.Visible = false;
            lbl.Text = "Erro ao buscar registros";
        }
    }
}