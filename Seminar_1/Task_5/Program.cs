//Напишите программу которая на входе принимает трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6

Console.WriteLine("Ведите число");

int num1 = Convert.ToInt32(Console.ReadLine());

int result = num1 %10;

Console.WriteLine("Последнее число "+result);