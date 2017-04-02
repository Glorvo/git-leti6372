using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Частное от деления большего целого числа на меньшее или равное натуральное с остатком
    /// Пульнева Ксения
    /// </summary>
    public static class Z_9
    {
        /// <summary>
        /// Нахождение частного от деления целого на натуральное
        /// </summary>
        /// <param name="A">Делимое(целое число)</param>
        /// <param name="B">Делитель(меньшее натуральное число)</param>
        /// <returns>Целое число - частное от деления</returns>

        public static Digit Run (Digit A, Natural B)
        {
            //запоминаем знак целого числа
            int sign = Z_2.Run(A);

            // делаем из целого числа натуральное с равным модулем
            Natural abs = Z_1.Run(A);

            //частное от деления одного натурального на другое
            abs = N_11.Run(abs, B);

            Digit Result;
            //добавление знака (преобразование натурального в целое)
            //если число отрицательное
            if(sign==2)
            {
                Result = new Digit(false, abs);
            }

            //если число неотрицательное
            else
            {
                Result = new Digit(true, abs);
            }

            return Result;

        }
    }
}
