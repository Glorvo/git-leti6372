using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Белоголов Григорий
/// Преобразование целого неотрицательного в натуральное
/// </summary>
namespace DiskMat
{
    static class Z_4
    {
        /// <summary>
        /// Целое неотрицательное число подается на вход
        /// </summary>
        /// <param name="input">Натуральное число </param>
        /// <returns></returns>
        public static Digit Run(Digit input)
        {
            Digit output = new Digit(input.Data);
            output.Sign = true;
            return output;
        }
    }
}