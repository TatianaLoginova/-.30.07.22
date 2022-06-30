int a, b;

Console.Write("Введите певое число: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("Максимальное число " + a);
} 
else
{
    Console.Write("Максимальное число " + b);
}

