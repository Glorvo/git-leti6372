using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Дорош Татьяна
/// Модуль Z_1, Выводит модуль целого числа
/// </summary>

namespace DiskMat
{
    static class Z_1
    {
         /// <summary>
        /// выводится модуль числа
       /// </summary>
      /// <param name="input">целое число</param>
     /// <returns>модуль числа</returns> 
        public static Natural Run (Digit input)
        {
            return input.Value;
        }
    }
}
