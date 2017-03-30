using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль сложения целых чисел
    /// Владислав Кузнецов
    /// </summary>
    static class N_4
    {
        /// <summary>
        /// Приравнивание массивов чисел
        /// Сложение чисел
        /// </summary>
        /// <param name="arr">Первое слагаемое</param>
        /// <param name="arr2">Второе слагаемое</param>
        /// <returns>Сумма сложения</returns>
        public static Natural Run(Natural n1, Natural n2)
        {
            Natural output = new Natural(new int[Math.Max(n1.Length, n2.Length)+1]);

            for (int i = 0; i < output.Length; i++)
            {
                int a1 = 0;
                int a2 = 0;

                if (n1.Length-1 >= i)
                    a1 = n1[i];
                if(n2.Length-1 >= i )
                    a2 = n2[i];

                if ((output[i] + a1 + a2) >= 10)
                {
                    output[i + 1]++;
                    output[i] = ((output[i] + a1 + a2) - 10);
                }
                else
                    output[i] = output[i] + a1 + a2;
            }
            return output.Clear();
        }
    }
}