using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повторение
{
    public class Kata
    {
        /// <summary>
        /// Выводить количество повторяющихся буквенных и цифровых символов, не зависящие от регистра
        /// </summary>
        /// <param name="str">Строка символов из букв и цифр</param>
        /// <returns></returns>
        public static int DuplicateCount(string str)
        {
            str = str.ToLower();

            Dictionary<char, int> distinctCount = new Dictionary<char, int>();
            foreach (var item in str)
            {
                if (distinctCount.ContainsKey(item))
                    distinctCount[item] += 1;
                else
                    distinctCount[item] = 1;
            }

            int count = 0;
            foreach (var itemValue in distinctCount.Values)
                if (itemValue > 1)
                    count += 1;

            return count;
        }

        /// <summary>
        /// Возвращает true если прогулка вернулась в исходное положенме и равна 10 минутам (массив из 10 элементов)
        /// </summary>
        /// <param name="walk">Массив последовательности движения маршрута</param>
        /// <returns></returns>
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length > 10 || walk.Length < 3)
                return false;
            //insert brilliant code here
            int countN = walk.Where(x => x == "n").Count();
            int countS = walk.Where(x => x == "s").Count();
            int countW = walk.Where(x => x == "w").Count();
            int countE = walk.Where(x => x == "e").Count();     
            if (countN == countS && countW == countE)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Возвращает последовательность элементов, удаляя повторяющиеся подряд элементы (сохраняя порядок)
        /// </summary>
        /// <typeparam name="T">Тип элементов последовательности (может быть любым)</typeparam>
        /// <param name="iterable">Входная последовательность. Может быть null или пустой.</param>
        /// <returns>
        /// Последовательность элементов без повторений подряд.
        /// Для null или пустой входной последовательности вернет пустую коллекцию.
        /// </returns>
        /// <example>
        /// UniqueInOrder("AAAABBBCCDAABBB") → ['A', 'B', 'C', 'D', 'A', 'B']
        /// UniqueInOrder(new [] {1, 2, 2, 3, 3}) → [1, 2, 3]
        /// UniqueInOrder(null) → []
        /// </example>
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            if (iterable == null || !iterable.Any())
                yield break;

            T prev = iterable.First();
            yield return prev;

            foreach (T item in iterable.Skip(1))
            {
                if (!EqualityComparer<T>.Default.Equals(item, prev))
                {
                    yield return item;
                    prev = item;
                }
            }
        }

        /// <summary>
        /// Находит целое положительное число k (если оно существует), такое что сумма цифр числа n,
        /// возведённых в последовательные степени начиная с p, равна k * n.
        /// </summary>
        /// <param name="n">Проверяемое число (целое положительное).</param>
        /// <param name="p">Начальная степень (целое положительное).</param>
        /// <returns>
        /// - Множитель k, если сумма равна k * n.
        /// - -1, если такого k не существует.
        /// </returns>
        /// <example>
        /// digPow(89, 1) → 1 (8^1 + 9^2 = 89 = 89*1)
        /// digPow(92, 1) → -1 (9^1 + 2^2 = 13 ≠ 92*k)
        /// </example>
        public static long digPow(int n, int p)
        {
            string digits = n.ToString();
            double sum = 0;
            int currentPower = p;

            foreach (char c in digits)
            {
                int digit = int.Parse(c.ToString());
                sum += Math.Pow(digit, currentPower);
                currentPower++;
            }

            // Check if sum is divisible by n
            if (sum % n == 0)
            {
                return (long)(sum / n);
            }

            return -1;
        }


        /// <summary>
        /// Конвертирует целое число в римскую цифру (строку)
        /// </summary>
        /// <param name="n">Целое число от 1 до 3999 включительно</param>
        /// <returns>Строка с римским числом</returns>
        /// <exception cref="ArgumentOutOfRangeException">Выбрасывается при числе вне допустимого диапазона</exception>
        public static string Solution(int n)
        {
            if (n < 1 || n > 3999)
                throw new ArgumentOutOfRangeException(nameof(n), "Input must be between 1 and 3999");

            var numerals = new[]
            {
            new { Value = 1000, Symbol = "M" },
            new { Value = 900, Symbol = "CM" },
            new { Value = 500, Symbol = "D" },
            new { Value = 400, Symbol = "CD" },
            new { Value = 100, Symbol = "C" },
            new { Value = 90, Symbol = "XC" },
            new { Value = 50, Symbol = "L" },
            new { Value = 40, Symbol = "XL" },
            new { Value = 10, Symbol = "X" },
            new { Value = 9, Symbol = "IX" },
            new { Value = 5, Symbol = "V" },
            new { Value = 4, Symbol = "IV" },
            new { Value = 1, Symbol = "I" }
        };

            var result = new System.Text.StringBuilder();
            int remaining = n;

            foreach (var numeral in numerals)
            {
                while (remaining >= numeral.Value)
                {
                    result.Append(numeral.Symbol);
                    remaining -= numeral.Value;
                }
            }

            return result.ToString();
        }


        /// <summary>
        /// Перемещает все нули в конец массива с сохранением порядка остальных элементов
        /// </summary>
        /// <param name="arr">Входной массив целых чисел</param>
        /// <returns>
        /// Новый массив, где все нули находятся в конце,
        /// а порядок ненулевых элементов сохранен
        /// </returns>
        public static int[] MoveZeroes(int[] arr)
        {
            var nonZeros = arr.Where(x => x != 0).ToArray();
            var zeros = new int[arr.Length - nonZeros.Length];
            return nonZeros.Concat(zeros).ToArray();
        }

        /// <summary>
        /// Подсчитывает количество единичных битов в двоичном представлении числа
        /// </summary>
        /// <param name="n">Неотрицательное целое число</param>
        /// <returns>Количество битов, равных 1</returns>
        public static int CountBits(int n)
        {
            int count = 0;

            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }

            return count;
        }

        /// <summary>
        /// Шифрует строку с помощью алгоритма ROT13
        /// </summary>
        /// <param name="message">Исходная строка для шифрования</param>
        /// <returns>Зашифрованная строка</returns>
        public static string Rot13(string message)
        {
            StringBuilder result = new StringBuilder(message.Length);

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char rotated = (char)(((c - baseChar + 13) % 26 + baseChar));
                    result.Append(rotated);
                }
                else result.Append(c);

            }

            return result.ToString();
        }


        /// <summary>
        /// Находит уникальное число в массиве, где все остальные числа одинаковы
        /// </summary>
        /// <param name="numbers">Входной массив чисел</param>
        /// <returns>Уникальное число</returns>
        public static int GetUnique(IEnumerable<int> numbers)
        {
            var firstThree = numbers.Take(3).ToArray();
            int commonNumber = firstThree[0] == firstThree[1] ? firstThree[0] : firstThree[2];

            foreach (int num in numbers)
            {
                if (num != commonNumber)
                    return num;
            }

            return 0;
        }

        /// <summary>
        /// Находит все пары чисел (a, b) в последовательности от 1 до n,
        /// где произведение a*b равно сумме всех чисел последовательности без a и b
        /// </summary>
        /// <param name="n">Верхняя граница последовательности (1..n)</param>
        /// <returns>
        /// Список массивов из двух элементов [a, b], отсортированный по возрастанию a.
        /// Если таких пар нет, возвращает пустой список.
        /// </returns>
        public static List<long[]> removNb(long n)
        {
            List<long[]> result = new List<long[]>();
            long totalSum = n * (n + 1) / 2;

            for (long a = 1; a <= n; a++)
            {
                long numerator = totalSum - a;
                long denominator = a + 1;

                if (numerator % denominator == 0)
                {
                    long b = numerator / denominator;
                    if (b <= n && b > 0)
                    {
                        result.Add(new long[] { a, b });
                    }
                }
            }

            return result;
        }
    }
}
