using System;
using System.Collections.Generic;

internal static class primes
{
  private static void Main(string[] args)
  {
    Console.WriteLine("Enter in a even number above 2");
    ulong number = UInt64.Parse(Console.ReadLine()!);
    Console.Write("Your two prime numbers are ");
    Console.WriteLine($"{AddPrimes(number, Primes(number))[0]} and {AddPrimes(number, Primes(number))[1]}");

  }
  private static List<ulong> Primes(ulong num)
  {
    List<ulong> Primes = new List<ulong>();
    for (ulong n = 1; n <= num; n++)
    {
      List<ulong> Factors = new List<ulong>();
      for (ulong i = 1; i <= n; i++)
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
  private static List<ulong> AddPrimes(ulong num, List<ulong> primes) 
  {
    List<ulong> addPrimes = new List<ulong>();
    foreach (ulong p in primes)
    {
      foreach (ulong i in primes)
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
