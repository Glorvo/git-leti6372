namespace DiskMat
{
    /// <summary>
    /// Сложение целых чисел
    /// Иван Сесин
    /// </summary>
    class Z_6
    {
        /// <summary>
        /// Сложение целых чисел (в т.ч. отрицательных)
        /// </summary>
        /// <param name="n1">Слогаемое</param>
        /// <param name="n2">Слогаемое</param>
        /// <returns>Сумма</returns>
        public static Digit Run(Digit n1, Digit n2)
        {   
            if (n1.Sign == n2.Sign)//Равные знаки - возвращаем сумму с тем же знаком
                return new Digit(n1.Sign, N_4.Run(n1.Value, n2.Value));
            if (N_1.Run(n1.Value, n2.Value) == 0)//Одинаковые числа и разные знаки - возвращаем 0
                return new Digit("0");

            //Разные числа и знаки - возвращем знак большего числа и модуль разности
            return new Digit((N_1.Run(n1.Value, n2.Value) == 1)? n1.Sign : n2.Sign, N_5.Run(Max(n1.Value, n2.Value), Min(n1.Value, n2.Value)));
        }

        /// <summary>
        /// Выбор максимального значения
        /// </summary>
        static Natural Max(Natural N1, Natural N2)
        {
            if (N_1.Run(N1, N2) == 1)
                return N1;
            else
                return N2;
        }

        /// <summary>
        /// Выбор минимального значения
        /// </summary>
        static Natural Min(Natural N1, Natural N2)
        {
            if (N_1.Run(N1, N2) == 2)
                return N1;
            else
                return N2;
        }
    }
}
