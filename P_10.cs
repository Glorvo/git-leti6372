namespace DiskMat
{
    /// <summary>
    /// Остаток от деления многочленов
    /// Ларионов Сергей
    /// </summary>
    static class P_10
    {
        /// <param name="A">Делимое</param>
        /// <param name="B">Делитель</param>
        /// <returns>Остаток</returns>
        public static Polynomial Run(Polynomial A, Polynomial B)
        {
            int i = A.Values.Length;
            Polynomial C = new Polynomial(new Rational[i]);
            C = A;
            Rational E;
            while (A.Values.Length >= B.Values.Length)   // Выполняется пока можно делить(т.е. пока степень Делимого >= степ. Делителя)
            {
                E = Q_8.Run(P_5.Run(A), P_5.Run(B));  //Находим коэфициент частного(Е), который будем умнажать на делитель
                C = P_4.Run((P_3.Run(B, E)), A.Values.Length - B.Values.Length);
                A = P_2.Run(A, C);   // Вычитаем из Делимого произведение Е на Делитель. И заменяем предыдущее Делимое полученным.
            }
            return A; // После цикла получили многочлен который не делится на Делитель(т.е. остаток)
        }
    }
}