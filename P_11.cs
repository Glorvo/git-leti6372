using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// НОД многочленов
    /// Ларионов Сергей
    /// </summary>
    static class P_11
    {
        /// <param name="A">Делимое</param>
        /// <param name="B">Делитель</param>
        /// <returns>НОД</returns>
        public static Polynomial Run(Polynomial A, Polynomial B)
        {
            Polynomial C = new Polynomial(new Rational[A.Values.Length]);
            Rational E=new Rational(new Digit(new int[] {0}));
            while (!(P_5.Run(A)==E))
            {
                if (A.Values.Length < B.Values.Length)
                {
                    C = A;
                    A = B;
                    B = C;
                }
                A = P_10.Run(A, B);
            }
            return B;
        }
    }
}