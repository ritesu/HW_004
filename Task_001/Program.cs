Console.WriteLine("Введите размер массива");
int a = int.Parse(Console.ReadLine()?? "");
int[] numbers = new int[a];
for (int i = 0; i < numbers.Length; i++)
{
    int b = new Random().Next(100, 1000);
    numbers[i] = b;
}
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Array.Sort(numbers);
foreach (int i in numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

int FindNumber1(int[] numbers)
{
    int result = 0;
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
               
        if(numbers[i] % 2 == 0) 
        {
            count++;
            if (count>result) result = count;
        }
            
        
    }
    return result;
}
FindNumber1(numbers);
Console.WriteLine("Колличество четных чисел равно {0}", FindNumber1(numbers));