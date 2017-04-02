using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
        /// <summary>
        /// Модуль N_14 вычисляет НОK натуральных чисел
        /// Осипова Диана
        /// </summary>
        static class N_14
        {
            /// <summary>
            /// НОК натуральных чисел 
            /// </summary>
            /// <param name="A">Первое натуральное число</param>
            /// <param name="B">Второе натуральное число</param>
            /// <returns>Будет возвращено Наименьшее общее кратное </returns>
            public static Natural Run(Natural A, Natural B)
            {
            A.Clear(); B.Clear();// Переменные очищаются от лишних нулей
            Natural output = N_11.Run(N_8.Run(A, B), N_13.Run(A, B)); // НОК = (a*b)/НОД(a,b) - это формула
            return output;
            }
        }
}
