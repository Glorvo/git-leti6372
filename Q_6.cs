using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Вычитание рациональных чисел
    /// Пульнева Ксения
    /// </summary>
    public static class Q_6
    {
        /// <summary>
        /// Костыль, приводящий дробь к адекватному виду
        /// </summary>
        /// <param name="A">Дробь</param>
        public static void Kostil(ref Rational A)
        {
            if (A.Denominator.Sign==false)
            {
                A.Numerator.Sign = !A.Numerator.Sign;
                A.Denominator.Sign = true;
            }
        } 

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="A">Уменьшаемое</param>
        /// <param name="B">Вычитаемое</param>
        /// <returns>Результирующая дробь</returns>
        public static Rational Run(Rational A, Rational B)
        {
            //инкостыляция
            Kostil(ref A);
            Kostil(ref B);

            //Перевод НОК из натурального в целое
            Digit NOK= new Digit(true, N_14.Run(A.Denominator.Value,B.Denominator.Value));

            //Под общий знаменатель
            A.Numerator = Z_8.Run(A.Numerator, Z_9.Run(NOK, A.Denominator.Value));
            B.Numerator = Z_8.Run(B.Numerator, Z_9.Run(NOK, B.Denominator.Value));

            //Формируем результат: числитель как разность числителей, а знаменатель как НОК знаменателей
            Rational Result = new Rational(Z_7.Run(A.Numerator, B.Numerator), NOK);

            //Результат - сокращенная дробь
            return Q_1.Run(Result);
        }


    }
    
}
