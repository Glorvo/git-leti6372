using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Белоголов Григорий
/// Преобразование натурального в целое
/// </summary>
namespace DiskMat
{
    static class Z_4
    {
        /// <summary>
        /// На вход подается натуральное число
        /// </summary>
        /// <param name="input"> Натуральное число</param>
        /// <returns>Целое число</returns>
        public static Digit Run(Natural input)
        {
            return new Digit(true,input.Value).Clear();
        }
    }
}