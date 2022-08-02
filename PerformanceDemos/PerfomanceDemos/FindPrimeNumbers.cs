using System.Diagnostics;

namespace PerfomanceDemos;

public class FindPrimeNumbers
{
    public static List<int> GetPrimeNumbers(int minimum, int maximum)
    {
        List<int> result = new List<int>();
        for (int i = minimum; i <= maximum; i++)
        {
            if (IsPrimeNumber(i))
            {
                result.Add(i);
            }
        }
        return result;

    }

    static bool IsPrimeNumber(int number)
    {
        if (number % 2 == 0)
        {
            return number == 2;
        }
        else
        {
            var topLimit = (int)Math.Sqrt(number);

            for (int i = 3; i <= topLimit; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}