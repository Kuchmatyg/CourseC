public class Program
{
    public static void Main(string[] str)
    {
        #region begin task-1
        Console.WriteLine($"===== Задание 1 =====");
        Console.Write("Введите сторону квадрата: ");
        string a = Console.ReadLine();
        bool result = int.TryParse(a, out int number);
        if (result)
        {
            int p = CalculateThePerimeterOfSquare(number);
            Console.WriteLine($"Периметр квадрата со стороной a={a} равана {p}");
        }
        #endregion

        #region begin task-2
        Console.WriteLine($"\n===== Задание 2 =====");
        if (result)
        {
            double dNumber = Convert.ToDouble(number);
            double s = CalculateTheAreaOfSquare(number);
            Console.WriteLine($"Площадь квадрата со стороной a={a} равана {s}");
        }
        #endregion

        #region begin task-3
        Console.WriteLine($"\n===== Задание 3 =====");
        Console.Write("Введите 1-ую сторуну прямоугольника: ");
        a  = Console.ReadLine();

        Console.Write("Введите 2-ую сторуну прямоугольника: ");
        string b = Console.ReadLine();

        var (perimeter, area) = CalculateThePerimeterAndArea(a, b);

        Console.WriteLine($"Периметр прямоугольника P={perimeter}");
        Console.WriteLine($"Площадь прямоугольника S={area}");
        //if (resultA && resultB)
        //{
        //    int p = 2 * (numberA + numberB);
        //    int s = numberA * numberB;

        //    Console.WriteLine($"Периметр прямоугольника P={p}");
        //    Console.WriteLine($"Площадь прямоугольника S={s}");
        //}
        Console.WriteLine();
        #endregion

        #region integer integer-t1
        Console.WriteLine("===== Задача 4 =====");
        Console.Write("Введите двузначное число: ");
        string input = Console.ReadLine();
        int sumInput = SumNumber(input);
        int multiplyInput = MultiplyNumber(input);
        #endregion

        #region integer integer-t2
        Console.WriteLine("===== Задача 5 =====");
        Console.Write("Введите число для A = ");
        string inputA = Console.ReadLine();
        Console.Write("Введите число для B = ");
        string inputB = Console.ReadLine();
        bool resultCheckCondition = CheckCondition(inputA, inputB);
        Console.WriteLine();
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
        Console.WriteLine();
        #endregion


        #region case case-t1 
        Console.WriteLine("===== Задача 7 =====");
        Console.Write("Введите цифру от 1-7: ");
        string inputDayOfWeek = Console.ReadLine();
        string messageDayOfWeek = ReturnMessageDayOfWeek(inputDayOfWeek);
        Console.WriteLine(messageDayOfWeek);
        Console.WriteLine();
        #endregion

        #region while while-t1 
        Console.WriteLine("===== Задача 9 =====");
        Console.Write("Введите сумму 0 < P <= 25 которая в месяц будет прибавляться к вкладу: ");
        int percent = int.Parse(Console.ReadLine());
        string messageDepositAndCountMounths = FindDepositAndCountMounths(percent);
        Console.WriteLine(messageDepositAndCountMounths);
        Console.WriteLine();
        #endregion

        #region case case-t1 
        Console.WriteLine("===== Задача 10 =====");
        Console.Write("Введите коэффициент A (A != 0): ");
        int coefficientA = int.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент B: ");
        int coefficientB = int.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент C: ");
        int coefficientC = int.Parse(Console.ReadLine());
        int countRoots = ReturnTheRootsOfTheEquation(coefficientA, coefficientB, coefficientC);
        Console.WriteLine($"Количестов корней: {countRoots}   для уравнения {coefficientA}x^2+{coefficientB}x+{coefficientC}=0");
        #endregion  

    }
    //Для 1-го задания
    public static int CalculateThePerimeterOfSquare(int num)
    {
        return num * 4;
    }
    //Для 2-го задания
    public static double CalculateTheAreaOfSquare(double num)
    {
        return Math.Pow(num, 2);
    }

    //Для 3-го задания
    public static (int, int) CalculateThePerimeterAndArea(string side1, string side2)
    {
        bool resultSide1 = int.TryParse(side1, out int numberA);
        bool resultSide2 = int.TryParse(side2, out int numberB);

        if (resultSide1 && resultSide2)
        {
            int p = 2 * (numberA + numberB);
            int s = numberA * numberB;
            return (p, s);
        }
        else
        {
            Console.WriteLine("Вы ввели не число!");
            return (-10, -10);
        }
    }

    //Для 4-го задания
    public static int SumNumber(string number)
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

    //Для 4-го задания
    public static int MultiplyNumber(string number)
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

    //Для 5-го задания
    public static bool CheckCondition(string strA, string strB)
    {
        int intA = int.Parse(strA);
        int intB = int.Parse(strB);

        if (intA > 2 && intB <= 3)
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

    //Для 6-го задания
    public static int MinNumber(string first, string second, string third)
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

    //Для 7-го задания
    public static string ReturnMessageDayOfWeek(string dayOfWeek) 
    {
        switch (dayOfWeek)
        {
            case "1":
                return $"Понедельник соответствует цифре {dayOfWeek}";
                
            case "2":
                return $"Вторник соответствует цифре {dayOfWeek}";
                
            case "3":
                return $"Среда соответствует цифре {dayOfWeek}";
                
            case "4":
                return $"Четверг соответствует цифре {dayOfWeek}";
                
            case "5":
                return $"Пятница соответствует цифре {dayOfWeek}";
                
            case "6":
                return $"Суббота соответствует цифре {dayOfWeek}";

            case "7":
                return $"Воскресенье соответствует цифре {dayOfWeek}";

            default:
                return $"Данная цифра {dayOfWeek} не соответствует дням недели";
        }
    }

    //Для 9-го задания
    public static string FindDepositAndCountMounths(int per)
    {
        if (per > 25) return $"Слишком большая сумма процента {per}";

        int deposite = 1000;
        int countMouths = 0;
        while (deposite < 1100)
        {
            deposite += per;
            countMouths++;
        }
        return $"От 1000 до {deposite} за {countMouths} месяц(а/ев) при сумме процента {per}";

    }

    //Для 10-го задания
    public static int ReturnTheRootsOfTheEquation(int a, int b, int c)
    {
        float D = b * b - 4 * a * c;
        if (D < 0)
            return 0;
        else if (D > 0)
            return 2;
        else
            return 1;

    }
}