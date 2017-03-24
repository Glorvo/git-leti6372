using System;

namespace DiskMat

    {
        /// <summary>
        /// Модуль N_7, умножает число на 10^k
        /// Шашков Дмитрий
        /// </summary>
        /// 
        static class N_7
           {
            /// <summary>
            /// Умноженает исходное число на 10^k
            /// </summary>
            /// <param name="k">Степень в которую возводится 10</param>
            /// <param name="newArr">новый массив в который перезаписывается исходный</param>

            public static Natural Run(Natural input, int k)

                {

                    int[] newArr = new int[input.Length + k]; //создание массива большоего на k элементов

                    input.Value.CopyTo(newArr, k); //Переносим число в расширенный массив с нуными нулями

                    return new Natural(newArr); //Возвращаям измененный массив
                }

            }
    }

