
Console.WriteLine("Введите 2 числа");
string frstNum = Console.ReadLine();
string scndNum = Console.ReadLine();
var num1 = double.Parse(frstNum);
var num2 = double.Parse(scndNum);
if (num1 * num1 == num2)
{
    Console.Write($"{num1} квадратный корень числа {num2}");
}
else if (num2 * num2 == num1)
{
    Console.Write($"{num2} квадратный корень числа {num1}");
}
else
{
    Console.Write("Числа не являются квадратами друг друга");
}
