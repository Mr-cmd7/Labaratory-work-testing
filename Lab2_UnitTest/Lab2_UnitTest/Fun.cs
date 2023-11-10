using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_UnitTest
{
    public class Fun
    {
        // Функция для расчета суммы цифр двухзначного числа
        public static int GetSumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        // Метод для поиска всех четырехзначных счастливых номеров
        public static List<int> FindHappyNumbers()
        {
            List<int> happyNumbers = new List<int>();
            for (int number = 1000; number <= 9999; number++)
            {
                int firstTwoDigits = number / 100;
                int lastTwoDigits = number % 100;

                if (GetSumOfDigits(firstTwoDigits) == GetSumOfDigits(lastTwoDigits))
                {
                    happyNumbers.Add(number);
                }
            }
            return happyNumbers;
        }
    }
}
