using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Умножение многочлена на x^k
    /// Гудошников Роман
    /// </summary>
    static class P_4
    {
        /// <summary>
        /// Функция создает новый массив к-тов, получаемый при умножении исходного на х^к
        /// </summary>
        /// <param name="polynom">Объект класса многочлен</param>
        /// <param name="k">Степень множителя-одночлена</param>
        /// <returns>Многочлен, полученный умножением исходного на x^k</returns>
        public static Polynomial Run(Polynomial polynom, int k)
        {
            int resSize = polynom.Values.Length + k;                         //Степень результирующего многочлена
            Polynomial resPolynom = new Polynomial(new Rational[resSize]);   //Результирующий многочлен
            for (int i = resSize - 1; i >= k; i--)
                resPolynom.Values[i] = polynom.Values[i - k];
            for (int i = k - 1; i >= 0; i--)
                resPolynom.Values[i] = new Rational(new Digit(new int[] { 0 }));
            return resPolynom;
        }
    }
}
