using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль преобразования целого в дробное
    /// Сесин Иван
    /// </summary>
    class Q_3
    {
        /// <summary>
        /// Перевод из целого в дробное
        /// В знаменателе "1"
        /// </summary>
        /// <param name="input">Целое число</param>
        /// <returns>Дробное число</returns>
        public static Rational Run(Digit input)
        {
            return new Rational(input);
        }
    }
}
