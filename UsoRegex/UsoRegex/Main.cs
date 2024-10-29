using System;
using System.Text.RegularExpressions;

namespace UsoRegex
{
    class Main
    {
        public bool ValSeleccion(string input)
        {
            string patterSeleccion = @"^[0-9]{1,1}$";
            Match RegexSel = Regex.Match(input, patterSeleccion);
            bool IsValidSel = RegexSel.Success;
            bool IsEmptySel = string.IsNullOrEmpty(input);

            bool comparativo = IsValidSel && !IsEmptySel;
            return comparativo;
        }
    }
}
