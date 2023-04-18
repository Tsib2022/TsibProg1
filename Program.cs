int a, b, max, min;
a = 5;
b = 7;
if (a > b)
{
    max =a;
    min =b;
}
else
{
    max =b;
    min =a;
}

Console.WriteLine("Минимальное = ");
Console.WriteLine(min);
Console.WriteLine("Максимальное =");
Console.WriteLine(max);