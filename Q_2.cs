using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Проверка число на целое
    /// Кузнецов Владислав
    /// </summary>
    static class Q_2
    {
        /// <summary>
        /// Проверка на целое, если рациональное число является целым, то «да», иначе «нет»
        /// </summary>
        /// <param name="Rational input">вводится рациональное число</param>
        /// <returns>"true" или "false"</returns>
        public static bool Run(Rational input)
        {
            Q_1.Run(input); // сокращаем дробь
            return input.Denominator.Clear().Length == 1 && input.Denominator[0] == 1;

        }
    }
}