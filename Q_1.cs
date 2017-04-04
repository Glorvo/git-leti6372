using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль Q_1 Сокращение дробей
    /// Белоголов Григорий
    /// </summary>
    static class Q_1
    {
        /// <summary>
        /// сокращение дроби
        /// </summary>
        /// <param name="A"> Дробь </param>
        /// <returns>Будет возвращенa сокращенная дробь </returns>
        public static Rational Run(Rational A)
        {
            A.Clear();
            Natural HOD = N_13.Run(Z_5.Run(A.Denominator), Z_5.Run(A.Numerator));// Находим НОД числителя и знаменателя
            A.Numerator = Z_9.Run(A.Numerator,HOD);//Сокращаем числитель на НОД числителя и знаменятеля
            A.Denominator = Z_9.Run(A.Denominator, HOD);// Сокращаем знаменатель на нод
            return A;
        }
    }
}