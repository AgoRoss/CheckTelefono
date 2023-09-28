using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        int n = 0;
        string numero;
        while(n < 3)                                                                                    
        {
            numero = input[n];
            if (numero[0] == 0)
            {
                if(numero.Length == 14)
                {
                    n = 0;
                    return numero;
                }
            }
            if (numero[1] == 3)
            {
                if (numero[2] == 9)
                {
                    if (numero.Length == 13)
                    {
                        n = 0;
                        return numero;
                    }
                }
            }
            if (numero[0] == 3)
            {
                if (numero.Length == 10)
                {
                    n = 0;
                    return numero;
                }   
            }
            if (n == 2)
            {
                n = 0;
                return "";
            }
            n = n + 1;
        }
        return "";
    }
}