using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DiskMat
{
	/// <summary>
	/// Вычитание из одного натурального другого, умноженного на цифру
	/// Стеценко Никита
	/// </summary>
	public static class N_9
	{
		/// <summary>
		/// Вычитание из одного натурального другого, умноженного на цифру
		/// </summary>
		/// <param name="Num1">Уменьшаемое</param>
		/// <param name="Num2">Вычитаемое</param>
		/// <param name="Multiplier">Множитель второго числа</param>
		/// <returns>Разность</returns>
		public static Natural Run(Natural Num1, Natural Num2, Natural Multiplier)
		{
			Natural Difference = new Natural("0");
			Natural Num2Multiplied = N_8.Run(Num2, Multiplier); // Умножаем второй множитель на цифру
			switch (N_1.Run(Num1, Num2Multiplied))// Если второе больше, меняем числа местами
			{
				case 0: // Если числа равны, то разность = 0
					{
						return Difference;
					}
				case 1: // Если первое больше, вычитаем из него второе
					{
						Difference = N_5.Run(Num1, Num2Multiplied);
						return Difference;
					}
				default: // Если второе больше, меняем числа местами и вычитаем
					{
						Natural NumSupport = Num1;
						Num1 = Num2Multiplied;
						Num2 = NumSupport;
						Difference = N_5.Run(Num1, Num2);
						return Difference;
					}
			}
		}
	}
}

