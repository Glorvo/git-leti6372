using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Складывает дроби;
    /// Холод Дарья
    /// </summary>
    static class Q_5
    {
        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="R1"> Дробь </param>
        /// <param name="R2"> Дробь </param>
        /// <returns>Будет возвращенa сумма R1 и R2 </returns> 
        public static Rational Run(Rational R1, Rational R2)
        {
          

            Digit NOK = new Digit (N_14.Run(R1.Denominator, R2.Denominator));//Находим наибольшее общее кратное знаменателей

            //Находим, на что надо домножить числитель, чтобы привести к единому знаменателю и, собственно, домножаем
            R1.Numerator = Z_8.Run(R1.Numerator, Z_9.Run(NOK, R1.Denominator));
            R2.Numerator = Z_8.Run(R2.Numerator, Z_9.Run(NOK, R2.Denominator));
           
            //Складываем 2 дроби. Новый числитель - сумма 2-х предыдущих, новый знаменатель - НОК
            Rational R = new Rational(Z_6.Run(R1.Numerator, R2.Numerator), NOK);
                 
            return Q_1.Run(R); //сокращенная дробь на выходе
        }
    }
}