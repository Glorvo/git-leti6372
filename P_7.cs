using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Вынесение из многочлена НОК знаменателей и НОД числителей 
    /// Белоголов Григорий 
    /// </summary>
    static class P_7
    {
        /// <summary>
        /// Функция сокращает многочлен
        /// </summary>
        /// <param name="polynom"> многочлен</param>
        /// <returns>Многочлен</returns>
        public static Polynomial Run(Polynomial polynom)
        {

            int i, j;
            int Len = polynom.Values.Length;
            Polynomial Pol = new Polynomial(polynom.Values);//Создается новая переменная полином
            Pol.Clear();// очищаем от лишних нулей
            Natural E = new Natural(new int[] { 1 });

            //Проверка на нулевые 
            Digit Null = new DiskMat.Digit(new int[] { 0 });

            // Алгоритм нахождения Нок
            Pol.Clear();// очищаем от лишних нулей
            E = Pol.Values[0].Denominator;
            for (i = 0; i < Len; ++i)// Алгоритм нахождения Нок
            {
                E = N_14.Run((E),(Pol.Values[i].Denominator));
            }
            Natural Gt = new Natural(E.Value);
            Digit HOK = new Digit(new int[] { 1 });
            HOK = new Digit(Gt.Value);

            //Алгоритм вынесения НОК
            Pol.Clear();// очищаем от лишних нулей
            bool e;
            for (i = 0; i < Len; i++)
            {
                e = Pol.Values[i].Numerator.Sign;
                Pol.Values[i].Numerator = Z_8.Run((Pol.Values[i].Numerator), Z_9.Run(HOK, Pol.Values[i].Denominator));// При убирании из знаменателя НОК, мы домножаем числитель на частное знаменателя и НОК
                Pol.Values[i].Denominator = new Natural(new int[] { 1 });
                Pol.Values[i].Numerator.Sign = e;
            }

            // Алгоритм нахождения НОД
            Pol.Clear();// очищаем от лишних нулей
            E = Z_5.Run(Pol.Values[0].Numerator);
            for (i = 0; i < Len; i++)// Алгоритм нахождения НОД
            {
                if (Pol.Values[i].Numerator != Null)
                {
                    E = N_13.Run(E, Z_5.Run(Pol.Values[i].Numerator));
                }
            }
                Natural HOD = E;// Запоминаем Наибольший общий делитель

                //Алгоритм вынесения НОД
                Pol.Clear();// очищаем от лишних нулей
                bool w;
                for (i = 0; i < Len; i++)
                {
                    if (N_1.Run(Z_5.Run(Pol.Values[i].Numerator), Z_5.Run(new Digit(new int[] { 0 }))) != 0)// Если в знаменателе не ноль, то работаем с ним
                    {
                        w = Pol.Values[i].Numerator.Sign;
                        Pol.Values[i].Numerator = Z_9.Run(Pol.Values[i].Numerator, HOD);// При убирании из числителя НОД , мы делим числитель на общий нод всех числителей
                        Pol.Values[i].Numerator.Sign = w;
                    }
                }
                Pol.Clear();// очищаем от лишних нулей
                return Pol;
            }

    }
}