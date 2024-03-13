//Напишите программу которая на вход принимает число и на выход выдает квадрат данного числа (число умноженное на самого себя)
//Например:
// 4 -> 16
// -3 -> 9

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine(result);