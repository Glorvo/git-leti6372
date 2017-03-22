using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Смотрин Никита
    /// Проверка на ноль. True, если число равно нулю; False, если число не равно нулю.
    /// </summary>
    static class N_2
    {
        /// <summary>
        /// Проверка на ноль.
        /// </summary>
        /// <param name="input">Натуральное число</param>
        /// <returns> True, если число равно нулю; False, если число не равно нулю. </returns>
        public static bool Run(Natural input)
        {
            input.Clear();//Предворительно очищаем массив от лишних нулей
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Проверка на ноль.
        /// </summary>
        /// <param name="input">Целое число</param>
        /// <returns> True, если число равно нулю; False, если число не равно нулю. </returns>
        public static bool Run(Digit input)
        {
            return Run(input.Value);
        }

        /// <summary>
        /// Проверка на ноль.
        /// </summary>
        /// <param name="input">Рациональное число</param>
        /// <returns> True, если число равно нулю; False, если число не равно нулю. </returns>
        public static bool Run(Rational input)
        {
            return Run(input.Numerator);
        }
    }
}
