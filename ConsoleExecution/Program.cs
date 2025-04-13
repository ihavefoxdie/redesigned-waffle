using System.Runtime.InteropServices;
using Task3;

Console.WriteLine("Hi!");

// Task2.Counter counter = new();

// Stopwatch stopwatch = new Stopwatch();
// stopwatch.Start();
// Parallel.For(0, 5, i =>
// {
//     counter.AddToCount = 10;
//     Console.WriteLine($"Added to the counter. Time: {stopwatch.Elapsed}");
//     Console.WriteLine($"Reading the counter. Time: {stopwatch.Elapsed}, counter: {counter.GetCount}");
// });

// Parallel.For(0, 5, i =>
// {
//     counter.AddToCount = 10;
//     Task.Delay(2000).Wait();
// });

//LogStandardizer logStandardizer = new ();

//Console.WriteLine(logStandardizer.Process("10.03.2025 15:14:49.523 INFORMATION Версия программы: '3.4.0.48729'"));
//Console.WriteLine(logStandardizer.Process("2025-03-10 15:14:51.5882|INFO|MobileComputer.GetDeviceId|Код устройства: '@MINDEO-M40-D-410244015546'"));

LogWriter.WriteLogs("unprocessedLogs.txt", "processedLogs.txt");