using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Умножение целых чисел
    /// Хаханов Тимофей
    /// </summary>
    public static class Z_8
    {
        /// <summary>
        /// Умножение целых чисел
        /// </summary>
        /// <param name="A">Первый множитель</param>
        /// <param name="B">Второй мнжитель</param>
        /// <returns>Перемноженные числа</returns>
        public static Digit Run(Digit A, Digit B)
        {
            Digit ret = new Digit(A.Sign == B.Sign, new int[A.Clear().Length + B.Clear().Length]);

            for(int i = 0; i < B.Length; i++)
                ret.Value = N_4.Run(ret.Value, N_6.Run(A.Value, B[i]*(int)Math.Pow(10, i)));
            return ret.Clear();
        } 

    }
}
