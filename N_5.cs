using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{/// <summary> 
///  Модуль N_5 Вычитает натуральные числа 
///  Чипизубова Алина
/// </summary> 

    static class N_5
    {/// <summary> 
     /// Вычитание из первого большего натурального числа второго меньшего или равного
     /// </summary> 
     /// <param name="A">Большее число, которое поступает на обработку</param> 
     /// <param name="B">Меньшее или равное число, которое поступает на обработку</param> 
     /// <returns>Результат вычитания из большего меньшего</returns> 
        public static Natural Run(Natural A, Natural B)
        {
            int b = Math.Max(A.Length, B.Length);
            switch (N_1.Run(A, B))
            {
                case 0:  //Если оба числа равны, результатом вычитания будет 0
                    return new Natural("0");
                case 1:   //Если первое число больше, вычитаем из него первое
                    {
                        int c = b - (b - B.Length) - 1;
                        for (int i = 0; i <= c; i++)
                        {
                            A[i] = A[i] - B[i];   //Поразрядное вычитание
                            if (A[i] < 0)
                            {
                                A[i] = A[i] + 10;           //Избавление от отрицательности
                                A[i + 1] -= 1;   //"Занятие" единицы у следующего разряда
                            }
                        }

                    }
                    return A.Clear();

                default:   // Если второе число больше, то условие не выполняется
                    throw new Exception();
            }

        }
    }
}