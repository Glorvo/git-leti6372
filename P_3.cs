using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Умножение многочлена на рациональное число
    /// Пульнева Ксения
    /// </summary>
    public static class P_3
    {
        /// <summary>
        /// Умножение многочлена на рациональное число
        /// </summary>
        /// <param name="polynom">Многочлен</param>
        /// <param name="number">Рациональное число</param>
        /// <returns>Результат умножения многочлена на рациональное число</returns>
        public static Polynomial Run(Polynomial polynom, Rational number)
        {
            //Умножение каждого коэффициента на рациональное число
            for(int i=0; i<polynom.Values.Length;i++)
            {
                polynom.Values[i] = Q_7.Run(polynom.Values[i], number);
            }
            return polynom;
        }
    }
}
