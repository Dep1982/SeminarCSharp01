string threeDigitNumber = Console.ReadLine();
Console.WriteLine(threeDigitNumber [2]);
int number = int.Parse (threeDigitNumber);
Console.WriteLine(number % 10);
if (number >= 100 && number <= 999);
// Без первых 2 строк выдает с ошибкой, с первыми 2мя строками дает 2 ответа - 3 и последнюю цифры. Как сделать чтобы выдавал только последнюю не разобрался