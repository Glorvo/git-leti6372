using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль N_11 вычисляет частное от деления
    /// Ахметова Айнур +Симонян Даниил
    /// </summary>
    static class N_11
    {
        /// <summary>
        /// Вычисление частного от деления
        /// </summary>
        /// <param name="num1">Первое число, которое поступает на обработку</param>
        /// <param name="num2">Второе число, которое поступает на обработку</param>
        /// <returns>Будет возвращено частное</returns>
        public static Natural Run(Natural num1, Natural num2)
        {
            num1.Clear(); num2.Clear();
            if (N_1.Run(num1, num2) == 2 || N_2.Run(num2)) throw new Exception(); // если второе число больше, то ошибка
            Natural Result = N_10.Run(num1, num2);        // вычисление первой цифры деления
            Natural Prom = N_9.Run(num1, num2, Result);   // вычитание из первого числа второго, умноженного на первую цифру деления
            Natural PromResult = new Natural(new int[1]);
            while(N_1.Run(num2,Prom)==2)
            {
                PromResult = N_10.Run(Prom, num2);
                Prom = N_9.Run(Prom, num2, PromResult);
                Result = N_4.Run(Result, PromResult);
            }
            num1 = N_4.Run(N_8.Run(num2,Result), Prom);
            return Result;
        }
    }
}