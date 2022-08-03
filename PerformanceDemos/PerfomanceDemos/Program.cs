using System.Diagnostics;
using PerfomanceDemos;

#region Parallel Programming

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

#endregion

#region Lowering

// Go to https://sharplab.io/#v2:CYLg1APgAgTAjAWAFBQMwAJboMLoN7LpGYZQAs6AsgBQCU+hxTAbgIYBO6AlgC4CmAWwDO6ALzoAdnwDuAbQC6+dACJsHIcoA0KtTw3blAEQD2Ac30qAKuz58N6AL4BuRkyIAzYzdYBjABbo1GycvILcEtz8wrSubgRIbomYcACc1AAkygCSUSJcInihAg7KtC4JSQ7IsUyenNRcEjzcYugADE4tADyRgkIAdAAyfBKmPH6dXGBgMRWJ8Uluwb0CrUVCslzy5YtMUKkZ2VHcBUUlZTXEVUiXRI3NjcB8AB6tHbfo0n5cADZ8gY8XugeushiMxn5ZosFrsiMsimtcpsJE9ntsPnsDpkcmF8vgzqUdrDwqjpkTEtcmNcHEA===
// to test this out

var items = new[] { "Cars", "Cats", "Dogs", "Trees" };
foreach (var item in items)
{
    Console.WriteLine($"Items is {item}");
}

for (int i = 0; i < items.Length; i++)
{
    var item = items[i];
    Console.WriteLine($"Item is {item}");
}

int index = 0;
while (index < items.Length)
{
    var item = items[index];
    Console.WriteLine($"Item is {item}");
    index++;
}

#endregion
