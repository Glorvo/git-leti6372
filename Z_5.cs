using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Белоголов Григорий Дмитриевич
// Преобразование целого неотрицательного в натуральное
// Знак числа: 1- минус, 0 - плюс.
namespace Z_5
{
    static class Z_5
    {
        public static int[] Run(int[] input)
        {
            int[] output = new int[input.Length-1];
            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i + 1];
            }
            return output;
        }
    }
}
