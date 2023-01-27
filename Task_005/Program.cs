Console.WriteLine("Введите колличество кеглей");
int a = int.Parse(Console.ReadLine()?? "0");
int[] numbers1 = Enumerable.Range(1, 100).ToArray();
Array.Resize(ref numbers1, a);
int a1 = a + 1;
int d = 0;
int b = new Random().Next(1, 6);
int[] mass = new int [b];
Console.WriteLine(b);
for (int i = 0; i < mass.Length; i++)
{
    int c = new Random().Next(1, a1);
    Console.WriteLine("c = " + c);
    int c1 = c + 1;
    int c2 = c - 1;
    if (c1 > a)
    {
        c1 = 0;
    }
    if (c2 < 0)
    {
        c2 = 0;
    }
    for (int j = 0; j < numbers1.Length; j++)
    {
        if (c == numbers1[j])
        {
            numbers1[j] = 0;
        }
        else if (c1 == numbers1[j])
        {
            numbers1[j] = 0;
        }
        else if (c2 == numbers1[j])
        {
            numbers1[j] = 0;
        }
    }
    for (int k = 0; k < numbers1.Length; k++)
    {
        if (numbers1[k] > 0)
        {
            d++;
        }
    }
    if (d > 0)
    {  
        Array.Sort(numbers1);
        Array.Reverse(numbers1);
        Array.Resize(ref numbers1, d);
        Array.Reverse(numbers1);
        d = 0;
    }
}
d = 0;
for (int i = 0; i < numbers1.Length; i++)
    {
        if (numbers1[i] > 0)
        {
            d++;
        }
    }
Console.WriteLine("Шар бросили {0} раз", b);
int e = 0;
Array.Resize(ref numbers1, a);
Array.Sort(numbers1);
for (int i = 0; i < numbers1.Length; i++)
{
    if (numbers1[i] == 0)
    {
        e++;
    }
}
Console.WriteLine("Кеглей(я) было сбито(а): {0}", e);

Array.Reverse(numbers1);
Array.Resize(ref numbers1, d);
Array.Reverse(numbers1);
d = 0;
for (int i = 0; i < numbers1.Length; i++)
    {
        if (numbers1[i] > 0)
        {
            d++;
        }
    }
Console.WriteLine("Остались(ась) кегли(ля) {0} шт. под номером:", d);
foreach (int i in numbers1)
{
    Console.Write(i + " ");
}