using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль N_10 Вычисление первой цифры деления и умножение ее на 10^k, где k - ее разряд
    /// Бараняк Данила
    /// </summary>

    class N_10
    {
        /// <summary>
        /// Вычисление первой цифры деления и умножение ее на 10^k, где k - ее разряд
        /// </summary>           
        /// <param name="n1">Первое натуральное число</param>
        /// <param name="n2">Второе натуральное число</param>
        /// <returns>Будет возвращен результат вычисления первой цифры деления и умноженной на 10^k, где k - ее разряд</returns>
        public static Natural Run(Natural n1, Natural n2)
        {
            

            n1.Clear(); n2.Clear();
            
            if (N_1.Run(n1, n2) == 1)
            {
                Natural temp = n1;
                n1 = n2;
                n2 = temp;
            }

            Natural value = new Natural(new int[n2.Length]);
            int k = 0;
            
            while (N_1.Run(value, n2) == 1)
            {

                value.Value[k] = n1.Value[k];
                k++;
            }
            
            int i;
            for (i = 0; i < 10; i++)
            {
                if (N_1.Run(N_6.Run(value, i + 1), n2) != 1)
                    break;
            }
            if (i == 0) i = 1;

            int[] result = new int[k];
            result[0] = i;
            return new Natural(result);
        }
    }       
}
