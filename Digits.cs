using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    /// <summary>
    /// Натуральное число. Содержат в себе знак числа и его разряды.
    /// Хаханов Тимофей
    /// </summary>
    public class Digit
    {
        /// <summary>
        /// Знак числа (true - плюс, false - минус)
        /// </summary>
        public bool Sign = true;

        /// <summary>
        /// Разряды числа
        /// </summary>
        public int[] Data;

        /// <summary>
        /// Инициализация положительного числа
        /// </summary>
        /// <param name="Arr">Массив разрядов</param>
        public Digit(int[] Arr)
        {
            Data = Arr;
        }

        /// <summary>
        /// Инициализация числа любого знака
        /// </summary>
        /// <param name="sign">Знак числа (true - плюс, false - минус)</param>
        /// <param name="Arr">Массив разрядов</param>
        public Digit(bool sign, int[] Arr)
        {
            Sign = sign;
            Data = Arr;
        }
    }

    /// <summary>
    /// Рациональные числа. Содержат в себе числитель и знаменатель
    /// </summary>
    public class Rational
    {
        /// <summary>
        /// Числитель
        /// </summary>
        public Digit Numerator;

        /// <summary>
        /// Знаменатель
        /// </summary>
        public Digit Denominator;

        /// <summary>
        /// Перевод из натурального в рациональное (знаменатель = 1)
        /// </summary>
        /// <param name="num">Числитель, переводимое число</param>
        public Rational(Digit num)
        {
            Numerator = num;
            Denominator = new Digit(new int[] { 1 });
        }

        /// <summary>
        /// Инициализация рационального числа
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="denom">Знаменатель</param>
        public Rational(Digit num, Digit denom)
        {
            Numerator = num;
            Denominator = denom;
        }
    }
}
