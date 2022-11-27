Console.WriteLine("Введите 3 числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a>max)
{
    max = a;
}
if (c>max)
{
    max = c;
}
if (b>max)
{
    max = b;
}
Console.WriteLine($"Max = {max}");