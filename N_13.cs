using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль N_13 вычисляет НОД натуральных чисел
    /// Симонян Даниил
    /// </summary>
    static class N_13
    {
        /// <summary>
        /// НОД натуральных чисел 
        /// </summary>
        /// <param name="num1">Первое натуральное число</param>
        /// <param name="num2">Второе натуральное число</param>
        /// <returns>Будет возвращен наибольший общий делитель</returns>
        public static Natural Run(Natural num1, Natural num2)
        {
            num1.Clear(); num2.Clear();
            Natural A1 = num1;
            Natural A2 = num2;
            Natural NodSup = new Natural("0");
            if (N_1.Run(num1, num2) == 2)      // Если второе число больше, меняем их местами
              {
                Natural Asupport = num1;
                A1 = A2;
                A2 = Asupport;
              }
            while (N_2.Run(A2) == false)  // Пока второе число не будет равно 0
             {
                NodSup = N_12.Run(A1, A2);
                A1 = A2;
                A2 = NodSup;
             }
            return A1.Clear();  // Возвращение НОД 
        }
    }
}
