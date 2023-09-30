using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// Descrição resumida de Funcoes
/// </summary>
public static class Funcoes
{
    
    public static string HashSHA512(string texto)
    {
        HashAlgorithm hashAlgoritimo = HashAlgorithm.Create("SHA-512");
        byte[] hash = hashAlgoritimo.ComputeHash(Encoding.UTF8.GetBytes(texto));
        return Convert.ToBase64String(hash);
    }


    public static string HashBase64(string texto)
    {

        byte[] byteBase64 = new byte[texto.Length];
        byteBase64 = Encoding.UTF8.GetBytes(texto);
        string codifica = Convert.ToBase64String(byteBase64);


        return codifica;
    }



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

}