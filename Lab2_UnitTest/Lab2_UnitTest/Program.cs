//Получить все четырехзначные счастливые номера. Счастливым называется номер, у которого сумма первых двух цифр номера равна сумме
//последних двух цифр. Использовать функцию для расчета суммы цифр
//двухзначного числа.

using Lab2_UnitTest;

List<int> happyNumbers = Fun.FindHappyNumbers();

Console.WriteLine("Счастливые номера:");

int columnWidth = 8;
int columnCount = 15;

for (int i = 0; i < happyNumbers.Count; i++)
{
    Console.Write(happyNumbers[i].ToString().PadRight(columnWidth));
    if ((i + 1) % columnCount == 0)
    {
        Console.WriteLine(); 
    }
}

if (happyNumbers.Count % columnCount != 0)
{
    Console.WriteLine();
}

