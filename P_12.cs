using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiskMat
{
    /// <summary>
    /// Производная многочлена
    /// Осипова Диана
    /// </summary>
    static class P_12
    {
        /// <summary>
        /// Функция находит производную многочлена
        /// </summary>
        /// <param name="polynom"> многочлен</param>
        /// <returns>Производная</returns>
        public static Polynomial Run(Polynomial polynom)
        {
            Polynomial Pol = new Polynomial(polynom.Values);//Создается новая переменная полином
            for(int i=0; i<polynom.Values.Length-1 ;++i)// Цикл для перенесения коэфицентов в новую переменную(После дифференциирования)
            {
                Pol.Values[i] = new Rational(N_6.Run(Z_5.Run(Pol.Values[i + 1].Numerator),i+1)) ;// Коэффицент умножается на степень и записывается в предыдущий элемент 
            }
            Pol.Values[polynom.Values.Length-1] = new Rational(N_6.Run(Z_5.Run(Pol.Values[0].Numerator),0));
            Pol.Clear();// очищаем от лишних нулей
            return Pol;
        }
    }
}