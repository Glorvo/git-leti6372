using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiskMat
{
    /// <summary>
    /// Старший коэффициента многочлена
    /// Гудошников Роман
    /// </summary>
    static class P_5
    {
        /// <summary>
        /// Функция находит значение старшего коэф-та многочлена
        /// </summary>
        /// <param name="polynom">Объект класса многочлен</param>
        /// <returns>Старший коэффициент многочлена</returns>
        public static Rational Run(Polynomial polynom)
        {
            int leadDeg = polynom.Values.Length - 1;                              //Текущее значение старшей степени
            while ((N_2.Run(polynom.Values[leadDeg].Numerator)) && (leadDeg > 0)) //Допустим, что в ходе других действий старший к-т и другие могли обнулиться,
                leadDeg--;                                                        //но остались в массиве. Цикл отсеивает такие эл-ты, ибо они уже не являются
            return polynom.Values[leadDeg];                                       //старшим к-том. Иначе совсем скучно
        }
    }
}
