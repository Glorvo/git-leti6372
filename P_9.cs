namespace DiskMat
{
    /// <summary>
    /// Частное от деления многочленов.
    /// Ларионов Сергей
    /// </summary>
    static class P_9
    {
        /// <summary>
        /// Находит Частное от деления многочленов
        /// </summary>
        /// <param name="A">Делимое</param>
        /// <param name="B">Делитель</param>
        /// <returns>Частное</returns>
        public static Polynomial Run(Polynomial A, Polynomial B)
        {
            int i = 0;
            Polynomial Chastnoe = new Polynomial(new Rational[P_6.Run(A) - P_6.Run(B)]);
            Rational E;
            while (P_6.Run(A) >= P_6.Run(B)) // Выполняется пока можно делить(т.е. пока степень Делимого >= степ. Делителя)
            {
                E = Q_8.Run(P_5.Run(A), P_5.Run(B));//Находим коэфициент частного(Е), который будем умнажать на делитель
                Chastnoe.Values[i] = E; // записываем в частное коэфициент
                A = P_2.Run(A, (P_3.Run(B, E)));// Вычитаем из Делимого произведение Е на Делитель. И заменяем предыдущее Делимое полученным.
                i++;
            }
            return Chastnoe;
        }
    }
}