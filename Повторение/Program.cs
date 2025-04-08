
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

