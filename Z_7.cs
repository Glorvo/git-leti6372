using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Вычитание целых чисел
    /// Кирилл Першин + Бараняк Данила
    /// </summary>
    static class Z_7
    {
        /// <summary>
        /// Вычитание целых чисел (в т.ч. отрицательных)
        /// </summary>
        /// <param name="A">Уменьшаемое</param>
        /// <param name="B">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static Digit Run(Digit A, Digit B)
        {
            return Z_6.Run(A, new Digit(!B.Sign, B.Value));
        }
    }
}