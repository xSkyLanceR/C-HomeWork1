//Задача 1
Console.WriteLine("Введите два числа и узнайте какое из них больше");
var x1 = Decimal.Parse(Console.ReadLine());
var x2 = Decimal.Parse(Console.ReadLine());
            if (x1 > x2)
                Console.WriteLine(x1);
            else 
                Console.WriteLine(x2);
            if (x1 == x2)
                Console.WriteLine("Они равны");

//Задача 2
Console.WriteLine("Введите три числа и узнайте какое из них максимальное");
var x1 = Decimal.Parse(Console.ReadLine());
var x2 = Decimal.Parse(Console.ReadLine());
var x3 = Decimal.Parse(Console.ReadLine());
var max = x1;
if (x2 > max) max = x2;
if (x3 > max) max = x3;
Console.Write("Максимальное число = ");
Console.WriteLine(max);

//Задача 3
Console.WriteLine("Введите число и узнайте чётное оно или нет");
int x = int.Parse(Console.ReadLine());
double x2 = x % 2;
    if (x2 == 0)
        Console.WriteLine("Число чётное");
        else
        {
        Console.WriteLine("Число нечётное");  
        }

//Задача 4
Console.WriteLine("Введите число");
int y = int.Parse(Console.ReadLine());
int x = 1;
    for (int i = x; i <= y; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
