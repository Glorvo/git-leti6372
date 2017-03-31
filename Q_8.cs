using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Белоголов Григорий Дмитриевич
/// Деление дробей
/// </summary>
namespace DiskMat
{
        public static class Q_8
        {
            /// <summary>
            /// Деление дробей
            /// </summary>
            /// <param name="A">Первая дробь </param>
            /// <param name="B">Вторая дробь </param>
            /// <returns>Поделенные дроби </returns>
            public static Rational Run(Rational A, Rational B)
            {
            Rational output = new Rational(new Digit(new int[] {  }),new Digit(new int[] { }));// создаем локальную переменную
            output.Numerator = Z_8.Run(A.Numerator,B.Denominator);// определяем числитель новой дроби
            output.Denominator = Z_8.Run(A.Denominator, B.Numerator);// определяем знаментатель
            return output;
            }

        }
}
