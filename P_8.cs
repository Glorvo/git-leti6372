using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Умножение многочленов
    /// Гудошников Роман
    /// </summary>
    static class P_8
    {
        /// <summary>
        /// Функция перемножает два исходных многочлена
        /// </summary>
        /// <param name="polynom1">Первый множитель-многочлен</param>
        /// <param name="polynom2">Второй множитель-многочлен</param>
        /// <returns>Многочлен, являющийся результатом перемножения</returns>
        public static Polynomial Run(Polynomial polynom1, Polynomial polynom2)
        {
            int resDeg = P_6.Run(polynom1) + P_6.Run(polynom2);                  //Степень результирующего многочлена
            Polynomial resPolynom = new Polynomial(new Rational[resDeg + 1]);    //Результирующий многочлен
            for (int i = 0; i < resDeg + 1; i++)
                resPolynom.Values[i] = new Rational("0");
            for (int deg1 = 0; deg1 < polynom1.Values.Length; deg1++)             //Для каждого элемента первого могочлена
                for (int deg2 = 0; deg2 < polynom2.Values.Length; deg2++)         //На каждый элемент второго многочлена
                {
                    Rational coefficient = Q_7.Run(polynom1.Values[deg1], polynom2.Values[deg2]);          //Находим произведение коэффициентов    
                    resPolynom.Values[deg1 + deg2] = Q_5.Run(resPolynom.Values[deg1 + deg2], coefficient); //И прибавляем его к соответсвующему элементу
                }                                                                                          //Результирующего многочлена
            return resPolynom;
        }
    }
}
