using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{/// <summary>
///  Модуль N_6 Сравнивает натуральные числа
///  Ахметова Айнур
/// </summary>
    static class N_1
    {/// <summary>
     /// Сравнение натуральных чисел
     /// </summary>
     /// <param name="num1">Число, которое поступает на обработку</param>
     /// <param name="num2">Число, которое поступает на обработку</param>
     /// <returns>Будет возвращено: 0 (равны), 1 (первое больше), 2 (второе больше) </returns>

        public static int Run(Natural num1, Natural num2)
        {
            if (num1.Clear().Length > num2.Clear().Length)
                return 1;
            if (num1.Length < num2.Length)
                return 2;

            int a = Math.Max(num1.Length, num2.Length);
            int Count = 0;

            for (int i = a - 1; i >= 0; i--)
            {
                if (num1[i] == num2[i])
                    Count++;
                else break;
            }

            if (Count == a)
                return 0;
            if (num1[a - Count - 1] > num2[a - Count - 1])
                return 1;
            return 2;

        }
    }
}
