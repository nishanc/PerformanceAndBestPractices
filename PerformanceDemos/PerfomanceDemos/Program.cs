using System.Diagnostics;
using PerfomanceDemos;

var sw = new Stopwatch();
sw.Start();

// var primes = FindPrimeNumbers.GetPrimeNumbers(2, 10000000);
// Console.WriteLine("Total prime numbers: {0}\nProcess time: {1}", primes.Count, sw.ElapsedMilliseconds);


sw.Start();
const int numParts = 10;
var primes = new List<int>[numParts];
Parallel.For(0, numParts, i => primes[i] = FindPrimeNumbers.GetPrimeNumbers(i == 0 ? 2 : i * 1000000 + 1, (i + 1) * 1000000));
var result = primes.Sum(p => p.Count);
Console.WriteLine("Total prime numbers: {0}\nProcess time: {1}", result, sw.ElapsedMilliseconds);