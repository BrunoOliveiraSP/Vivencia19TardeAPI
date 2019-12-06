using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Vivencia19TardeAPI.Utils
{
    public class Validador
    {
        public static void ValidarEmail(string email)
        {
            string invalido = "O campo E-MAIL está inválido, tente novamente!";

            if (string.IsNullOrWhiteSpace(email))
                throw new Exception(invalido);

            if (email.Contains("@") == false)
                throw new Exception(invalido);

            if (email.Contains(".") == false)
                throw new Exception(invalido);          
                       
        }

        public static void CaracteresEspeciais(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("O campo SENHA está inválido, tente novamente!");

            if (nome.Contains("1") || nome.Contains("2")
                 || nome.Contains("3") || nome.Contains("4")
                || nome.Contains("5") || nome.Contains("6")
                 || nome.Contains("7") || nome.Contains("8")
                || nome.Contains("9") || nome.Contains("0")
                 || nome.Contains("@") || nome.Contains("!")
                || nome.Contains("#") || nome.Contains("$")
                 || nome.Contains("%") || nome.Contains("¨")
                || nome.Contains("&") || nome.Contains("*")
                 || nome.Contains("(") || nome.Contains(")")
                || nome.Contains("-") || nome.Contains("_")
                 || nome.Contains("=") || nome.Contains("+")
                || nome.Contains("?") || nome.Contains(";")
                 || nome.Contains("#") || nome.Contains(".")
                || nome.Contains(",") || nome.Contains("|")
                 || nome.Contains("/") || nome.Contains("~")
                || nome.Contains("^") || nome.Contains("´")
                 || nome.Contains("`") || nome.Contains("[")
                || nome.Contains("{") || nome.Contains("]")
                 || nome.Contains("}"))
                throw new Exception("O campo NOME está inválido!");
        }

    }

}