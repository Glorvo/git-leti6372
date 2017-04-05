using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// модуль Q_7, Умножение дробей
    /// Дорош Татьяна
    /// </summary>
    static class Q_7
    {
              /// <summary>
             /// Умножение дробей
             /// </summary>
             /// <param name = "A"> Дробь 1 </param>
             /// <param name = "B"> Дробь 2 </param>
             /// <returns> Перемноженные дроби </returns>
             public static Rational Run(Rational A, Rational B)
            {
             Rational ret = new Rational(new Digit(new int[] { }), new Digit(new int[] { }));
             
             ret.Numerator = Z_8.Run(A.Numerator, B.Numerator);
             ret.Denominator = N_8.Run(A.Denominator, B.Denominator);
            return Q_1.Run(ret.Clear());
        }
 
     }
 
 }

