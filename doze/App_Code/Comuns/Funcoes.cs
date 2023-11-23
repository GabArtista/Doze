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
    /// Metodo para Criptografar
    /// </summary>
    /// <param name="texto"></param>
    /// <returns></returns>
    public static string HashSHA512(string texto)
    {
        HashAlgorithm hashAlgoritimo = HashAlgorithm.Create("SHA-512");
        byte[] hash = hashAlgoritimo.ComputeHash(Encoding.UTF8.GetBytes(texto));
        return Convert.ToBase64String(hash);
    }


    /// <summary>
    /// Metodo para Criptografar
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
    /// Metodo para Transdormar Hash em sua String original Base64
    /// </summary>
    /// <param name="texto"></param>
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

    public static int CountDataSet(DataSet ds)
    {
        int count = 0;
        if (ds != null)
        {
            count = ds.Tables[0].Rows.Count;
        }
        return count;
    }
    /// <summary>
    /// Metodo responsavel por escrever os dados da tabela Forma De Pagamento na coluna NomeFop para as opções do DropDown
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
    /// <summary>
    /// Metodo responsavel por escrever os dados da tabela Forma De Pagamento na coluna NomeFop para as opções do DropDown
    /// </summary>
    /// <param name="ddl"></param>
    /// <param name="ds"></param>
    /// <param name="lbl"></param>
    public static void ddnGrid(DropDownList ddl, DataSet ds, Label lbl, string nomeColunaTexto, string nomeColunaValor)
    {
        if (ds != null)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataTable dt = ds.Tables[0].DefaultView.ToTable();
                ddl.DataSource = dt;
                ddl.DataTextField = nomeColunaTexto; // nome da coluna que você deseja exibir como texto
                ddl.DataValueField = nomeColunaValor; // nome da coluna que você deseja usar como valor
                ddl.DataBind();
                ddl.Visible = true;
                ddl.Items.Insert(0, new ListItem("Selecione uma opção", "0"));
            }
            else
            {
                lbl.Text = "Não há registros";
            }
        }
        else
        {
            ddl.Visible = false;
            lbl.Text = "Erro ao buscar registros";
        }
    }


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