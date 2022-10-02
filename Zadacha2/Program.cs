
Console.WriteLine("Введите 2 числа");
string frstNum = Console.ReadLine();
string scndNum = Console.ReadLine();
var num1 = double.Parse(frstNum);
var num2 = double.Parse(scndNum);
if (num1 * num1 == num2)
{
    Console.Write($"{num1} квадратный корень числа {num2}");
}

else
{
    Console.Write("Числа не являются квадратами друг друга");
}
// Чтобы решить задачу как в презентации, т.е. проверить является ли первое число квадратом второго, неоходимо из данное программы удалить строки связанные с else if (11, 12, 13, 14)