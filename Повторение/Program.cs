
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

#region integer integer-t1

Console.Write("Введите двузначное число: ");
string input = Console.ReadLine();
int sumInput = SumNumber(input);
int multiplyInput = MultiplyNumber(input);
int SumNumber(string number)
{
    int num = int.Parse(number);
    int sum = 0;
    if (num >= 10 && num <= 99)
    {
        int firstDigit = num / 10; // Получаем первую цифру
        int secondDigit = num % 10; // Получаем вторую цифру
        sum = firstDigit + secondDigit;

        Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
    }
    return sum;
}

int MultiplyNumber(string number)
{
    int num = int.Parse(number);
    int multiply = 0;
    if (num >= 10 && num <= 99)
    {
        int firstDigit = num / 10; // Получаем первую цифру
        int secondDigit = num % 10; // Получаем вторую цифру
        multiply = firstDigit * secondDigit;

        Console.WriteLine($"Сумма цифр числа {number} равна {multiply}");
    }
    return multiply;
}

#endregion

#region integer integer-t2
Console.WriteLine("===== Задача 5 =====");
Console.Write("Введите число для A = ");
string inputA = Console.ReadLine();
Console.Write("Введите число для B = ");
string inputB = Console.ReadLine();
bool resultCheckCondition = CheckCondition(inputA, inputB);
bool CheckCondition(string strA, string strB)
{
    int intA = int.Parse(strA);
    int intB = int.Parse(strB);

    if (intA > 2 && intB <= 2)
    {
        Console.WriteLine("Условие A > 2 и B <= 3 выполнилось");
        return true;
    }

    else
    {
        Console.WriteLine("Условие A > 2 и B <= 3 невыполнилось");
        return false;
    }

}
Console.WriteLine();
#endregion