using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Добавление единицы к натуральному числу
    /// Хаханов Тимофей
    /// </summary>
    static class N_3
    {
        /// <summary>
        /// +1 к числу
        /// </summary>
        /// <param name="input">Число</param>
        /// <returns>Число + 1</returns>
        public static Natural Run(Natural input)
        {
            int i = 0;
            while(input[i]==9)
            {
                input[i++] = 0;
                if(i == input.Length)
                {
                    int[] temp = new int[input.Length + 1];
                    input.Value.CopyTo(temp, 0);
                    input.Value = temp;
                    break;
                }

            }
            input[i]++;
            return input;
        }


    }
}
