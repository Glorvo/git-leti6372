using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Белоголов Григорий Дмитриевич
// Функция по переводу натурального числа в целое 
// Входные данные масссив int натурального числа
// Знак числа: 1- минус, 0 - плюс.
namespace Z_4
{
    static class Z_4
    {
        public static int[] Run(int [] input)
        {
            int[] output = new int[input.Length+1];
            output[0] = 0;// Число положительное
            for(int i=1;i<=(input.Length +1);i++)
            {
                output[i] = input[i - 1];
            }
            return output;
        }
    }
}
