namespace DiskMat
{
    /// <summary>
    /// Модуль Z_2, выводит число 2,1,0 в зависимости от знака числа
    /// Борзенко Руслан
    /// </summary>
    static class Z_2
    {
        /// <summary>
        /// Выводит число в зависимости от знака
        /// </summary>
        /// <param name="input">Целое число</param>
        /// <returns>0 - число равно 0, 1 - чило положительно, 2 - число отрицательно</returns>
        public static int Run(Digit input)
        {
            
            if (input.Clear().Length == 1 && input[0] == 0)
                return 0;
            if (input.Sign)
                return 1;
            else
                return 2;
        }
    }
}