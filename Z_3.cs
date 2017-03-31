namespace DiskMat
{
    /// <summary>
    /// Умножение целого на (-1)
    /// Першин Кирилл
    /// </summary>
    public static class Z_3
    {
        /// <summary>
        /// Умножение целого на (-1)
        /// </summary>
        /// <param name="A"> множитель</param>
        /// <returns>Умноженное число</returns>
        public static Digit Run(Digit A)
        {
            return new Digit(!A.Sign, A.Value);
        }

    }
}