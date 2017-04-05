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
    static class Z_5
    {
        /// <summary>
        /// На вход подается целое число 
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Натуральное число</returns>
        public static Natural Run(Digit input)
        {
            return input.Value.Clear();
        }
    }
}
