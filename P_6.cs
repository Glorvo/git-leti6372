using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Считает степень многочлена;
    /// Холод Дарья
    /// </summary>
    static class P_6
    {
        public static int Run(Polynomial input)
        {
            if (input.Clear().Length > 0)
                return input.Clear().Length - 1; // Вычитаем x^0, коэфф. которого также есть в массиве
            else return 0;
        }
    }
}