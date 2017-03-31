using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Умножение целых чисел
    /// Меркулов Артем
    /// </summary>
    public static class N_8
    {
        /// <summary>
        /// Умножение натуральных чисел
        /// </summary>
        /// <param name="A">Первый множитель</param>
        /// <param name="B">Второй мнжитель</param>
        /// <returns>Перемноженные числа</returns>
        public static Natural Run(Natural A, Natural B)
        {
            Natural ret = new Natural(new int[A.Clear().Length + B.Clear().Length]);

            for (int i = 0; i < B.Length; i++)
            {
                ret = N_4.Run(ret, N_7.Run(N_6.Run(A, B[i]), i));
            }
            return ret.Clear();
        }

    }
}
 