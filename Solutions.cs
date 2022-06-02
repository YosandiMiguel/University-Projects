using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    static class Solutions
    {
        #region MainCode
        public static void Exercice1(double a,double b,double c)
        {
            Console.WriteLine((a+(b/c)) / ((a/b)+c));
        }

        public static void Exercice2(double a,double b, double c)
        {
            Console.WriteLine((a+b+a/b)/c);
        }

        public static void Exercice3(double a, double b, double c)
        {
            Console.WriteLine((a/(a+b)) / (a/(a-b)));
        }

        public static void Exercice4(double a, double b,double c)
        {
            Console.WriteLine((a + (b / (a + b + b / c))) / (a + b/(c+a)));
        }

        public static void Exercice5(double a,double b,double c)
        {
            Console.WriteLine((a + b + c) / (a + b/c));
        }

        public static void Exercice6(double a , double b, double c,double d)
        {
            Console.WriteLine((a+b) + (c / (d*a)) / ((a+b) * (c/d)));
        }

        public static void Exercice7(double a, double b, double c, double d)
        {
            Console.WriteLine((a + b / c + d) / a);
        }
        #endregion
        public static void PringLine()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
    }
}
