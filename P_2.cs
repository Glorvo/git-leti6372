using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Вычитание многочленов
    /// Пульнева Ксюня
    /// </summary>
    public static class P_2
    {
        /// <summary>
        /// Вычитание многочленов
        /// </summary>
        /// <param name="A">Уменьшаемое</param>
        /// <param name="B">Вычитаемое</param>
        /// <returns>Результат вычитания многочленов</returns>
        public static Polynomial Run(Polynomial A, Polynomial B)
        {
            Rational nul = new Rational("0", "1");
            if (A.Values.Length>B.Values.Length)
            {
               for(int i=0; i<B.Values.Length; i++)
                {
                    A.Values[i] = Q_6.Run(A.Values[i], B.Values[i]);
                }
                return A.Clear();
            }
            else
            {
                for(int i=0; i<A.Values.Length; i++)
                {
                    B.Values[i] = Q_6.Run(A.Values[i], B.Values[i]);
                }
                for (int i=A.Values.Length; i<B.Values.Length; i++)
                {
                    B.Values[i] = Q_6.Run(nul, B.Values[i]);
                }
                return B.Clear();
            }
        }
    }
}
