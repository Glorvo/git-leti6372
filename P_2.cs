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
                Rational[] a = new Rational[A.Values.Length];
                Polynomial Res = new Polynomial(a);

                for (int i=0; i<B.Values.Length; i++)
                {
                    Res.Values[i] = Q_6.Run(A.Values[i], B.Values[i]);
                }
                for(int i=B.Values.Length;i<A.Values.Length;i++)
                {
                    Res.Values[i] = A.Values[i];
                }
                return Res.Clear();
            }
            else
            {
                Rational[] a = new Rational[B.Values.Length];
                Polynomial Res = new Polynomial(a);

                for (int i=0; i<A.Values.Length; i++)
                {
                    Res.Values[i] = Q_6.Run(A.Values[i], B.Values[i]);
                }
                for (int i=A.Values.Length; i<B.Values.Length; i++)
                {
                    Res.Values[i] = Q_6.Run(nul, B.Values[i]);
                }
                return Res.Clear();
            }
        }
    }
}
