Console.WriteLine("Введите 2 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;

if (a>b)
{
    max = a;
    min = b;
    Console.WriteLine($"Max = {max}, Min = {min}");
}
else
{
    max = b;
    min = a;
    Console.WriteLine($"Max = {max}, Min = {min}");
}