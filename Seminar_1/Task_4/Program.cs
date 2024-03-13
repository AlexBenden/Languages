//Написать программу которая на входе принимает одно число (N), а на выходе показывает все целые числа в промежутке -N до N
// 4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.WriteLine("Ведите число");

int num1 = Convert.ToInt32(Console.ReadLine());

int negNum = num1 * -1;

while(negNum<=num1)
{
    Console.Write(negNum+" ");
    negNum = negNum + 1;
}
