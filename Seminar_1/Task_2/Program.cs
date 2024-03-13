//Написать программу которая на вход принимает два числа и проверяет является первое чсило квадратом второго
//а = 25, и = 5 -> да
//а = 2, и = 10 -> нет
//а = 9, и = -3 -> да
//а = -3, и = 9 -> нет

Console.WriteLine("Ведите первое число");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число");

int num2 = Convert.ToInt32(Console.ReadLine());

int num3 = num2 * num2;

if (num3 == num1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Перове число не является квадратом второго");
}