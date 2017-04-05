using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Остаток от деления большего целого числа на меньшее или равное натуральное с остатком
    /// Казанцева Екатерина
    /// </summary>
    public static class Z_10
    {
        /// <summary>
        /// Нахождение остатка от деления целого на натуральное
        /// </summary>
        /// <param name="A">Делимое(целое число)</param>
        /// <param name="B">Делитель(меньшее натуральное число)</param>
        /// <returns>Целое число - остаток от деления</returns>
        public static Digit Run(Digit A, Natural B)
        {

            Digit Result = Z_9.Run(A, B);           //Частное от деления большего целого на меньшее или равное натуральное с остатком
            Digit B_1 = new Digit(B);               //преобразуем делитель из типа Natural в тип Digit
            Result = Z_8.Run(Result, B_1);          // Умножаем частное от деления на делитель
            Result = Z_7.Run(A, Result);            // Находим остаток от деления
            Result.Sign = true;
            return Result;                          // Возвращаем остаток от деления
        }
    }
}
