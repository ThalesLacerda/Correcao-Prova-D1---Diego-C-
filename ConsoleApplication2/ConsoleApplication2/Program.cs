using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        // Questão 1
         static int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }



        static int Maior2(int a, int b)
        {
            return (a > b) ? a : b;

        }


        // Questão 2
        static bool Par(int numero)
        {
            int resto = numero % 2;
            if (resto == 0)
                return true;
            else
                return false;

        }

        static string Par2(int numero)
        {
            int resto = numero % 2;
            if (resto == 0)
                return "Par";
            else
                return "Ímpar";
        }




            /*/ correção prova 

               1) Maior (a,b);

                  Se (a>b)
                   retorna a;
                  Senão
                   retorna b;         
           Tradução

           static int Maior (int a, int b) {
                   if (a > b)
                       return a,
                   else
                       return b;
                       }    /*/

            static void Main(string[] args)
        {

        }
    }
}
