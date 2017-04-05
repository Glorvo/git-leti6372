using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{/// <summary> 
///  Модуль P_1 Складывает многочлены
///  Чипизубова Алина
/// </summary> 

    static class P_1
    {/// <summary> 
     /// Сложение многочленов
     /// </summary> 
     /// <param name="A">Первый многочлен</param> 
     /// <param name="B">Второй многочлен</param> 
     /// <returns>Результат сложения двух многочленов</returns> 
        public static Polynomial Run(Polynomial A, Polynomial B)
        {

            int b = Math.Max(A.Values.Length, B.Values.Length); //Максимальная длинна многочлена
            Polynomial resC = new Polynomial(new Rational[b]);  //Новая переменная для нового многочлена

            if (A.Values.Length >= B.Values.Length)
            {

                for (int i = 0; i < b; i++)
                {
                    resC.Values[i] = A.Values[i];                          //Копирование многочлена с большей степенью в новую переменную
                }                                                        //Для сохранения исходных данных
                for (int i = 0; i < B.Values.Length; i++)
                {
                    resC.Values[i] = Q_5.Run(resC.Values[i], B.Values[i]);    //Сложение коэфицентов при одинаковых степенях
                }
                return resC.Clear();
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    resC.Values[i] = B.Values[i];                          //Копирование многочлена с большей степенью в новую переменную
                }                                                        //Для сохранения исходных данных
                for (int i = 0; i < A.Values.Length; i++)
                {
                    resC.Values[i] = Q_5.Run(resC.Values[i], A.Values[i]);    //Сложение коэфицентов при одинаковых степенях
                }
                return resC.Clear();
            }

        }
    }
}