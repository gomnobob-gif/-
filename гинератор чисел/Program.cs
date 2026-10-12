Console.WriteLine("Введите значение от 0 до 10");
int firstNun = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("начало цикла if");
for (int i = firstNun; i <= 100; i++)
{
    Console.WriteLine($"Ваше значаения i:  {i}");
    if (i % 2 == 0)
    {
        Console.WriteLine($"четные значения числа:{i}");
    }
    else
    {
        Console.WriteLine($"нечетные значения числа: {i}");
    }
}
Console.WriteLine("конец цыкла for");
Console.ReadLine();

for (int i = 16; i <= 100; i++)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"первое значение которое делится на 7: {i}");
        break;
    }
}

