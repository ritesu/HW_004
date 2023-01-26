Console.WriteLine("Введите длину массива");
int a = int.Parse(Console.ReadLine()?? "0");
int[] numbers = new int [a];
for (int i = 0; i < numbers.Length; i++)
{
    int num = new Random().Next(20, 25);
    numbers[i] = num;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 20)
    {
        numbers[i] = 20 + 180;
        break;
    }
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();