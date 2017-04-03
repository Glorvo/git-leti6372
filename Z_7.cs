using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Вычитание целых чисел
    /// Кирилл Першин + Бараняк Данила
    /// </summary>
    static class Z_7
    {
        /// <summary>
        /// Вычитание целых чисел (в т.ч. отрицательных)
        /// </summary>
        /// <param name="A">Уменьшаемое</param>
        /// <param name="B">Вычитаемое</param>
        /// <returns>Разность</returns>
        public static Digit Run(Digit A, Digit B)
        {
            Digit result = new Digit("0");
            result.Sign = true;            

            int len = Math.Min(A.Length, B.Length);
            switch (N_1.Run(A.Value, B.Value))      
            {
                case 1:
                    if (A.Sign == B.Sign)                    
                        result = Dif(A, B, len);
                    else
                        result.Value = N_4.Run(A.Value, B.Value);
                    result.Sign = A.Sign;
                    break;

                case 2:
                    if (A.Sign == B.Sign)
                        result = Dif(B, A, len);
                    else
                        result.Value = N_4.Run(A.Value, B.Value);                                     
                    result.Sign = !B.Sign;
                    break;

                case 0:
                    if (A.Sign != B.Sign)
                        result = new Digit(N_6.Run(A.Value, 2));
                    result.Sign = A.Sign;
                    break;
            }         
            return result.Clear();        
        }


        /// <summary>
        /// Функция вычитания
        /// </summary>
        static Digit Dif(Digit D1, Digit D2, int len)
        {
            Digit Result = D1;
            Result.Sign = true;

            for (int i = (len - 1); i >= 0 ; i--)                                             // проход по всем разрядам числа, начиная с последнего, не доходя до первого
            {
                if (i >= (len - 1))                                                            // если текущий разряд чисел не первый
                {
                    Result.Value[i - 1]--;                                                        // в следующуем разряде большего числа занимаем 1.
                    Result.Value[i] += 10;                                                      // в ответ записываем сумму значения текущего разряда большего числа и 10-ти
                }                                                       

                Result.Value[i] -= D2.Value[i];                                           // вычитаем значение текущего разряда меньшего числа

                if (Result.Value[i] / 10 > 0)                                                 // если значение в текущем разряде двухразрядное
                {
                    Result.Value[i - 1]++;                                                  // переносим единицу в старший разряд
                    Result.Value[i] %= 10;                                                   // в текущем разряде отсекаем ее
                }
            }
            return Result;
        }
    }
}
