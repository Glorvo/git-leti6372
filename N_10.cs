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
        /// Вычисление первой цифры деления и умножение ее на 10^k, где k - ее разряд (второе число не меньше первого)
        /// </summary>           
        /// <param name="n1">Первое натуральное число</param>
        /// <param name="n2">Второе натуральное число</param>
        /// <returns>Будет возвращен результат вычисления первой цифры деления и умноженной на 10^k, где k - ее разряд</returns>
        public static Natural Run(Natural n1, Natural n2)
        {
            

            n1.Clear(); n2.Clear();            

            if (N_1.Run(n1, n2) == 2) throw new Exception();                            // Если первое число меньше второго, то ошибка

            Natural temp = new Natural(new int[1]);
            int k = 0;
            do
            {
                if (temp.Length == k) temp = new Natural(new int[temp.Length + 1]);     // Если длинна передаваемого числа болььше длинны массива, увеличить его на 1
                
                for (int p = 0; p <= k; p++)                                            // Передача числа по разрядно из входящего во временный
                {
                    temp.Value[temp.Length - p - 1] = n1.Value[n1.Length - p - 1];
                }
                
                k++;
            } while (N_1.Run(temp, n2) == 2) ;

            int i = 1;
            while (N_1.Run(N_6.Run(n2, ++i), temp) != 1) ;                              // Вычисление первой цифры от деления чисел

            Natural result = new Natural(new int[n1.Length - k + 1]);
            result[result.Length - 1] = i - 1;

            return result;
        }
    }       
}
