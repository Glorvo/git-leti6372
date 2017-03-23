using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskMat
{
    public static class AddMath
    {
        /// <summary>
        /// Сравнение любых массивов
        /// </summary>
        /// <typeparam name="T">Тип</typeparam>
        /// <param name="a1">Первый массив</param>
        /// <param name="a2">Второй массив</param>
        /// <returns></returns>
        public static bool ArraysEqual<T>(T[] a1, T[] a2)
        {
            if (ReferenceEquals(a1, a2))
                return true;

            if (a1 == null || a2 == null)
                return false;

            if (a1.Length != a2.Length)
                return false;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < a1.Length; i++)
            {
                if (!comparer.Equals(a1[i], a2[i])) return false;
            }
            return true;
        }
    }


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
        /// Инициализация натурального числа
        /// </summary>
        /// <param name="Arr">Массив разрядов</param>
        public Natural(int[] Arr)
        {
            Value = Arr;
        }

        /// <summary>
        /// Инициализация натурального числа из строки
        /// </summary>
        /// <param name="s">Число</param>
        public Natural(string s)
        {
            Value = s.ToCharArray().Reverse().Select(x => int.Parse(x.ToString())).ToArray();
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

        //Равенство натуральных чисел
        public static bool operator ==(Natural d1, Natural d2)
        {
            return AddMath.ArraysEqual(d1.Value, d2.Value);
        }

        //Неравенство натуральных чисел
        public static bool operator !=(Natural d1, Natural d2)
        {
            return !(d1 == d2);
        }

        public override string ToString()
        {
            string s = "";
            foreach(int i in Value.Reverse())
                s += i;
            return s;
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
        /// Инициализация положительного числа
        /// </summary>
        /// <param name="data">Модуль числа</param>
        public Digit(string data)
        {
            Value = new Natural(data);
        }

        /// <summary>
        /// Инициализация числа
        /// </summary>
        /// <param name="sign">Знак числа</param>
        /// <param name="data">Модуль числа</param>
        public Digit(bool sign, string data)
        {
            Value = new Natural(data);
            Sign = sign;
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


        //Равенство целых чисел
        public static bool operator ==(Digit d1, Digit d2)
        {
            return d1.Value == d2.Value && d1.Sign == d2.Sign;
        }

        //Неравенство целых чисел
        public static bool operator !=(Digit d1, Digit d2)
        {
            return !(d1 == d2);
        }


        public override string ToString()
        {
            string s = "";
            foreach (int i in Value.Value.Reverse())
                s += i;
            return (Sign ? '+':'-')+s;
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
        /// Знак числа
        /// </summary>
        public bool Sign
        {
            //Возвращает знак числа
            get { return !(Denominator.Sign ^ Numerator.Sign); }
            //Устанавливает и нормирует знак числа (знак перед числителем, знаменатель положительный)
            set
            {
                Numerator.Sign = value;
                Denominator.Sign = true;
            }
        }

        /// <summary>
        /// Перевод из целого в рациональное (знаменатель = 1)
        /// </summary>
        /// <param name="num">Числитель, переводимое число</param>
        public Rational(Digit num)
        {
            Numerator = num;
            Denominator = new Digit("");
        }



        /// <summary>
        /// Перевод из натурального в рациональное (знаменатель = 1)
        /// </summary>
        /// <param name="num">Числитель, переводимое число</param>
        public Rational(Natural num)
        {
            Numerator = new Digit(num);
            Denominator = new Digit("1");
        }

        /// <summary>
        /// Перевод из натурального в положительное рациональное (знаменатель = 1)
        /// </summary>
        /// <param name="num">Числитель</param>
        public Rational(string num)
        {
            Numerator = new Digit(num);
            Denominator = new Digit("1");
        }

        /// <summary>
        /// Перевод из натурального в рациональное (знаменатель = 1)
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="sign">Знак</param>
        public Rational(bool sign, string num)
        {
            Numerator = new Digit(num);
            Denominator = new Digit("1");
            Sign = sign;
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

        /// <summary>
        /// Инициализация рационального числа
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="denom">Знаменатель</param>
        public Rational(string num, string denom)
        {
            Numerator = new Digit(num);
            Denominator = new Digit(denom);
        }

        /// <summary>
        /// Инициализация рационального числа
        /// </summary>
        /// <param name="sign">Знак</param>
        /// <param name="num">Числитель</param>
        /// <param name="denom">Знаменатель</param>
        public Rational(bool sign, string num, string denom)
        {
            Numerator = new Digit(num);
            Denominator = new Digit(denom);
            Sign = sign;
        }

        /// <summary>
        /// Инициализация рационального числа
        /// </summary>
        /// <param name="sign">Знак</param>
        /// <param name="num">Числитель</param>
        /// <param name="denom">Знаменатель</param>
        public Rational(bool sign, Digit num, Digit denom)
        {
            Numerator = num;
            Denominator = denom;
            Sign = sign;
        }

        /// <summary>
        /// Инициализация рационального числа
        /// </summary>
        /// <param name="sign">Знак</param>
        /// <param name="num">Числитель</param>
        /// <param name="denom">Знаменатель</param>
        public Rational(bool sign, Natural num, Natural denom)
        {
            Numerator = new Digit(num);
            Denominator = new Digit(denom);
            Sign = sign;
        }

        /// <summary>
        /// Инициализация положительного рационального числа
        /// </summary>
        /// <param name="num">Числитель</param>
        /// <param name="denom">Знаменатель</param>
        public Rational(Natural num, Natural denom)
        {
            Numerator = new Digit(num);
            Denominator = new Digit(denom);
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

        
        public override string ToString()
        {
            return (Sign ? "" : "-") + Numerator.Value + (Denominator.Value != new Natural("1") ? "/" + Denominator.Value : "");    
        }
    }

    public class Polynomial
    {
        public Rational[] Values;

        /// <summary>
        /// Инициализация полинома
        /// </summary>
        /// <param name="vals">Рациональные коэффициенты</param>
        public Polynomial(Rational[] vals)
        {
            Values = vals;
        }

        /// <summary>
        /// Инициализация полинома
        /// </summary>
        /// <param name="vals">Целые коэффициенты</param>
        public Polynomial(Digit[] vals)
        {
            Values = (from Digit d in vals
                      select new Rational(d)).ToArray();
        }

        /// <summary>
        /// Инициализация полинома
        /// </summary>
        /// <param name="vals">Натуральные коэффициенты</param>
        public Polynomial(Natural[] vals)
        {
            Values = (from Natural d in vals
                      select new Rational(d)).ToArray();
        }


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

        public override string ToString()
        {
            string ret = "";
            for(int i = Values.Length - 1; i >= 0; --i)
            {
                ret += "("+Values[i] + ")x^" + i + " + ";
            }
            return ret.Substring(0, ret.Length - 3);
        }
    }
}
