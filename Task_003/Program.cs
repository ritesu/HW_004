Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
int max = 0;
int min = numbers.Length;
int c = 0;
for (int i = 0; i < numbers.Length; i++)
{
    int b = new Random().Next(-10, 10);
    numbers[i] = b;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= max)
    {
        max = numbers[i];
    }
}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] <= min)
    {
        min = numbers[i];
    }
}
Console.WriteLine("Максимальное число {0}",max);
Console.WriteLine("Минимальное число {0}", min);
if (min < 0)
{
    min = min*-1;
}
c = max - min;
Console.Write("Разница между максимальным и минимальным числом равна {0}", c);