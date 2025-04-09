
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
