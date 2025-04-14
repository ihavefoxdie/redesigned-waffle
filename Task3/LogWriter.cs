using System;
using System.Text;

namespace Task3;

public class LogWriter
{
    public static void WriteLogs(string input, string output)
    {
        LogStandardizer logStandardizer = new();
        try
        {
            using StreamWriter problemsWriter = File.AppendText("problems.txt");
            using StreamWriter writer = File.AppendText(output);
            using StreamReader reader = new(input);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string? logMessage = logStandardizer.Process(line);
                if (logMessage == null)
                {
                    problemsWriter.WriteLine(line);
                }
                else
                {
                    writer.WriteLine(logMessage);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
