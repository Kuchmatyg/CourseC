
Console.Write("Введите сторону квадрата: ");
string a = Console.ReadLine();
if (int.TryParse(a, out int number))
{
    int p = number * 4;
    Console.WriteLine($"Периметр квадрата со стороной a={a} равана {p}");
}

