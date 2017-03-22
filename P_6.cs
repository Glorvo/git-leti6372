using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_6
{
    /// <summary>
    /// Считает степень многочлена;
    /// Холод Дарья
    /// </summary>
    static class P_6
    {
        public static int Run(int[] input)
        {
            Polynomial.Clear();
            return (input.Length - 1); // Вычитаем x^0, коэфф. которого также есть в массиве
        }
    }
}
