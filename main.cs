using System;
using System.Collections.Generic;
using System.Diagnostics;

internal static class primes
{
  private static void Main(string[] args)
  {
    var stopWatch = new Stopwatch();
    Console.WriteLine("Enter in a even number above 2");
    stopWatch.Start();
    int number = Int32.Parse(Console.ReadLine()!);
    Console.Write("Your two prime numbers are ");
    Console.WriteLine($"{AddPrimes(number, Primes(number))[0]} and {AddPrimes(number, Primes(number))[1]}");
    stopWatch.Stop();
    TimeSpan ts = stopWatch.Elapsed;
    Console.WriteLine("Time taken: " + ts.ToString(@"mm\:ss\.ff"));

  }
  private static List<int> Primes(int num)
  {
    List<int> Primes = new List<int>();
    for (int n = 1; n <= num; n++)
    {
      List<int> Factors = new List<int>();
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0)
        {
          Factors.Add(i);
        }
      }
      if (Factors.Count == 2)
      {
        Primes.Add(n);
      }
      else
      {
        continue;
      }
    }
    return Primes;
  }
  private static List<int> AddPrimes(int num, List<int> primes) 
  {
    List<int> addPrimes = new List<int>();
    foreach (int p in primes)
    {
      foreach (int i in primes)
      {
        if (p + i == num)
        {
          addPrimes.Add(p);
          addPrimes.Add(i);
          return addPrimes;
        }
      }
    }
    return addPrimes;
  }
}
