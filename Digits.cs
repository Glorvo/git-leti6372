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
    public class Natural
    {
        /// <summary>
        /// Разряды числа
        /// </summary>
        public int[] Value;

        /// <summary>
        /// Доступ к длине массива разрядов по .Lenght
        /// </summary>
        public int Length
        {
            get { return Value.Length; }
        }

        /// <summary>
        /// Инициализация положительного числа
        /// </summary>
        /// <param name="Arr">Массив разрядов</param>
        public Natural(int[] Arr)
        {
            Value = Arr;
        }

        /// <summary>
        /// Вспомогательная функция, очищающая "лишние" нули: 0234 станет 234
        /// </summary>
        /// <returns>Для удобства, возвращает себя же</returns>
        public Natural Clear()
        {
            //0013 = {3100}
            int counter = 0;
            for (int i = Value.Length - 1; i >= 0 && Value[i] == 0; --i)
                counter++;
            Value = SubArray(Value, Value.Length  - counter);
            if (Value.Length == 0)
                Value = new int[] { 0 };
            return this;
        }

        /// <summary>
        /// Вспомогательная функция, "вырезает" часть массива
        /// </summary>
        /// <param name="data">Обрезаемый массив</param>
        /// <param name="length">Необходимая длина</param>
        /// <returns></returns>
        static int[] SubArray(int[] data, int length)
        {
            int[] result = new int[length];
            Array.Copy(data, 0, result, 0, length);
            return result;
        }

        /// <summary>
        /// Перезагрузка оператора [], позволяющая получить доступ к значению через аналогичный массиву синтаксис
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int this[int num]
        {
            get { return Value[num]; }
            set { Value[num] = value; }
        }
    }

    /// <summary>
    /// Целое число. Содержат в себе знак числа и его разряды.
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
        public Natural Value;

        /// <summary>
        /// Доступ к длине массива разрядов по .Lenght
        /// </summary>
        public int Length
        {
            get { return Value.Length; }
        }

        /// <summary>
        /// Инициализация числа любого знака
        /// </summary>
        /// <param name="sign">Знак числа (true - плюс, false - минус)</param>
        /// <param name="Arr">Массив разрядов</param>
        public Digit(bool sign, int[] Arr)
        {
            Sign = sign;
            Value = new Natural(Arr);
        }

        /// <summary>
        /// Инициализация числа любого знака
        /// </summary>
        /// <param name="sign">Знак числа (true - плюс, false - минус)</param>
        /// <param name="data">Модуль числа</param>
        public Digit(bool sign, Natural data)
        {
            Sign = sign;
            Value = data;
        }

        /// <summary>
        /// Инициализация положительного числа
        /// </summary>
        /// <param name="Arr">Массив разрядов</param>
        public Digit(int[] Arr)
        {
            Value = new Natural(Arr);
        }

        /// <summary>
        /// Инициализация положительного числа
        /// </summary>
        /// <param name="data">Модуль числа</param>
        public Digit(Natural data)
        {
            Value = data;
        }

        /// <summary>
        /// Вспомогательная функция, очищающая "лишние" нули: -0234 станет -234
        /// </summary>
        /// <returns>Для удобства, возвращает себя же</returns>
        public Digit Clear()
        {
            Value.Clear();
            return this;
        }

        /// <summary>
        /// Перезагрузка оператора [], позволяющая получить доступ к значению через аналогичный массиву синтаксис
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int this[int num]
        {
            get { return Value[num]; }
            set { Value[num] = value; }
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

            if (!(num.Sign || denom.Sign))
                Denominator.Sign = false;
        }

        /// <summary>
        /// Вспомогательная функция, очищающая "лишние" нули: -0234 станет -234
        /// </summary>
        /// <returns>Для удобства, возвращает себя же</returns>
        public Rational Clear()
        {
            Numerator.Clear();
            Denominator.Clear();
            return this;
        }
    }

   /* public class Polynomial
    {
        public Rational[] Values;

        /// <summary>
        /// Вспомогательная функция, очищающая "лишние" нули: -0234 станет -234
        /// </summary>
        /// <returns>Для удобства, возвращает себя же</returns>
        public Polynomial Clear()
        {
            foreach (Rational R in Values)
            {
                R.Clear();
            }
            return this;
        }
    }*/
}
