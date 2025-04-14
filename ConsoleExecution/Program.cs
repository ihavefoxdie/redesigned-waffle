using Task3;

Console.WriteLine("Hi!");


string input = "unprocessedLogs.txt";
string output = "processedLogs.txt";

using (FileStream stream = File.Create(input))
{

}
LogWriter.WriteLogs(input, output);