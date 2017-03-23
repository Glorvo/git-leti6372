﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Модуль N_6 Умножает натуральное число на цифру
    /// Симонян Даниил
    /// </summary>
    static class N_6
    {
        /// <summary>
        /// Умножение натурального числа на цифру
        /// </summary>
        /// <param name="input">Число, которое поступает на обработку</param>
        /// <param name="numeral">Цифра, на которую умножается число</param>
        /// <returns>Будет возвращен результат умножения натурального числа на цифру</returns>
        public static Natural Run(Natural input, int numeral)
        {
            Natural Result = new Natural(new int[input.Length + 1]);
            int edinicavyme = 0;
            for (int k = 0; k < Result.Length-1; k++)
            {
                Result[k] = ((numeral * input[k]) % 10 + edinicavyme) % 10;
                edinicavyme = (numeral * input[k] + edinicavyme) / 10;
            }
            Result[Result.Length - 1] = edinicavyme % 10;
            Result.Clear();
            return Result;
        }
    }
}
