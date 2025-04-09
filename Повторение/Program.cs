
#region begin task-1
Console.Write("Введите сторону квадрата: ");
string a = Console.ReadLine();
bool result = int.TryParse(a, out int number);
if (result)
{
    int p = number * 4;
    Console.WriteLine($"Периметр квадрата со стороной a={a} равана {p}");
}
#endregion

#region begin task-2
if (result)
{
    double dNumber = Convert.ToDouble(number);
    double s = Math.Pow(dNumber, 2);
    Console.WriteLine($"Площадь квадрата со стороной a={a} равана {s}");
}
#endregion

#region if if-t1
Console.WriteLine("===== Задача 6 =====");
Console.Write("Введиете 1-ое число: ");
string firstInput = Console.ReadLine();

Console.Write("Введиете 2-ое число: ");
string secondInput = Console.ReadLine();

Console.Write("Введиете 3-ье число: ");
string thirdInput = Console.ReadLine();
int minNum = MinNumber(firstInput, secondInput, thirdInput);
Console.WriteLine($"Наименьшее число {minNum} среди [{firstInput}, {secondInput}, {thirdInput}]");
int MinNumber(string first, string second, string third)
{
    int firstNum = int.Parse(first);
    int secondNum = int.Parse(second);
    int thirdNum = int.Parse(third);

    if (firstNum < secondNum && firstNum < thirdNum)
        return firstNum;
    else if (secondNum < firstNum && secondNum < thirdNum)
        return secondNum;
    else
        return thirdNum;

}
Console.WriteLine();
#endregion