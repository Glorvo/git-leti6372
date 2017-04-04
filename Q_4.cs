using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль Q_4, Преобразование дробного в целое (если знаменатель равен 1/Число сокращаемо)
    /// Борзенко Руслан + Григорий Белоголов
    /// </summary>
    static class Q_4
    {
        /// <summary>
        /// Если знаменатель равен 1, выводит числитель
        /// </summary>
        /// <param name="num">Числитель</param> 
        /// <param name="denom">Знаменатель</param> 
        /// <returns>Numerator и Denomenator</returns>
        public static Digit Run(Rational A)
        {
            A = Q_1.Run(A);
            if (A.Denominator.Length == 1 && A.Denominator[0] == 1)
                return A.Numerator;
            throw new Exception();
        }
    }
}