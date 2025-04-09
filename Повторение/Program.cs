
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

#region case case-t1 
Console.WriteLine("===== Задача 7 =====");
Console.Write("Введите цифру от 1-7: ");
string inputDayOfWeek = Console.ReadLine();

switch(inputDayOfWeek)
{
    case "1":
        Console.WriteLine($"Понедельник соответствует цифре {inputDayOfWeek}");
        break;
    case "2":
        Console.WriteLine($"Вторник соответствует цифре {inputDayOfWeek}");
        break;
    case "3":
        Console.WriteLine($"Среда сответствует цифре {inputDayOfWeek}");
        break;
    case "4":
        Console.WriteLine($"Четверг соответствует цифре {inputDayOfWeek}");
        break;
    case "5":
        Console.WriteLine($"Пятница соответствует цифре {inputDayOfWeek}");
        break;
    case "6":
        Console.WriteLine($"Суббота соответствует цифре {inputDayOfWeek}");
        break;
    case "7":
        Console.WriteLine($"Воскресенье соответствует цифре {inputDayOfWeek}");
        break;
    default:
        break;
}
Console.WriteLine();
#endregion


#region case case-t1 
Console.WriteLine("===== Задача 9 =====");
Console.Write("Введите сумму 0 < P <= 25 которая в месяц будет прибавляться к вкладу: ");
int percent = int.Parse(Console.ReadLine());
FindDepositAndCountMounths(percent);
void FindDepositAndCountMounths(int per)
{
    int deposite = 1000;
    int countMouths = 0;
    while (deposite < 1100)
    {
        deposite += per;
        countMouths++;
    }
    Console.WriteLine($"От 1000 до {deposite} за {countMouths} месяц(а/ев) при сумме процента {per}");
}
Console.WriteLine();
#endregion
