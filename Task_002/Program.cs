Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
int c = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int b = new Random().Next(1, 10);
    numbers[i] = b;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    if (i % 2 > 0)
    {
        c = c + numbers[i];
        Console.Write(c + " ");
    }
}
Console.WriteLine();
Console.WriteLine("Сумма всех чисел, стоящих на нечетной позиции равна {0}", c);