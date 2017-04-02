using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль N_12 вычисляет остаток от деления двух натуральных чисел
    /// Меркулов Артем +Симонян Даниил
    /// </summary>
    static class N_12
    {
        /// <summary>
        /// Остаток от деления большего натурального числана меньшее или равное натуральное
        /// </summary>
        /// <param name="num1">Первое натуральное число</param>
        /// <param name="num2">Второе натуральное число</param>
        /// <returns>Будет возвращен остаток от деления</returns>
        public static Natural Run(Natural num1, Natural num2)
        {
            num1.Clear(); num2.Clear();
            if (N_1.Run(num1, num2) == 2) throw new Exception(); // Если второе число больше, то ошибка
            Natural DivResult = N_11.Run(num1, num2);         // Находим частное от деления
            Natural ModResult = N_9.Run(num1, num2, DivResult); // С помощью частного находим остаток
            return ModResult;
        }
    }
}
