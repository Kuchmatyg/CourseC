
{
    #region begin task-1
    Console.WriteLine($"===== Задание 1 =====");
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
    Console.WriteLine($"\n===== Задание 2 =====");
    if (result)
    {
        double dNumber = Convert.ToDouble(number);
        double s = Math.Pow(dNumber, 2);
        Console.WriteLine($"Площадь квадрата со стороной a={a} равана {s}");
    }
    #endregion
}

{
    #region begin task-3
    Console.WriteLine($"\n===== Задание 3 =====");
    Console.Write("Введите 1-ую сторуну прямоугольника: ");
    string a  = Console.ReadLine();

    Console.Write("Введите 2-ую сторуну прямоугольника: ");
    string b = Console.ReadLine();

    bool resultA = int.TryParse(a, out int numberA);
    bool resultB = int.TryParse(b, out int numberB);
    
    if (resultA && resultB)
    {
        int p = 2 * (numberA + numberB);
        int s = numberA * numberB;

        Console.WriteLine($"Периметр прямоугольника P={p}");
        Console.WriteLine($"Площадь прямоугольника S={s}");
    }
    #endregion
}

